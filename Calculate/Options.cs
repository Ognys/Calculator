using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal static class Options
    {
        public static void ClearFirstNull(Label label)
        {
            if (label.Text[0] == '0') label.Text = String.Empty;
        }
    }
}
