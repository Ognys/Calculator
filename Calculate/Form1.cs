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


        private void Sum_Click(object sender, EventArgs e) => Result.Text = CalCul.Sum(options.ParseText(options.textBoxes)).ToString();

        private void Sub_Click(object sender, EventArgs e) => Result.Text = CalCul.Sub(options.ParseText(options.textBoxes)).ToString();

        private void Mul_Click(object sender, EventArgs e) => Result.Text = CalCul.Mul(options.ParseText(options.textBoxes)).ToString();

        private void Div_Click(object sender, EventArgs e) => Result.Text = CalCul.Div(options.ParseText(options.textBoxes)).ToString();

        private void Cos_Click(object sender, EventArgs e) => Result.Text = CalCul.Cos(options.CheckFieldI(options.textBoxes)).ToString();

        private void Sin_Click(object sender, EventArgs e) => Result.Text = CalCul.Sin(options.CheckFieldI(options.textBoxes)).ToString();

        private void AddField_Click(object sender, EventArgs e)
        {
            if(options.textBoxes.Length == 5) AddField.Enabled = false;
            options.AddFiled();
        }
    }
}
