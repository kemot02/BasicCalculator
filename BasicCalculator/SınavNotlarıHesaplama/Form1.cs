namespace SınavNotlarıHesaplama
{
    public partial class Form1 : Form
    {
        double number1 = 0;
        double number2 = 0;
        double result = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
       
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            tbxNumber1.Text = "";
            tbxNumber2.Text = "";
            tbxResult.Text = "";
        }

        private void radioAddition_CheckedChanged(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void radioSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void radioMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void radioDivision_CheckedChanged(object sender, EventArgs e)
        {
            operation = "/";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool number10k = double.TryParse(tbxNumber1.Text, out number1);
            bool number20k = double.TryParse(tbxNumber2.Text, out number2);
            if(number10k && number20k)
            {
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        tbxResult.Text = result.ToString();
                        break;
                    case "-":
                        result = number1 - number2;
                        tbxResult.Text = result.ToString();
                        break;
                    case "*":
                        result = number1 * number2;
                        tbxResult.Text = result.ToString();
                        break;
                    case "/":
                        result = number1 / number2;
                        tbxResult.Text = result.ToString();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Data is not valid", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}