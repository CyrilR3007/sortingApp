// See https://aka.ms/new-console-template for more information
using System;

namespace sortingApp
{
    static class Program
    {

        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            Console.WriteLine("Enter letters : ");
            string input;
            while ((input = Console.ReadLine()) != string.Empty)
            {
                list.Add(input.ToUpper());

            }

            Console.WriteLine("Enter a length : ");
            int length = Convert.ToInt32(Console.ReadLine());

            int numberOfValue = (int)Math.Pow(list.Count, length);
            int x;


            for (int i = 0; i < numberOfValue; i++)
            {
                string text = "";

                for (int j = length - 1; j >= 0; j--)
                {
                    x = i / (int)Math.Pow(list.Count, j) % list.Count;
                    text += list[x];
                }
                Console.Write($"{text} | ");

            }
            Console.Write($"{numberOfValue} ");

        }


    }

}
