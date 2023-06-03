using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        decimal num1;
        decimal num2;
        string option;
        decimal result;
        // knappen som visar 0
        private void button0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button0.Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button1.Text;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button9.Text;
        }
        
        // Gör så att att användaren kan göra decimal tal
        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Contains(","))
            {
            }
            else
            {
                textDisplay.Text = textDisplay.Text + ",";
            }


        }
        private void buttonDivison_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = decimal.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = decimal.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = decimal.Parse(textDisplay.Text);

            textDisplay.Clear();

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = decimal.Parse(textDisplay.Text);

            textDisplay.Clear();
        }


 // Resultat knapp
        private void buttonResult_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(textDisplay.Text);

            if (option == ("+"))
                result = num1 + num2;

            if (option == ("-"))
                result = num1 - num2;

            if (option == ("*"))
                result = num1 * num2;

            if (option == ("/"))
                result = num1 / num2;

            textDisplay.Text = result + "";

            textDisplay.Text = result + "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);

        }


    }
}
