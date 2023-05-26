using System;
using System.Text;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: Implement the task here.
            string inputText="";
            bool stop = false;
            
            Console.WriteLine($"Text first letter checker \n " +
                              $"Enter 0 when you want to stop entering texts: ");
            do
            {
                Console.Write("Enter text: ");
                if (inputText!="0")
                {
                    try
                    {
                        inputText = Console.ReadLine();
                        Console.WriteLine("The first char is : " + inputText[0]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    stop= true;
                }
            } while (!stop);


        }
    }
}