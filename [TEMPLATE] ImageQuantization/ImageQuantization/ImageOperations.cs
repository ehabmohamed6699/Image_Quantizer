using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Linq;
///Algorithms Project
///Intelligent Scissors
///

namespace ImageQuantization
{
    /// <summary>
    /// Holds the pixel color in 3 byte values: red, green and blue
    /// </summary>
    public struct RGBPixel
    {
        public byte red, green, blue;
    }
    public struct RGBPixelD
    {
        public double red, green, blue;
    }


    /// <summary>
    /// Library of static functions that deal with images
    /// </summary>
    public class ImageOperations
    {
        /// <summary>
        /// Open an image and load it into 2D array of colors (size: Height x Width)
        /// </summary>
        /// <param name="ImagePath">Image file path</param>
        /// <returns>2D array of colors</returns>
        public static RGBPixel[,] OpenImage(string ImagePath)
        {
            Bitmap original_bm = new Bitmap(ImagePath);
            int Height = original_bm.Height;
            int Width = original_bm.Width;

            RGBPixel[,] Buffer = new RGBPixel[Height, Width];

            unsafe
            {
                BitmapData bmd = original_bm.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, original_bm.PixelFormat);
                int x, y;
                int nWidth = 0;
                bool Format32 = false;
                bool Format24 = false;
                bool Format8 = false;

                if (original_bm.PixelFormat == PixelFormat.Format24bppRgb)
                {
                    Format24 = true;
                    nWidth = Width * 3;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format32bppArgb || original_bm.PixelFormat == PixelFormat.Format32bppRgb || original_bm.PixelFormat == PixelFormat.Format32bppPArgb)
                {
                    Format32 = true;
                    nWidth = Width * 4;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    Format8 = true;
                    nWidth = Width;
                }
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (y = 0; y < Height; y++)
                {
                    for (x = 0; x < Width; x++)
                    {
                        if (Format8)
                        {
                            Buffer[y, x].red = Buffer[y, x].green = Buffer[y, x].blue = p[0];
                            p++;
                        }
                        else
                        {
                            Buffer[y, x].red = p[2];
                            Buffer[y, x].green = p[1];
                            Buffer[y, x].blue = p[0];
                            if (Format24) p += 3;
                            else if (Format32) p += 4;
                        }
                    }
                    p += nOffset;
                }
                original_bm.UnlockBits(bmd);
            }

            return Buffer;
        }

        /// <summary>
        /// Get the height of the image 
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <returns>Image Height</returns>
        public static int GetHeight(RGBPixel[,] ImageMatrix)
        {
            return ImageMatrix.GetLength(0);
        }

        /// <summary>
        /// Get the width of the image 
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <returns>Image Width</returns>
        public static int GetWidth(RGBPixel[,] ImageMatrix)
        {
            return ImageMatrix.GetLength(1);
        }

        /// <summary>
        /// Display the given image on the given PictureBox object
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <param name="PicBox">PictureBox object to display the image on it</param>
        public static void DisplayImage(RGBPixel[,] ImageMatrix, PictureBox PicBox)
        {
            // Create Image:
            //==============
            int Height = ImageMatrix.GetLength(0);
            int Width = ImageMatrix.GetLength(1);

            Bitmap ImageBMP = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);

