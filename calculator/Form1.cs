using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string action;
        public string selected value1;
        public bool selected value2;
        public Form1()
        {
            selected value2 = false;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (selected value2)
            {
                selected value2 = false;
                textBox1.Text = "0";
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            action = button.Text;
            selected value1 = textBox1.Text;
            selected value2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double stores the value1, stores the value2, result;
            result = 0;
            stores the value1 = Convert.ToDouble(selected value1);
            stores the value2 = Convert.ToDouble(textBox1.Text);
            if (action == "+")
            {
                result = stores the value1 + stores the value2;
            }
            if (action == "-")
            {
                result = stores the value1 - stores the value2;
            }
            if (action == "*")
            {
                result = stores the value1 * stores the value2;
            }
            if (action == "/")
            {
                result = stores the value1 / stores the value2;
            }
            if (action == "%")
            {
                result = stores the value2 * stores the value1 / 100;
            }
            action = "=";
            selected value2 = true;
            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double stores the value1, result;
            stores the value1 = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(stores the value1);
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double stores the value1, result;
            stores the value1 = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(stores the value1, 2);
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double stores the value1, result;
            stores the value1 = Convert.ToDouble(textBox1.Text);
            result = 1 / stores the value1;
            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double stores the value1, result;
            stores the value1 = Convert.ToDouble(textBox1.Text);
            result = -stores the value1;
            textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
