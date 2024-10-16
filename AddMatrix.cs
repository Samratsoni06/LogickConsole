using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class AddMatrix
    {
        public void MatrixMain()
        {
            // Define two 4x5 matrices
            int[,] matrix1 = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 }
        };

            int[,] matrix2 = {
            { 5, 4, 3, 2, 1 },
            { 10, 9, 8, 7, 6 },
            { 15, 14, 13, 12, 11 },
            { 20, 19, 18, 17, 16 }
        };

            Console.WriteLine("First Matrix:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Second Matrix:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Create a result matrix to store the sum of matrix1 and matrix2
            int[,] resultMatrix = new int[4, 5];

            // Add the two matrices
            for (int i = 0; i < 4; i++) // Iterate over rows
            {
                for (int j = 0; j < 5; j++) // Iterate over columns
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j]; // Add corresponding elements
                }
            }

            // Display the result matrix
            Console.WriteLine("Resultant Matrix after Addition:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
