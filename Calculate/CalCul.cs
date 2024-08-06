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

        public static double Sub(double[] numbers)
        {
            double sub = numbers[0];
            for(int i = 1; i < numbers.Length;i++) sub -= numbers[i];
            return sub;
        }

        public static double Mul(double[] numbers)
        {
            double mul = 1;
            foreach(var i in numbers) mul *= i;
            return mul;
        }

        public static double Div(double[] numbers)
        {
            double div = numbers[0];
            for (int i = 1; i < numbers.Length; i++) div /= numbers[i];
            return div;
        }

        public static double Cos(double number) => Math.Cos(number);

        public static double Sin(double number) => Math.Sin(number);
    }
}
