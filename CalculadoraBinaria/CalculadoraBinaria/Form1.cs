using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBinaria
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        bool digit = false;
        int number;
        int operation;

        private void TypeIn(object sender, EventArgs e)
        {
            digit = true;
            
            Button clicked = sender as Button;
            
            if (digit) TextBox.Text += clicked.Text;
            Decimal();
        }

        private void Decimal()
        {
            DecimalBox.Text = Convert.ToString(ConvertTo.ToDecimal(TextBox.Text));
        }

        private void Binary()
        {
            TextBox.Text = Convert.ToString(ConvertTo.ToBinary(DecimalBox.Text));
        }

        private void Sum(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                number = Convert.ToInt32(DecimalBox.Text);
                digit = false;
                TextBox.Text = "";
                DecimalBox.Text = "";
                operation = 0;
            }
            else MessageBox.Show("Please, enter a valid value.");
        }

        private void Subtract(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                number = Convert.ToInt32(DecimalBox.Text);
                digit = false;
                TextBox.Text = "";
                DecimalBox.Text = "";
                operation = 1;
            }
            else MessageBox.Show("Please, enter a valid value.");
        }

        private void Divide(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                number = Convert.ToInt32(DecimalBox.Text);
                digit = false;
                TextBox.Text = "";
                DecimalBox.Text = "";
                operation = 2;
            }
            else MessageBox.Show("Please, enter a valid value.");
        }

        private void Multiply(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                number = Convert.ToInt32(DecimalBox.Text);
                digit = false;
                TextBox.Text = "";
                DecimalBox.Text = "";
                operation = 3;
            }
            else MessageBox.Show("Please, enter a valid value.");
        }
    
        private void Result(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 0: DecimalBox.Text = Convert.ToString(number + Convert.ToInt32(DecimalBox.Text));
                        TextBox.Text = Convert.ToString(ConvertTo.ToBinary(DecimalBox.Text));
                        break;

                case 1: DecimalBox.Text = Convert.ToString(number - Convert.ToInt32(DecimalBox.Text));
                        TextBox.Text = Convert.ToString(ConvertTo.ToBinary(DecimalBox.Text));
                        break;

                case 2: DecimalBox.Text = Convert.ToString(number / Convert.ToInt32(DecimalBox.Text));
                        TextBox.Text = Convert.ToString(ConvertTo.ToBinary(DecimalBox.Text));
                        break;

                case 3: DecimalBox.Text = Convert.ToString(number * Convert.ToInt32(DecimalBox.Text));
                        TextBox.Text = Convert.ToString(ConvertTo.ToBinary(DecimalBox.Text));
                        break;
            }

            //if (digit == true) Clear(null, null);
        }

        private void Clear(object sender, EventArgs e)
        {
            TextBox.Text = "";
            DecimalBox.Text = "";
            digit = true;
            number = 0;
        }
    }
}