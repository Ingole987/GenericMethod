using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMethod;
namespace GenericMethod
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 4, 5, 6, 8, 7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            double[] doubleArray = { 1.1, 3.3, 2.2, 4.4 };
            //DisplayInt(intArray);
            //DisplayChar(charArray);
            //DisplayDouble(doubleArray);
            Display<int>(intArray);
            Display<char>(charArray);
            Display<double>(doubleArray);
            Console.ReadKey();
        }
        public static void Display<T>(T[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

