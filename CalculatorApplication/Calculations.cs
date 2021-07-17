using System;
using System.Collections.Generic;
namespace CalculatorApplication
{

    //Class to perform all calculations.
    public class Calculations

    {
        public double calcNum1 { get; set; }

        public double calcNum2 { get; set; }

        public string calcOp { get; set; }

        public double calcResult { get; set; }

        public static List<Calculations> calchistory = new List<Calculations>();


        public override string ToString()
        {
            return $"{calcNum1} {calcOp} {calcNum2} = {calcResult}";
        }


        static double result = 0;

        public static double Addition(double val1, double val2)
        {
            result = val1 + val2;
            //Adding calculation to the list
            calchistory.Add(new Calculations() { calcNum1 = val1, calcNum2 = val2, calcOp = "+", calcResult = result });
            return result;

        }

        public static double Subtraction(double val1, double val2)
        {
            result = val1 - val2;
            //Adding calculation to the list
            calchistory.Add(new Calculations() { calcNum1 = val1, calcNum2 = val2, calcOp = "-", calcResult = result });
            return result;


        }

        public static double Multiplication(double val1, double val2)
        {
            result = val1 * val2;
            //Adding calculation to the list
            calchistory.Add(new Calculations() { calcNum1 = val1, calcNum2 = val2, calcOp = "*", calcResult = result });
            return result;


        }

        public static double Division(double val1, double val2)
        {
            result = val1 / val2;
            //Adding calculation to the list
            calchistory.Add(new Calculations() { calcNum1 = val1, calcNum2 = val2, calcOp = "/", calcResult = result });
            return result;


        }

        public static double Power(double val1, double val2)
        {
            result = Math.Pow(val1, val2);
            //Adding calculation to the list
            calchistory.Add(new Calculations() { calcNum1 = val1, calcNum2 = val2, calcOp = "**", calcResult = result });
            return result;


        }

        //method to return history
        public static void ShowHistory()
        {
            foreach (Calculations savedCalc in calchistory)
            {
                System.Console.WriteLine(savedCalc);
            }
        }
    }
}