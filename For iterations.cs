using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) //the i++ adds 1 every iteration and is the same as i = i +1
            {
                //Console.WriteLine(i.ToString());

                    if (i == 7)
                {
                    Console.WriteLine("Found Seven!!");
                    break;
                    //interrupts flow of for statement with
                    //conditional statement and keyword "break"

                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }
            //for and pressing tab twice creates structure template for
            //for statment
            //anywhere "i" was is replaced by my input


            Console.ReadLine();



        }
    }
}
