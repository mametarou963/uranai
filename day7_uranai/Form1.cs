using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day7_uranai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(2);
            if(randomNumber == 0)
            {
                // 大吉
                pictureBox1.ImageLocation = @"..\..\Properties\大吉.jpg";
                textBox2.Text = @"今日はとてもいいことがあるよ";
            }
            else
            {
                // 中吉
                pictureBox1.ImageLocation = @"..\..\Properties\中吉.jpg";
                textBox2.Text = @"今日はいいことがあるよ";
            }
        }
    }
}
