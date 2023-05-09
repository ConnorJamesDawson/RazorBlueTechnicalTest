using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TechnicalExam
{
    public class Task4FizzBuzz
    {

        public void FizzBuzzRecursion(int number)
        {
            if (number <= 0) return;

            if(number % 5 == 0 && number % 3 == 0)
            {
                Console.Write(", FizzBuzz");
            }
            else
            {
                if(number % 5 == 0)
                {
                    Console.Write(", Buzz");
                }
                else
                {
                    if (number % 3 == 0)
                    {
                        Console.Write(", Fizz");
                    }
                    else
                        Console.Write($", {number}");
                }
            }

            FizzBuzzRecursion(number - 1);
        }

        public void FizzBuzz()
        {
            int counter = 1;
            do
            {
                if (counter % 5 == 0 && counter % 3 == 0)
                {
                    Console.Write(", FizzBuzz");
                }
                else
                {
                    if (counter % 5 == 0)
                    {
                        Console.Write(", Buzz");
                    }
                    else
                    {
                        if (counter % 3 == 0)
                        {
                            Console.Write(", Fizz");
                        }
                        else
                            Console.Write($" {counter}");
                    }
                }
                counter++;
            }
            while(counter <= 100);


        }
    }
}
