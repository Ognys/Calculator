using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal static class CalCul
    {
        public static double NumOne = 0;
        public static double NumTwo = 0;

        public static bool CheckInput = false;

        public static void Sum(Label label)
        {
            if(!CheckInput)
            {
                NumOne = Double.Parse(label.Text);
                CheckInput = true;
                return;
            }



        }
    }
}
