using System;

namespace IterationSofiaChumpitazi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 2 and 10: ");

            string number = Console.ReadLine();
            int valueofnumber = int.Parse(number);


            if (valueofnumber % 2 == 0)
            {
                for (int i = 1; i < valueofnumber + 2; i++)
                {
                    Console.Write(i.ToString() + "." + "You entered an even number");
                }
            }
            else
            {
                for (int i = 1; i < valueofnumber + 0; i++)
                {
                    Console.WriteLine(i.ToString() + "." + "You entered an odd number");
                }

            }






        }


    }
}



