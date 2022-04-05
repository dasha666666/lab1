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
    public partial class Form4 : Form
    {
        Team[] teams = new Team[5];
        public Form4()
        {
            InitializeComponent();
            Team team = new Team();
            teams[0] = new Team();
            teams[0].Set("1", "Miami Heat", "MIA", "1.jpg");

            teams[1] = new Team();
            teams[1].Set("2", "Orlando Magic", "ORL", "2.jpg");


            teams[2] = new Team();
            teams[2].Set("3", "Atlanta Hawks", "ATL", "3.jpg");


            teams[3] = new Team();
            teams[3].Set("4", "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new Team();
            teams[4].Set("5", "Charlotte Hornets", "CHA", "5.jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label35.Text = teams[0].Name;
            label31.Text = teams[1].Name;
            label30.Text = teams[2].Name;
            label25.Text = teams[3].Name;
            label24.Text = teams[4].Name;
            Eastern.Controls["textBox16"].Controls["textBox13"].Controls["label" + 35].Text = teams[0].Name;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
