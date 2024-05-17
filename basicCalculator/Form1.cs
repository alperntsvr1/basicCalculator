using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void dort_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void alti_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void carp_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void bol_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            
            string expression = textBox1.Text;

            
            char[] operators = expression.Where(c => c == '+' || c == '-' || c == '*' || c == '/').ToArray();
            string[] parts = expression.Split(operators);
            
            if (parts.Length < 2)
            {
                MessageBox.Show("Invalid expression!");
                return;
            }

            double result = double.Parse(parts[0]);

            for (int i = 0; i <operators.Length; i++)
            {
                
                double operand = double.Parse(parts[i+1]);

                
                char op = operators[i];

                
                switch (op)
                {
                    case '*':
                        result *= operand;
                        break;
                    case '+':
                        result += operand;
                        break;
                    case '-':
                        result -= operand;
                        break;

                    case '/':
                        
                        if (operand == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed!");
                            return;
                        }
                        result /= operand;
                        break;
                    default:
                        MessageBox.Show("Invalid operator: " + op);
                        return;
                }
                
            }
           MessageBox.Show("Result: " + result);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
