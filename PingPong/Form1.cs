using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            player1.Checked = true;
            timer1.Start();
            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //bunifuCircleProgressbar1.Visible = false;
            //bunifuCircleProgressbar2.Visible = false;
            //timer1.Stop();

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            bunifuCircleProgressbar1.Visible = false;
            bunifuCircleProgressbar2.Visible = false;

            panel1.Visible = false;
            if (player1.Checked)
            {
                Form2G f = new Form2G();
                f.Show();
            }
            else
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
            

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
           

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value++;
            bunifuCircleProgressbar2.Value++;
            if (bunifuCircleProgressbar1.Value == 100)
                bunifuCircleProgressbar1.Value = 0;

            if (bunifuCircleProgressbar2.Value == 100)
                bunifuCircleProgressbar2.Value = 0;
        }
    }
}
