// See https://aka.ms/new-console-template for more information
using GenericMethod;
Console.WriteLine("Generic Method Program");
int[] intArray = { 2, 4, 5, 6, 8, 7 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
double[] doubleArray = { 1.1, 3.3, 2.2, 4.4 };
Class1.Display<int>(intArray);
Class1.Display<char>(charArray);
Class1.Display<double>(doubleArray);
Console.ReadKey();

