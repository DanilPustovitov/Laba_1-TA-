using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_TA_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            var binaryNumber = string.Empty;
            while (num > 0)
            {
                binaryNumber = (num % 2) + binaryNumber;
                num /= 2;
            }

            label1.Text = binaryNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string binaryNumber = label1.Text;
            StringBuilder str = new StringBuilder();
            foreach(char i in binaryNumber)
            {
                str.Append(i == '1' ? '0' : '1');
            }
            int result = Convert.ToInt32(str.ToString(), 2);
            label2.Text = result.ToString();
        }
    }
}
