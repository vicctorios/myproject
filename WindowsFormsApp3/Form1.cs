using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private string FirstStringNumber = "";

        private double FirstNumber = new double();
        private double SecondNumber = new double();
        private string Znak;

        public Form1()
        {
            InitializeComponent();
        }

        //метод, обрабатывающий нажатие кнопки 0
        private void button17_Click(object sender, EventArgs e)
        {
            WriteNumber("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            WriteNumber("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WriteNumber("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            WriteNumber("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            WriteNumber("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            WriteNumber("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            WriteNumber("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            WriteNumber("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            WriteNumber("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            WriteNumber("9");
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            WriteNumber(".");
        }

        private void WriteNumber(string numb)
        {

            textBox1.Text = "";
            FirstStringNumber += numb;
            textBox1.Text = FirstStringNumber;
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (FirstStringNumber.Length > 0)
                FirstStringNumber = FirstStringNumber.Remove(FirstStringNumber.Length - 1, 1);
            textBox1.Text = FirstStringNumber;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            ButtonClick("+");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            ButtonClick("-");
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            ButtonClick("*");
        }

        private void button_degree_Click(object sender, EventArgs e)
        {
            ButtonClick("/");
        }

        private void ButtonClick(string znak)
        {
            FirstStringNumber = FirstStringNumber.Replace('.', ',');
            if (FirstStringNumber != "")
            {

                FirstNumber = Convert.ToDouble(FirstStringNumber);
                FirstStringNumber = "";
                textBox1.Text = "";
                Znak = znak;
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (FirstStringNumber != "")
            {
                SecondNumber = Convert.ToDouble(FirstStringNumber);
                switch (Znak)
                {
                    case "+":
                        FirstStringNumber = Convert.ToString(FirstNumber + SecondNumber);
                        textBox1.Text = FirstStringNumber;
                        break;

                    case "-":
                        FirstStringNumber  = Convert.ToString(FirstNumber - SecondNumber);
                        textBox1.Text = FirstStringNumber;
                        break;

                    case "*":
                        FirstStringNumber  = Convert.ToString(FirstNumber * SecondNumber);
                        textBox1.Text = FirstStringNumber;
                        break;

                    case "/":
                        FirstStringNumber = Convert.ToString(FirstNumber / SecondNumber);
                        textBox1.Text = FirstStringNumber;
                        break;


                }

            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            FirstStringNumber = "";
            FirstNumber = new double();
            SecondNumber = new double();
            textBox1.Text = "";
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            FirstStringNumber = "";
        }

        private void button_PLUSMINUS_Click(object sender, EventArgs e)
        {
            if (FirstStringNumber[0] != '-')
            {
                string newString = "-";
                newString += FirstStringNumber;
                textBox1.Text = newString;
                FirstStringNumber = newString;
            }
            else
            {
                FirstStringNumber = FirstStringNumber.Remove(0, 1);
                textBox1.Text = FirstStringNumber;
            }
        }
    }
}
