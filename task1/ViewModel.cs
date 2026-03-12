using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class ViewModel
    {


        internal static int[] fromDec(double v)
        {
            Number number = Number.FromDouble(v);
            number.Normalize();
            int[] arr = [number.GetNumerator(), number.GetDenominator()];
            return arr;
        }

        

        internal static int[] Normalize(int v1, int v2)
        {
            Number number = new(v1, v2);
            number.Normalize();
            int[] arr = [number.GetNumerator(), number.GetDenominator()];
            return arr;
        }

        

        internal static double toDec(int v1, int v2)
        {
            Number number = new(v1, v2);
            number.Normalize();
            double num = number.ToDec();
            return num;
        }

        internal static int[] DoMath(int numerator1, int denominator1, int numerator2, int denominator2, string operation)
        {
            Number numberLeft = new(numerator1, denominator1);
            Number numberRight = new(numerator2, denominator2);
            Number? number;

            switch (operation)
            {
                case "+":
                    number = numberLeft + numberRight;
                    break;
                case "-":
                    number = numberLeft - numberRight;
                    break;
                case "*":
                    number = numberLeft * numberRight;
                    break;
                case "/":
                    number = numberLeft / numberRight;
                    break;
                default:
                    throw new ArgumentException($"Неизвестная операция: {operation}", nameof(operation));
            }
            int[] arr = [number.GetNumerator(), number.GetDenominator()];
            return arr;
        }
    }
}
