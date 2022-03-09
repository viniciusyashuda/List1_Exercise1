using System;

namespace List1_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double higher =0, lower = 0,j;

           Console.WriteLine("Enter 15 numbers:");

           for(int i = 0; i < 15; i++)
            {

                Console.Write($"{i+1}º: ");
                j = double.Parse(Console.ReadLine());

                if (i == 0)
                {

                    lower = higher = j;

                }
                else if(j > higher)
                {

                    higher = j;

                }
                else if (j < lower)
                {

                    lower = j;

                }
            }

            Console.WriteLine("{0} has the higher value, while {1} has the lower", higher,lower);

            Console.ReadKey();

        }
    }
}
