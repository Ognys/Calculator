using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal static class CalCul
    {
        public static double Sum(double[] numbers)
        {
            double sum = 0;
            foreach(var i in numbers) sum += i;
            return sum;     
        }

        public static double Sub(double NumOne, double NumTwo) => NumOne - NumTwo;

        public static double Mul(double NumOne, double NumTwo) => NumOne * NumTwo;

        public static double Div(double NumOne, double NumTwo) => NumOne / NumTwo;

        public static double Cos(double NumOne = 0, double NumTwo = 0)
        {
            if(NumOne != 0) return Math.Cos(NumOne);
            return Math.Cos(NumTwo);
        }

        public static double Sin(double NumOne = 0, double NumTwo = 0)
        {
            if (NumOne != 0) return Math.Sin(NumOne);
            return Math.Sin(NumTwo);
        }
    }
}
