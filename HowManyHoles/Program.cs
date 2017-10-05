using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyHoles
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJECTIVE
            //Find the holes in the numbers
            // 0 4 6 8 9

            Console.WriteLine("How many holes are in your number?");
            Console.WriteLine("Type out any number to find the holes");
            string number = Console.ReadLine();

            //string number = "23456";


            int holes = 0;

            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case '0':
                        holes++;
                        break;

                    case '4':
                        holes++;
                        break;

                    case '6':
                        holes++;
                        break;

                    case '8':
                        holes += 2;
                        break;

                    case '9':
                        holes++;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(holes);

        }
    }
}