            unsafe
            {
                BitmapData bmd = ImageBMP.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, ImageBMP.PixelFormat);
                int nWidth = 0;
                nWidth = Width * 3;
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        p[2] = ImageMatrix[i, j].red;
                        p[1] = ImageMatrix[i, j].green;
                        p[0] = ImageMatrix[i, j].blue;
                        p += 3;
                    }

                    p += nOffset;
                }
                ImageBMP.UnlockBits(bmd);
            }
            PicBox.Image = ImageBMP;
        }


        /// <summary>
        /// Apply Gaussian smoothing filter to enhance the edge detection 
        /// </summary>
        /// <param name="ImageMatrix">Colored image matrix</param>
        /// <param name="filterSize">Gaussian mask size</param>
        /// <param name="sigma">Gaussian sigma</param>
        /// <returns>smoothed color image</returns>
        public static RGBPixel[,] GaussianFilter1D(RGBPixel[,] ImageMatrix, int filterSize, double sigma)
        {
            int Height = GetHeight(ImageMatrix);
            int Width = GetWidth(ImageMatrix);

            RGBPixelD[,] VerFiltered = new RGBPixelD[Height, Width];
            RGBPixel[,] Filtered = new RGBPixel[Height, Width];


            // Create Filter in Spatial Domain:
            //=================================
            //make the filter ODD size
            if (filterSize % 2 == 0) filterSize++;

            double[] Filter = new double[filterSize];

            //Compute Filter in Spatial Domain :
            //==================================
            double Sum1 = 0;
            int HalfSize = filterSize / 2;
            for (int y = -HalfSize; y <= HalfSize; y++)
            {
                //Filter[y+HalfSize] = (1.0 / (Math.Sqrt(2 * 22.0/7.0) * Segma)) * Math.Exp(-(double)(y*y) / (double)(2 * Segma * Segma)) ;
                Filter[y + HalfSize] = Math.Exp(-(double)(y * y) / (double)(2 * sigma * sigma));
                Sum1 += Filter[y + HalfSize];
            }
            for (int y = -HalfSize; y <= HalfSize; y++)
            {
                Filter[y + HalfSize] /= Sum1;
            }

            //Filter Original Image Vertically:
            //=================================
            int ii, jj;
            RGBPixelD Sum;
            RGBPixel Item1;
            RGBPixelD Item2;

            for (int j = 0; j < Width; j++)
                for (int i = 0; i < Height; i++)
                {
                    Sum.red = 0;
                    Sum.green = 0;
                    Sum.blue = 0;
                    for (int y = -HalfSize; y <= HalfSize; y++)
                    {
                        ii = i + y;
                        if (ii >= 0 && ii < Height)
                        {
                            Item1 = ImageMatrix[ii, j];
                            Sum.red += Filter[y + HalfSize] * Item1.red;
                            Sum.green += Filter[y + HalfSize] * Item1.green;
                            Sum.blue += Filter[y + HalfSize] * Item1.blue;
                        }
                    }
                    VerFiltered[i, j] = Sum;
                }

            //Filter Resulting Image Horizontally:
            //===================================
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    Sum.red = 0;
                    Sum.green = 0;
                    Sum.blue = 0;
                    for (int x = -HalfSize; x <= HalfSize; x++)
                    {
                        jj = j + x;
                        if (jj >= 0 && jj < Width)
                        {
                            Item2 = VerFiltered[i, jj];
                            Sum.red += Filter[x + HalfSize] * Item2.red;
                            Sum.green += Filter[x + HalfSize] * Item2.green;
                            Sum.blue += Filter[x + HalfSize] * Item2.blue;
                        }
                    }
                    Filtered[i, j].red = (byte)Sum.red;
                    Filtered[i, j].green = (byte)Sum.green;
                    Filtered[i, j].blue = (byte)Sum.blue;
                }

            return Filtered;
        }

        /// <summary>
        /// Global Variables
        /// </summary>
        public static List<RGBPixel> V;
        public static int D;
        public static new List<KeyValuePair<KeyValuePair<int, int>, double>> E;
        public static int height;
        public static int width;
        public static bool[] is_distinct;
        public static int[] distinct_map;
        public static double calc_cost(RGBPixel c1, RGBPixel c2)
        {
            return Math.Sqrt(((c1.red - c2.red) * (c1.red - c2.red)) + ((c1.green - c2.green) * (c1.green - c2.green)) + ((c1.blue - c2.blue) * (c1.blue - c2.blue)));
        }

        /// <summary>
        /// MSE
        /// </summary>
        /// <param name="ImageMatrix"></param>
        /// <returns></returns>
        public static KeyValuePair<int, double> MSE(RGBPixel[,] ImageMatrix)
        {
            //1 - calculate distinct colors
            height = GetHeight(ImageMatrix);
            width = GetWidth(ImageMatrix);
            V = new List<RGBPixel>();
            distinct_map = new int[256256256];

            // O(N^2)
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int distinct_color_index = ImageMatrix[i, j].red + ImageMatrix[i, j].green * 1000 + ImageMatrix[i, j].blue * 1000000;
                    if (distinct_map[distinct_color_index] == 0)
                    {
                        distinct_map[distinct_color_index] = V.Count + 1;
                        V.Add(ImageMatrix[i, j]);
                    }
                }
            }

            //2 - calculate MST ( Prim Algorithm )
            D = V.Count;
            E = new List<KeyValuePair<KeyValuePair<int, int>, double>>();

            var lowest_cost = new double[D];
            var lowest_cost_parent = new int[D];
            for (int i = 0; i < D; i++) lowest_cost[i] = double.MaxValue;

            var is_visited = new bool[D];

            double MST_Sum = 0;
            int current_parent = 0;
            is_visited[0] = true;

            // O(D^2)
            for (int e = 0; e < D - 1; e++)
            {
                double minimum_cost = double.MaxValue;
                int minimum_v = 0;
                int current_lowest_cost_parent = 0;
                for (int v = 1; v < D; v++)
                {
                    if (!is_visited[v])
                    {
                        double new_cost = Math.Sqrt(((V[current_parent].red - V[v].red) * (V[current_parent].red - V[v].red)) + ((V[current_parent].green - V[v].green) * (V[current_parent].green - V[v].green)) + ((V[current_parent].blue - V[v].blue) * (V[current_parent].blue - V[v].blue)));

                        // update lowest cost and parent
                        if (lowest_cost[v] > new_cost)
                        {
                            lowest_cost[v] = new_cost;
                            lowest_cost_parent[v] = current_parent;
                        }

                        // calc gloable lowest cost, parent and child
                        if (lowest_cost[v] < minimum_cost)
                        {
                            minimum_cost = lowest_cost[v];
                            minimum_v = v;
                            current_lowest_cost_parent = lowest_cost_parent[v];
                        }
                    }
                }
                E.Add(new KeyValuePair<KeyValuePair<int, int>, double>(new KeyValuePair<int, int>(current_lowest_cost_parent, minimum_v), minimum_cost));
                MST_Sum += minimum_cost;
                current_parent = minimum_v;
                is_visited[minimum_v] = true;
            }
            return new KeyValuePair<int, double>(E.Count + 1, MST_Sum);
        }


        /// <summary>
        /// Clusterring
        /// </summary>
        /// <param name="ImageMatrix"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static RGBPixel[,] Clusterring(RGBPixel[,] ImageMatrix, int K)
        {
            //Make adj matrix
            E.Sort((x, y) => (x.Value.CompareTo(y.Value)));
            var adj = new List<int>[D];
            for (int i = 0; i < D; i++) { adj[i] = new List<int>(); }
            for (int i = 0; i < D - K; i++)
            {
                int c1 = E[i].Key.Key;
                int c2 = E[i].Key.Value;
                adj[c1].Add(c2);
                adj[c2].Add(c1);
            }

            //Calc Clusters
            int class_number = 0;
            var Clusters_Map = new int[D];
            var Clusters_Colors = new List<RGBPixel>();
            var is_Visited = new bool[D];

            // O(K*(D+E)) ---> O(K*D) 
            for (int v = 0; v < D; v++)
            {
                if (!is_Visited[v]) // K
                {
                    int current_v_temp = v;
                    int R = 0, G = 0, B = 0, N = 0;
                    Queue<int> neighbors = new Queue<int>();
                    neighbors.Enqueue(v);

                    //BFS Algo --> D+E
                    while (neighbors.Count != 0)
                    {
                        v = neighbors.Dequeue();
                        is_Visited[v] = true;
                        R += V[v].red;
                        G += V[v].green;
                        B += V[v].blue;
                        N++;
                        Clusters_Map[v] = class_number;

                        for (int e = 0; e < adj[v].Count; e++)
                        {
                            if (!is_Visited[adj[v][e]]) neighbors.Enqueue(adj[v][e]);
                        }
                    }

                    RGBPixel new_color = new RGBPixel();
                    new_color.red = (byte)(R / N);
                    new_color.green = (byte)(G / N);
                    new_color.blue = (byte)(B / N);
                    Clusters_Colors.Add(new_color);
                    class_number++;
                    v = current_v_temp;
                }
            }

            //Display   O(N^2)
            int index = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int distinct_color_index = ImageMatrix[i, j].red + ImageMatrix[i, j].green * 1000 + ImageMatrix[i, j].blue * 1000000;
                    if (distinct_map[distinct_color_index] != 0) index = Clusters_Map[distinct_map[distinct_color_index] - 1];
                    ImageMatrix[i, j] = Clusters_Colors[index];
                }
            }
            return ImageMatrix;
        }
    }
}
