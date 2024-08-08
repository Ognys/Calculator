using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal static class Options
    {
        //static char s;
        public static void ClearFirstNull(Label label)
        {
            if (label.Text[0] == '0') label.Text = String.Empty;
        }

        public static void CheckInput(Label label)
        {
            if(CalCul.CheckInput) label.Text = "0";
            CalCul.CheckInput = false;
        }

        public static void CheckOperat(Label label, char s)
        {
            switch (s)
            {
                case '+':
                    label.Text = (CalCul.NumOne + Double.Parse(label.Text)).ToString();
                    break;
            }
        }
    }
}
