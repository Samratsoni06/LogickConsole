using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class MultiplicationMatrix
    {
        public void MatrixMul()
        {
            int i, j, k, r1, c1, r2, c2, sum = 0;

            int[,] arr1 = new int[50, 50]; // Declare the first matrix
            int[,] brr1 = new int[50, 50]; // Declare the second matrix
            int[,] crr1 = new int[50, 50]; // Declare the resultant matrix for multiplication

            // Display a message prompting the user to input the dimensions of the first matrix
            Console.Write("\n\nMultiplication of two Matrices\n");
            Console.Write("----------------------------------\n");
            Console.Write("\nInput the number of rows and columns of the first matrix :\n");
            Console.Write("Rows : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            // Display a message prompting the user to input the dimensions of the second matrix
            Console.Write("\nInput the number of rows and columns of the second matrix :\n");
            Console.Write("Rows : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            // Check if multiplication of matrices is possible
            if (c1 != r2)
            {
                Console.Write("Multiplication of matrices is not possible.");
                Console.Write("\nColumn of the first matrix and row of the second matrix must be the same.");
            }
            else
            {
                // Input elements into the first matrix
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Input elements into the second matrix
                Console.Write("Input elements in the second matrix :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Display the first matrix
                Console.Write("\nThe First matrix is :\n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }

                // Display the second matrix
                Console.Write("\nThe Second matrix is :\n");
                for (i = 0; i < r2; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}\t", brr1[i, j]);
                }

                // Matrix multiplication algorithm
                for (i = 0; i < r1; i++) // Row of the first matrix
                {
                    for (j = 0; j < c2; j++) // Column of the second matrix
                    {
                        sum = 0;
                        for (k = 0; k < c1; k++)
                            sum = sum + arr1[i, k] * brr1[k, j];
                        crr1[i, j] = sum;
                    }
                }

                // Display the resultant matrix after multiplication
                Console.Write("\nThe multiplication of two matrices is : \n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("{0}\t", crr1[i, j]);
                    }
                }
            }
            Console.Write("\n\n");
        }
    }
}
