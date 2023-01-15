/*
 * Program ID: NormalCalculator
 * 
 * Purpose: Do a functional calculator
 * 
 * Revision History:
 * Created by Bryan Ayala  Oct 29, 2022
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3JRBAP2
{
    class Program
    {
        public static double EnterNumber()
        {   
            double number = 0;
            string userInput;
            bool valid = true;

            Console.WriteLine("Please Enter a Numeric digit:");
            userInput = Console.ReadLine();


            while (valid)
            {
                try
                {
                    number = Convert.ToDouble(userInput);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine();
                    Console.WriteLine("ERROR. You have introduced text. Please Enter your number again: ");
                    userInput = Console.ReadLine();
                }
                if (number >= 0 || number < 0)
                {
                    valid = false;
                }

            }
            return number;
        }

        public static void Option1()
        {
            double number1 = 0;
            double number2 = 0;
            double number3 = 0;
            double number4 = 0;
            double sum = 0;

            Console.WriteLine("Enter FOUR numbers:");
            Console.WriteLine();

            number1 = EnterNumber();
            number2 = EnterNumber();
            number3 = EnterNumber();
            number4 = EnterNumber();

            sum = number1 + number2 + number3 + number4;
            Console.WriteLine("The result is: " + sum);
            Console.WriteLine();
        }

        public static void Option2()
        {
            double number1 = 0;
            double number2 = 0;
            double number3 = 0;
            double number4 = 0;
            double subtract = 0;

            Console.WriteLine("Enter FOUR numbers:");
            Console.WriteLine();

            number1 = EnterNumber();
            number2 = EnterNumber();
            number3 = EnterNumber();
            number4 = EnterNumber();

            subtract = number1 - number2 - number3 - number4;
            Console.WriteLine("The result is: " + subtract);
            Console.WriteLine();
        }

        public static void Option3()
        {
            double number1 = 0;
            double number2 = 0;
            double number3 = 0;
            double number4 = 0;
            double multiply = 0;

            Console.WriteLine("Enter FOUR numbers:");
            Console.WriteLine();

            number1 = EnterNumber();
            number2 = EnterNumber();
            number3 = EnterNumber();
            number4 = EnterNumber();

            multiply = number1 * number2 * number3 * number4;
            Console.WriteLine("The result is: " + multiply);
            Console.WriteLine();
        }

        public static void Option4()
        {
            double number1 = 0;
            double number2 = 0;
            double divide = 0;
            bool valid = true;

            Console.WriteLine("You only can divide 2 numbers at same time");
            Console.WriteLine();

            number1 = EnterNumber();
            number2 = EnterNumber();

            if (number2 == 0)
            {
                while (valid)
                {
                    
                    try 
                    { 
                        throw new DivideByZeroException();
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR. The second number introduced cannot be Zero. Please Enter the second number again: ");
                        Console.WriteLine();
                        number2 = EnterNumber();
                    }
                    if (number2 != 0) valid = false;
                }
            }
            divide = number1 / number2;
            Console.WriteLine("The result is: " + divide);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Declare variables
            bool keepGoing;
            string userAnswer;
            int answerOption;
            bool valid;
         
            //Initialize variables
            keepGoing = true;
            userAnswer = "";
            answerOption = 0;
            valid = true;
    ;

            do
            {
                Console.WriteLine("This is a Calculator");
                Console.WriteLine("If you want add numbers: Press 1");
                Console.WriteLine("If you want subtract numbers: Press 2");
                Console.WriteLine("If you want multiply numbers: Press 3");
                Console.WriteLine("If you want divide numbers: Press 4");
                Console.WriteLine("If you want exit: Press 0");
                userAnswer = Console.ReadLine();

                while (valid)
                {
                    try
                    {
                        answerOption = int.Parse(userAnswer);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine();
                        Console.WriteLine("ERROR. You have introduced a text or decimal option. Please choose again");
                        Console.WriteLine();
                        Console.WriteLine("If you want add numbers: Press 1");
                        Console.WriteLine("If you want subtract numbers: Press 2");
                        Console.WriteLine("If you want multiply numbers: Press 3");
                        Console.WriteLine("If you want divide numbers: Press 4");
                        Console.WriteLine("If you want exit: Press 0");
                        userAnswer = Console.ReadLine();
                    }
                    if (answerOption >= 0 || answerOption <= 0 && answerOption % 1 == 0)
                    {
                        valid = false;
                    }

                }
                Console.WriteLine();

                if (answerOption == 1)
                {
                    Option1();
                }

                else if (answerOption == 2)
                {
                    Option2();

                }

                else if (answerOption == 3)
                {
                    Option3();
                }

                else if (answerOption == 4)
                {
                    Option4();
                }

                else if (answerOption == 0)
                {
                    keepGoing = false;
                }

                else if (answerOption < 0 || answerOption > 4)
                {
                    try
                    {
                        throw new ArgumentOutOfRangeException();

                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine();
                        Console.WriteLine("ERROR. You have introduced out of range option. Please choose again");
                        Console.WriteLine();
                    }
                }

                answerOption = 0;
                valid = true;

            } while (keepGoing);

            Console.ReadKey();


        }
    }
}
