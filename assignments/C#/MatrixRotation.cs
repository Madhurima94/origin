using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MatrixRotation1();
        }

        private static void MatrixRotation1()
        {
            Console.WriteLine("Enter the number of rows,columns and rotations");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
           
            int r = Convert.ToInt32(arr[0]);
           
            int c = Convert.ToInt32(arr[1]);
           
            int rotation = Convert.ToInt32(arr[2]);

            int[,] mat = new int[r, c];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < r; i++)
            {


                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                   
                }
            }

            RotateAntiClockwise(mat, rotation);

            for (int i = 0; i < r; i++)
            {
                string s = "";
                for (int j = 0; j < c; j++)
                    s += mat[i, j] + " ";
                Console.WriteLine(s.Trim());
            }
            Console.ReadLine();
        }

      

        public static bool RotateAntiClockwise(int[,] mat, int steps)
        {
            if (mat == null) return false;

            int r1 = mat.GetLength(0);  // row
            int c1 = mat.GetLength(1);  // column 

            int row = 0;
            int col = 0;

            while (r1 > 1 && c1 > 1)
            {
                int circularLength = 2 * r1 + 2 * c1 - 4;
                int Steps = steps % circularLength;

                for (int step = 0; step < Steps; step++) //  move one step anti-clockwise a time
                {
                    int left_corner = mat[row, col]; // left-top corner element

                    for (int columnIndex = col; columnIndex < col + c1 - 1; columnIndex++)
                        mat[row, columnIndex] = mat[row, columnIndex + 1];

                    int lastColumn = col + c1 - 1;
                    for (int rowIndex = row; rowIndex < row + r1 - 1; rowIndex++)
                        mat[rowIndex, lastColumn] = mat[rowIndex + 1, lastColumn];


                    int lastRow = row + r1 - 1;
                    for (int colIndex = col + c1 - 1; colIndex >= col + 1; colIndex--)
                        mat[lastRow, colIndex] = mat[lastRow, colIndex - 1];

                    for (int rowIndex = row + r1 - 1; rowIndex >= 1 + row; rowIndex--)
                        mat[rowIndex, col] = mat[rowIndex - 1, col];

                    mat[row + 1, col] = left_corner;
                }

                row++;
                col++;

                r1 -= 2;
                c1 -= 2;
            }

            return true;
        }
        
    }
    
}