using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String[] imgList = new String[]
               { "1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg"};
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("../../../Pictures/" + imgList[0]);
            pictureBox3.Load("../../../Pictures/" + imgList[1]);
            pictureBox4.Load("../../../Pictures/" + imgList[2]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index+3 > imgList.Length) index = 0;
            pictureBox1.Load("../../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imgList[index + 2]);
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = index - 1;
            if (index < 0) index = imgList.Length-3;
            pictureBox1.Load("../../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../Pictures/" + imgList[index + 2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
