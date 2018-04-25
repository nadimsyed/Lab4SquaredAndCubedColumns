using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static int Squared(int integer)
        {
            int Squared = integer * integer;
            return Squared;
        }

        static int Cubed(int integer)
        {
            int Cubed = Squared(integer) * integer;
            return Cubed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");

            do
            {
                Console.Write("Enter an integer: ");
                string integer = Console.ReadLine();

                bool worked = int.TryParse(integer, out int integer2);

                if (worked)
                {
                    Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
                    Console.WriteLine("======\t\t\t=======\t\t\t=====");
                    //string s = string.Format("{0,-10} {1, -10:N0}\n", Squared, Cubed);
                    for (int i = 1; i <= integer2; i++)
                    {
                        //s += string.Format("{0,-10} {1, -10:N0}\n", Squared(i), Cubed(i));
                        Console.WriteLine(i + "\t\t\t" + Squared(i) + "\t\t\t" + Cubed(i));
                        //Console.WriteLine(s);
                    }

                    Console.Write("Continue? (y/n): ");
                    var yep = Console.ReadLine();
                    bool quitter = char.TryParse(yep, out char quitter2);
                    if(quitter2 == 'N' || quitter2 == 'n')
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter and integer! =( ");
                }


            } while (true);
            

        }
    }
}
