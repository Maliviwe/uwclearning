# uwclearning
using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
         {
               
                   for (int counter = 99; counter >= 0; counter--)
                {
                    Console.WriteLine("{0} bottles of beer on the wall, {1} bottles of beer.", counter, counter);
                    Console.WriteLine("Take one down and pass it around, {0} bottles of beer on the wall.", (counter - 1));
                }

                Console.ReadLine();
            }

            
            
        }
    }
}

        
    

