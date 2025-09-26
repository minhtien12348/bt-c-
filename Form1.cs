using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace bai3_26_9_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(textBox2.Text);
            tong=int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            label4.Text = tong.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(textBox2.Text);
            tong = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            label4.Text = tong.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(textBox2.Text);
            tong = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            label4.Text = tong.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           float tong;
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(textBox2.Text);
            tong = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
            label4.Text = tong.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
