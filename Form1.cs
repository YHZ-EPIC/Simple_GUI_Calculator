using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class m_Window : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char op;
        double res = 0.0;

        public m_Window()
        {
            InitializeComponent();
        }

        private void m_Window_Load(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "0";
            this.Output.Text += input;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += ".";
            this.Output.Text += input;
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            op2 = input;

            double x;
            double y;

            x = Convert.ToDouble(op1);
            y = Convert.ToDouble(op2);

            if (op == '+')
            {
                res = x + y;

                Output.Text = (op1.ToString() + "  " + op + "  " + op2.ToString() + "  =  " + res.ToString());
            }
            else if (op == '-')
            {
                res = x - y;
                Output.Text = (op1.ToString() + "  " + op + "  " + op2.ToString() + "  =  " + res.ToString());
            }

            else if (op == '*')
            {
                res = x * y;
                Output.Text = (op1.ToString() + "  " + op + "  " + op2.ToString() + "  =  " + res.ToString());
            }

            else if (op == '/')
            {
                if (y != 0)
                {
                    res = x / y;
                    Output.Text = (op1.ToString() + "  " + op + "  " + op2.ToString() + "  =  " + res.ToString());
                }
                else
                {
                    Output.Text = "Error !";
                }
            }

            else if(op == '%')
            {
                res = x % y;
                Output.Text = (op1.ToString() + "  " + op + "  " + op2.ToString() + " = " + res.ToString());
            }

            else if(op == '^')
            {
                res = Math.Pow(x,y);
                Output.Text = (op1.ToString() + "  " + op + "  " + op2.ToString() + " = " + res.ToString());
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "1";
            this.Output.Text += input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "2";
            this.Output.Text += input;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "3";
            this.Output.Text += input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "4";
            this.Output.Text += input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "5";
            this.Output.Text += input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "6";
            this.Output.Text += input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "7";
            this.Output.Text += input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "8";
            this.Output.Text += input;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "9";
            this.Output.Text += input;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '+';
            input = string.Empty;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '-';
            input = string.Empty;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '*';
            input = string.Empty;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '/';
            input = string.Empty;
        }

        private void Remainder_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '%';
            input = string.Empty;
        }

        private void Power_Click(object sender, EventArgs e)
        {
            op1 = input;
            op = '^';
            input = string.Empty;
        }

        private void Output_Click(object sender, EventArgs e)
        {
            op = 'N';
            input = string.Empty;

            if (op == 'N')
            {
                Output.Text = " Created By YHZ , :) ";
            }
        }
    }
}
