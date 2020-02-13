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
    public partial class Form3 : Form
    { 
        int cp = 0;
        public Form3()
        {
            InitializeComponent();
        }

        int start_game = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pr.Value++;
          
        }

        private void pr_ProgressChanged(object sender, EventArgs e)
        {
            if (pr.Value == 100)
            {
                pr.Value = 0;
                start_game++;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cp++;
            label2.Text += ".";

            if (cp == 4)
            {
                label2.Text = "";
                cp = 0;

            }
            if (start_game == 1)
            {
                timer1.Stop();
                timer2.Stop();
                form4 f = new form4();
                f.ShowDialog();
            }

        }
    }
}
