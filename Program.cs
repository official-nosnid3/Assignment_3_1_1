using System.Text;

namespace Assignment_3_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.1.1
             * Return even numbers
             * Write a method that returns a string of even numbers greater than 0 and less than 100.
             * (Use StringBuilder class)
             * Expected input and output
             * ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"
             * */

            StringBuilder sb = new();
            //string evenNumbers = "";
            
            for (int evenNum = 2; evenNum < 100; evenNum++)
            {
                if (evenNum % 2 == 0)
                {
                    //evenNumbers += evenNum.ToString();
                    //evenNumbers += " ";

                    sb.Append(evenNum + " ");
                }
            }

            //Console.WriteLine(evenNumbers);
            Console.WriteLine(sb.ToString());
        }
    }
}
