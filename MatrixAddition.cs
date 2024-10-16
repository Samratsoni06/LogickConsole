using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class MatrixAddition
    {
        public void AddMatrix() 
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50]; 
            int[,] brr1 = new int[50, 50]; 
            int[,] crr1 = new int[50, 50];

            Console.Write("\n\nAddition of two Matrices :\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Input elements into the first matrix */
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine()); // Store user input in the first matrix
                }
            }

            /* Input elements into the second matrix */
            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine()); // Store user input in the second matrix
                }
            }

            // Display the first matrix
            Console.Write("\nThe First matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]); // Print elements of the first matrix
            }

            // Display the second matrix
            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", brr1[i, j]); // Print elements of the second matrix
            }

            /* Calculate the sum of the matrices */
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    crr1[i, j] = arr1[i, j] + brr1[i, j]; // Perform addition of elements and store in the resultant matrix
            }

            // Display the resultant matrix after addition
            Console.Write("\nThe Addition of two matrices is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", crr1[i, j]); // Print elements of the resultant matrix
            }
            Console.Write("\n\n");
        }
    }
}
