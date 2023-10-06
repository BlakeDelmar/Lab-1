using System.Security.Cryptography;
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Number_Analyzer___Decision_Maker___Blake
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // (Total) Prompt user to enter WHOLE NUMBER between 1 and 100 inclusive, Display result on range entered V
            // Ask user to enter Whole Number 1 - 100 INCLUSIVE 
            //  
            //
            //
            //
            //
            //
            //                      if odd and less than 60 - print - Odd and less than 60. 
            //    if even and in range of 2 to 24 INCLUSIVE - print - Even and less than 25 COMPLETE
            //   if even and in range of 26 to 60 INCLUSIVE - print - Even and between 26 and 60 inclusive COMPLETE??
            //                  if even and greater than 60 - print - Even and greater than 60
            //                   if odd and greater than 60 - print - Odd and greater than 60 

            Console.WriteLine("Hello, please enter you name :)");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} Im going to evaluate your numbers today :D");
            Console.WriteLine($"So.. {name}, im going to need a number bewteen 1 - 100 inclusive please!");

            string inputNumber = Console.ReadLine();






            while (inputNumber != null)
            {
                if (int.TryParse(inputNumber, out int value) && value > 1 && value < 100)
                {
                    Console.WriteLine($" {inputNumber} Is valid in this context.. thank you {name}!");

                    if (value <= 24 && value % 2 == 0)
                    {
                        Console.WriteLine($"{inputNumber} is Even and less than 25");
                    }
                    else if (value >= 26 && value <= 60 && value % 2 == 0)
                    {
                        Console.WriteLine($"{inputNumber} is Even and between 26 and 60 inclusive");
                    }
                    else if (value >= 60 && value % 2 == 0)
                    {
                        Console.WriteLine($"{inputNumber} is Even and greater than 60");
                    }
                    else if (value < 60)
                    {
                        Console.WriteLine($"{inputNumber} is Odd and less than 60");
                    }
                    else if (value > 60)
                    {
                        Console.WriteLine($"{inputNumber} is Odd and greater than 60");
                    }

                    else
                    {
                        Console.WriteLine($"{inputNumber} is VERY not valid {name}.. thanks for trying.");


                        Console.WriteLine($"{name} would you like to continue? Y/N?");
                    }


                    Console.WriteLine($"{name} would you like to continue? 1=Yes/2=No?");

                }
                Console.WriteLine($"{name} would you like to continue? 1=Yes/2=No?");


                string yesOrNoInput = Console.ReadLine();
                int yesOrNoAwnser = int.Parse(yesOrNoInput);


                if (yesOrNoAwnser == 2) ;

                {
                    Console.WriteLine($" Okay fine {name}");

                }
                if (yesOrNoAwnser == 1) ;
                {
                    Console.WriteLine($" Here we go again {name}!!!!");
                    continue;
                }

            }
        }
    }
}