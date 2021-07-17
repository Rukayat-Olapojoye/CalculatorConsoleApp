using System;
using CalculatorApplication;

namespace CalculatorconsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {


            bool endCalculation = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("**********************************************************");
            Console.WriteLine("*************Calculator Application Console**************");
            Console.WriteLine("***** Please follow the prompt to use the calculator ****");
            Console.WriteLine("**********************************************************");


            string initialNum1 = "";
            string initialNum2 = "";

            double num1 = 0;
            double num2 = 0;
            string calcOperator = "";
            //double result;

            // Keeping the calculator running
            while (!endCalculation)
            {
                // Request user to input numbers and operator
                Console.WriteLine("Enter a number, and then press Enter");
                initialNum1 = Console.ReadLine();

                //Implementing my exception Handler to handle non number inputs
                while (!double.TryParse(initialNum1, out num1))
                {

                    Console.WriteLine("This is not valid input. Please enter an integer value: ");
                    initialNum1 = Console.ReadLine();

                }

                Console.WriteLine("Enter a second number, and then press Enter");
                initialNum2 = Console.ReadLine();


                while (!double.TryParse(initialNum2, out num2))
                {

                    Console.WriteLine("This is not valid input. Please enter an integer value: ");
                    initialNum2 = Console.ReadLine();

                }


                Console.WriteLine("Please enter any of these operators [+ , - , * , /, ** ]: to perform your calculations");
                calcOperator = Console.ReadLine();

                // Conditional statement to perform calculations according to the operator.
                switch (calcOperator)
                {
                    //Addition Operation
                    case "+":
                        Console.WriteLine($"Your calculation: {num1} + {num2} = " + Calculations.Addition(num1, num2));
                        break;

                    //Subtraction Operation
                    case "-":
                        Console.WriteLine($"Your calculation: {num1} - {num2} = " + Calculations.Subtraction(num1, num2));
                        break;

                    //Multiplication Operation
                    case "*":
                        Console.WriteLine($"Your calculation: {num1} * {num2} = " + Calculations.Multiplication(num1, num2));
                        break;

                    //Division Operation
                    case "/":
                        // Adding my exception handler for non zero Division
                        try
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("This operation will result in a mathematical error.\n");
                            }
                            else
                            {
                                Console.WriteLine($"Your calculation: {num1} / {num2} = " + Calculations.Division(num1, num2));
                            }
                        }


                        catch (Exception error)
                        {
                            Console.WriteLine("Ooopss!!!! An exception occurred trying to do this calculation.\n - Details: " + error.Message);
                        }

                        break;

                    //Power Operation
                    case "**":
                        Console.WriteLine($"Your calculation: {num1} ** {num2} = " + Calculations.Power(num1, num2));
                        break;

                    //Handling a wrong operator
                    default:
                        Console.WriteLine("You entered a wrong operator!!!");
                        break;
                }

                // Prompting user to view all calculation history
                Console.WriteLine("Press h to view history of your calculations.");
                if (Console.ReadLine() == "h")
                {
                    Console.WriteLine("***************** Calculations History Starts ***************");
                    Calculations.ShowHistory();
                    Console.WriteLine("***************** Calculations History Ends ***************");

                }
                //Prompting user to end or continue Calculator application.
                Console.WriteLine("Press s key to close the Calculator console app.\nPress any other key to continue.");

                if (Console.ReadLine() == "s") endCalculation = true;






            }
            return;
        }

    }

}
