using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class Options
    {
        public Options(Form form, TextBox BoxOne, TextBox BoxTwo)
        {
            this.form = form;
            textBoxes = new TextBox[] { BoxOne, BoxTwo};
        }

        public TextBox[] textBoxes;
        Form form;

        public void AddFiled()
        {
            TextBox[] copyTextBoxes = new TextBox[textBoxes.Length + 1];

            for (int i = 0; i < copyTextBoxes.Length - 1;i++) copyTextBoxes[i] = textBoxes[i];

            copyTextBoxes[copyTextBoxes.Length - 1] = new TextBox();
            
            textBoxes = copyTextBoxes;

            LocationBox(textBoxes[textBoxes.Length - 1], textBoxes.Length);

        }

        private void LocationBox(TextBox textBox,int numBox)
        {
            

            switch (numBox)
            {
                case 3:
                    textBox.Location = new Point(123, 45);
                    break;
                case 4:
                    textBox.Location = new Point(13, 97);
                    break;
                case 5:
                    textBox.Location = new Point(123, 97);
                    break;
                case 6:
                    textBox.Location = new Point(229, 97);
                    break;
            }

            form.Controls.Add(textBox);
        }

        public double[] ParseText(TextBox[] texts)
        {
            double[] reslt = new double[texts.Length];

            for (int i = 0; i < reslt.Length; i++) reslt[i] = Double.Parse(texts[i].Text);

            return reslt;
        }

        public double CheckFieldI(TextBox[] texts)
        {

            bool f = true;
            double res = 0;
            for(int i = 0;i < texts.Length;i++)
            {
                if (!Double.TryParse(texts[i].Text, out double buf)) texts[i].Text = "0";
                else
                {
                    if (f && buf != 0)
                    {
                        res = buf;
                        f = false;
                    }
                    
                }
            }
            return res;
        }
    }
}
