using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //OverloadMethod objProgram = new OverloadMethod();
            //Console.WriteLine("Add with two int parameter :" + objProgram.Add(3, 2));
            //Console.WriteLine("Add with three int parameter :" + objProgram.Add(3, 2, 8));
            //Console.WriteLine("Add with two float parameter :" + objProgram.Add(3.7f, 2.2f));
            //Console.WriteLine("Add with two string parameter :" + objProgram.Add("hello", "world"));

            //Childcls childcls  = new Childcls();
            //childcls.Display(3,4);

            //

            BinarySearch binarySearch = new BinarySearch();
            MultiplyDegit multiplyDegit = new MultiplyDegit();
            sequence sq = new sequence();
            FindnthNum findnth = new FindnthNum();
            SwapVal sval = new SwapVal();
            CharacterCount count = new CharacterCount();
            AddMatrix matrix = new AddMatrix();
            PasswordValidation password = new PasswordValidation();
            MultiplicationMatrix multiplicationMatrix = new MultiplicationMatrix();
            MatrixAddition matrixAddition = new MatrixAddition();

            //findnth.Mains();
            //multiplyDegit.DegitMultiply();
            //sq.SequenceMain();
            //sval.SwapMain();
            //count.CharMain();
            //matrix.MatrixMain();
            //password.PasswordMain();
            //binarySearch.BinarySearchMetMain();
            //multiplicationMatrix.MatrixMul();
            //matrixAddition.AddMatrix();

            Console.ReadLine();
        }
    }
}
