using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
          Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 10000)
            {
                Console.WriteLine("Error: Number must be less than 10 000");
            }

            string [] array = new string[] {
                "zero", "one", "two","three", "four", "five", "six", "seven", "eight", "nine", "ten",
                  "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" +
                    "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            if (number >= 1000)
            {
                int leftmost_digit = (number / 1000);
                
                Console.WriteLine(array [leftmost_digit] + " thousand ");
                
                number -= leftmost_digit * 1000; 
            }

            if (number >= 100)
            {
                int leftmost_dig = (number / 100);

                Console.WriteLine(array[leftmost_dig] + " hundred ");
                
                number -= leftmost_dig * 100;
            }

            if (number > 20)
            {
                int leftmost_dig = number / 10;

                Console.Write(array[(17+leftmost_dig)]);
                
                number -= leftmost_dig * 10;
            }

            Console.WriteLine(array[number]);
           
        }
    }
}





