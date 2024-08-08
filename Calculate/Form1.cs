using static System.Windows.Forms.Design.AxImporter;

namespace Calculate
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();



        }




        private void NumThree_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "3";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumOne_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "1";
        }

        private void NumTwo_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "2";
        }

        private void NumFour_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "4";
        }

        private void NumFive_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "5";
        }

        private void NumSix_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "6";
        }

        private void NumSeven_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "7";
        }

        private void NumEight_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "8";
        }

        private void NumNine_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "9";
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            InputPanel.Text = "0";
        }

        private void NumZero_Click(object sender, EventArgs e)
        {
            Options.ClearFirstNull(InputPanel);
            InputPanel.Text += "0";
        }

        private void SetPlusMinus_Click(object sender, EventArgs e) => InputPanel.Text = ((-Double.Parse(InputPanel.Text)).ToString());
        
            
        
    }
}
