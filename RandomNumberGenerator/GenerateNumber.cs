using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class GenerateNumber : Form
    {
        private static int startnum;
        private static int endnum;
        public GenerateNumber()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals(null) || textBox1.Equals(""))
            {
                MessageBox.Show("Please enter a range to continue!");
            }
            else
            {
                Random ran = new Random();
                if (textBox1.Text.Contains("-"))
                {
                    String[] numbers = textBox1.Text.Split('-');
                    if (numbers[0].Contains(" ") || numbers[1].Contains(" "))
                    {
                        numbers[0].Trim(' ');
                        numbers[1].Trim(' ');
                        startnum = Convert.ToInt32(numbers[0]);
                        endnum = Convert.ToInt32(numbers[1]);
                        textBox2.Text = Convert.ToString(ran.Next(startnum, endnum));
                    }
                    else
                    {
                        startnum = Convert.ToInt32(numbers[0]);
                        endnum = Convert.ToInt32(numbers[1]);
                        textBox2.Text = Convert.ToString(ran.Next(startnum, endnum));
                    }
                }
                else
                {
                    MessageBox.Show("Please enter in the specified format! e.g. 0-100");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
