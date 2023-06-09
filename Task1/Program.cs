using System;
using System.Text;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: Implement the task here.
            string inputText = "";

            Console.WriteLine($"Text first letter checker \n " +
                              $"Enter 0 when you want to stop entering texts: ");
            while (inputText != "0")
            {
                try
                {
                    Console.Write("Enter text: ");
                    inputText = Console.ReadLine();

                    if (inputText == "0") break;

                    Console.WriteLine("The first char is : " + inputText[0]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}