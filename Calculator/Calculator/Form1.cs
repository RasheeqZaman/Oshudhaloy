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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setTopText("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setTopText("2");
        }


        private void button9_Click(object sender, EventArgs e)
        {
            setTopText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setTopText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setTopText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setTopText("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setTopText("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTopText("8");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            setTopText("9");
        }

        private void setTopText(string num)
        {
            label1.Text += num;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setTopText("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setTopText("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            setTopText("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            setTopText("/");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setTopText(".");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setTopText("0");
        }
    }
}
