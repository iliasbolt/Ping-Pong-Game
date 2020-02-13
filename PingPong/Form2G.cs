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
    public partial class Form2G : Form
    {
        bool wsalleft = false;//hadi bax nxoufo wax wsel l right wa left
        bool wsaltop = false;//wa hadi bax nxoufo wax wsal l top wa Height
        int speed = 2;//Speed Manager
        bool hit_panel = false;//Hada bax nxouf wax ball Jat f Labar
        int score = 0;
        bool sound_silent = true;
        // check for height score//
        List<int> ch = new List<int>();
        public Form2G()
        {
            InitializeComponent();
        }

        private void Form2G_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form2G_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                labar.Left += 7;
            }
            if (e.KeyData == Keys.Left)
            {
                labar.Left -= 7;
            }
            if (e.KeyData == Keys.Enter)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("you wanna close it?","closing",MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    this.Close();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                {
                    timer1.Start();
                }
               
                
            }
            // Wraping // hada bax txouf ila kharjet 3la widht wa lheight dial lform
            if (labar.Left > Width - 70)
                labar.Location = new Point(8, 338);
            if (labar.Left < -20 )
                labar.Location = new Point(408, 338);

            // hada bax ndir les Tips
            //stop the game
            if (e.KeyData == Keys.P)
            {
                timer1.Stop();
                lblstatusclick.Text = "Game Paused";
            }
            // resume the game
            if (e.KeyData == Keys.R)
            {
                lblstatusclick.Text = "Game Continue";
                timer1.Start();
            }
            // silent the game
            if (e.KeyData == Keys.S)
            {
                lblstatusclick.Text = "Sound On";
                sound_silent = false;
            }
            //sound back to the game 
            if (e.KeyData == Keys.C)
            {
                lblstatusclick.Text = "Sound Off";
                sound_silent = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // hadi bax ball wrap //
            
           
                // les test 3la right wa left dial lform //

            if (ball.Left >= Width-35)
                wsalleft = true;

            if (ball.Left <= 0)
                wsalleft = false;


            if (wsalleft)
                ball.Left-=speed;
            else
                ball.Left+=speed;

            


            if (ball.Top >= Height - 15)
                wsaltop = true;

            if (ball.Top <= 0)
                wsaltop = false;


            if (wsaltop)
                ball.Top -= speed;
            else
                ball.Top += speed;

            // test bax nxoufo lkoora wax jat flabar /// baqi khassha lkhedma //// 

            if (ball.Location.X + ball.Width - 10 >= labar.Location.X && ball.Location.Y >= labar.Location.Y - 20 && labar.Location.X + labar.Width >=                                       ball.Location.X)
            {
                hit_panel = true;
                lose();
                
                wsaltop = true;
                score++;
                score_And_speed();//hadi fonction bax tzid speed 3la 7seb score
                label1.Text = string.Format("{0}", score);
            }
            else
            {
                lose();
                
            }
            if ((hit_panel ) && !(sound_silent))
            {
                Console.Beep();
            }

            hit_panel  = false;
            

        }
       

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            RestartGame();
        }
        /// <summary>
        /// Restart New Game (Nouvaux Jeux )
        /// </summary>
        public void RestartGame()
        {
            Panelrestart.Visible = false;
            ball.Location = new Point(3, 3);
            timer1.Start();
            speed = 2;
            score = 0;
            labar.Location = new Point(187, 338);
        }
        /// <summary>
        /// Method Pour Accelere Avec La Vitesse(speed)
        /// </summary>
        public void score_And_speed()
        {
            if (score > 10)
                speed += 3;
             
             if (score > 20)
                speed += 4;
           
             if (score > 40)
                speed += 5;
        }
        /// <summary>
        /// checking for losing the game
        /// </summary>
        public void lose()
        {
            if (ball.Top >= Height - 17)
            {
                timer1.Stop();
                ch.Add(score);
                MessageBox.Show(" You lose !! ");
                Panelrestart.Visible = true;
                scoretxt.Text = string.Format("{0} Point", score);
                height_score();
                
            }

        }
        public void height_score()
        {
            int max = ch.Max();
            crs.Text = string.Format("{0}",max);
        }
      
    }
}
