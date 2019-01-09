using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabeticalSorter
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            char[] array;
            char ch;
            int length;
            Console.Write("\n\nLet's sort a string array in alphabetical order! ");
            Console.WriteLine(" ");
            Console.Write("Please input a string of letters ");

            userInput = Console.ReadLine();
            length = userInput.Length;
            array = userInput.ToCharArray(0, length);

            for (int i = 1; i < length; i++)
            for (int j = 0; j < length - i; j++)

                if (array[j] > array[j + 1])
                {
                    ch = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = ch;
                }
            Console.Write("\n \n");
            Console.WriteLine("Your string in alphabetical order is:");
            Console.Write("\n \n");

            foreach (char c in array)
            {
                ch = c;
                Console.Write("{0}", ch);
            }

            Console.Write("\n \n");
        }
    }
}
