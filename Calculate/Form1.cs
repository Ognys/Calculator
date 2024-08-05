using static System.Windows.Forms.Design.AxImporter;

namespace Calculate
{
    public partial class Form1 : Form
    {
        Form form;
        Options options;

        public Form1()
        {
            InitializeComponent();

            form = this;
            options = new Options(form, NumOne, NumTwo);

        }


        private void Sum_Click(object sender, EventArgs e)
        {
            double[] sum = new double[options.textBoxes.Length];

            for (int i = 0; i < sum.Length; i++) sum[i] = Double.Parse(options.textBoxes[i].Text);
            
            Result.Text = CalCul.Sum(sum).ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            double res = CalCul.Sub(Double.Parse(NumOne.Text), Double.Parse(NumTwo.Text));

            Result.Text = res.ToString();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            double res = CalCul.Mul(Double.Parse(NumOne.Text), Double.Parse(NumTwo.Text));

            Result.Text = res.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double res = CalCul.Div(Double.Parse(NumOne.Text), Double.Parse(NumTwo.Text));

            Result.Text = res.ToString();
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(NumOne.Text, out double _))
            {
                NumOne.Text = 0.ToString();
            }
            else if (!Double.TryParse(NumTwo.Text, out double _))
            {
                NumTwo.Text = 0.ToString();
            }


            double res = CalCul.Cos(Double.Parse(NumOne.Text), Double.Parse(NumTwo.Text));

            Result.Text = res.ToString();
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(NumOne.Text, out double _))
            {
                NumOne.Text = 0.ToString();
            }
            else if (!Double.TryParse(NumTwo.Text, out double _))
            {
                NumTwo.Text = 0.ToString();
            }

            double res = CalCul.Sin(Double.Parse(NumOne.Text), Double.Parse(NumTwo.Text));

            Result.Text = res.ToString();
        }

        private void AddField_Click(object sender, EventArgs e)
        {
            if(options.textBoxes.Length == 5) AddField.Enabled = false;
            options.AddFiled();
        }
    }
}
