using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_18.Calculator
{
    public partial class Form1 : Form
    {

        private StandardCalculator calculator = new StandardCalculator(50, 50);

        bool hasUserClickedOperatorButton = false;

        string number = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            SetNumber(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNumber(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNumber(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetNumber(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetNumber(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetNumber(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetNumber(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetNumber(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetNumber(9);
        }




        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SetOperator(Operators.Plus);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            SetOperator(Operators.Multiply);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            SetOperator(Operators.Minus);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            SetOperator(Operators.Divide);
        }
        private void SetOperator(Operators op)
        {
            number = "";
            hasUserClickedOperatorButton = true;
            calculator.SetOperator(op);
        }
        private void SetNumber(double n)
        {
            number += n.ToString();
            if (hasUserClickedOperatorButton==false)
            {
                calculator.SetOperand1(double.Parse(number));
            }
            else
            {
                calculator.SetOperand2(double.Parse(number));
            }
            lblDisplay.Text = number;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            number = "";
            calculator.Clear();
            lblDisplay.Text = "";
            hasUserClickedOperatorButton = false;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Operation op = calculator.Evaluate();
            lblDisplay.Text = op.Value.ToString();
        }
    }
}
