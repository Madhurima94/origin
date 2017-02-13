using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
       
        /*
         * Int16 maximum value is 32676, less than 4 * 10^9
         */
        static void Main(string[] args)
        {


            MatrixRotation();
            
        }

        private static void MatrixRotation()
        {
            long N = long.Parse(Console.ReadLine());

            long[,] Mat = new long[N,N];
            for (long i = 0; i < N; i++) {
                for (long j = 0; j < N; j++) {
                    Mat[i, j] = long.Parse(Console.ReadLine());
                }
            }
            for (long x = 0; x < N / 2; x++)
            {
                // Consider elements in group of 4 in 
                // current square
                for (long y = x; y < N - x - 1; y++)
                {
                    // store current cell in temp variable
                    long temp = Mat[x, y];

                    // move values from right to top
                    Mat[x,y] = Mat[y,N - 1 - x];

                    // move values from bottom to right
                    Mat[y,N - 1 - x] = Mat[N - 1 - x, N - 1 - y];

                    // move values from left to bottom
                    Mat[N - 1 - x, N - 1 - y] = Mat[N - 1 - y, x];

                    // assign temp to left
                    Mat[N - 1 - y, x] = temp;
                    int rowLength = Mat.GetLength(0);
                    int colLength = Mat.GetLength(1);

                    for (int i = 0; i < rowLength; i++)
                    {
                        for (int j = 0; j < colLength; j++)
                        {
                            Console.Write(string.Format("{0} ", Mat[i, j]));
                        }
                        Console.Write(Environment.NewLine + Environment.NewLine);
                    }
                    Console.ReadLine();
                }
            }
        }
      
    }
}
      