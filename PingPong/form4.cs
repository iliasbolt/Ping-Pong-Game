using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PingPong
{
    public partial class form4 : Form
    {
        bool wsaltop = false;
        bool wsalleft = false;
        int speed = 1;
       
        int score1 = 0;
        int score2 = 0;


        WMPLib.WindowsMediaPlayer music = new WindowsMediaPlayer();
        

        public form4()
        {
            InitializeComponent();
        }
        public void lose()
        {
            if (ball.Left >= this.Width - 25)
            {
                timer1.Stop();
                MessageBox.Show("Player 2 Lose !!");
                panel1.Visible = true;
               
                winner();
            }
            if (ball.Left <= 2)
            {
                timer1.Stop();
                MessageBox.Show("Player 1 Lose !!");
                panel1.Visible = true;
               
                winner();
            }   
            
        }
        /// <summary>
        /// Method Pour Accelere Avec La Vitesse(speed)
        /// </summary>
        public void score_And_speed()
        {
            if (score1 >= 5 && score2 >= 5)
            {
                speed = 2;
            }
            if (score1 >= 20 && score2 >= 20)
            {
                speed = 3;
            }



        }
        public void winner()
        {
            txtsc1.Text = string.Format("{0} Point", score1);
            txtsc2.Text = string.Format("{0} Point", score2);

            if (score2 > score1)
            {
                label4.Text = "Player 2";
                point.Text = " " + score2;
            }
            else if (score2 < score1)
            {
                label4.Text = "Player 1";
                point.Text = " " + score1;
            }
            else
            {
                label4.Text = "Equals !!";
                point.Text = " " + score2;
            }

        }
        public void RestartGame()
        {
            panel1.Visible = false;
            ball.Location = new Point(Width/2, Height/2);
            timer1.Start();
            speed = 1;
            score1 = 0;
            score2 = 0;

            
        }
        private void form4_Load(object sender, EventArgs e)
        {

            timer1.Start();
            music.URL = "Hello.mp3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // hna bax nxedha men lfo9 TOP

            if (ball.Top >= this.Height - 32)
                wsaltop = true;
            if (ball.Top <= 0)
                wsaltop = false;
            // hna bax nxedha men jenb Left

            if (ball.Left >= this.Width - 25)
            {
                wsalleft = true;
                lose();
            }
            if (ball.Left <= 0)
            {

                lose();
                wsalleft = false;
            
            }
                

            if (wsaltop)
            {
                ball.Top-=speed;
            }
            else
            {
                ball.Top+=speed;
            }


            if (wsalleft)
                ball.Left-=speed;
            else
                ball.Left+=speed;

            //test for losing //
            //lose();
            //

            
            //player 1
            // hadi khadama 100 %
            if (bar1.Location.Y + bar1.Height > ball.Location.Y && bar1.Location.Y + bar1.Height > ball.Location.Y + ball.Height && bar1.Location.X >                      ball.Location.X && (ball.Location.Y + ball.Height >= bar1.Location.Y || ball.Location.Y < bar1.Location.Y + bar1.Height) && ball.Top                             > bar1.Top && ball.Top < bar1.Top + bar1.Height)
            {
                lose();
                wsalleft = false; // hna bax trja3 hhhh
                score1++;
                
                pl1.Text = string.Format("{0}", score1);
               
                lose();
            }

            //hadi bax nzid sor3aaa speed hahahahaheheheheheh 

            score_And_speed();




             //hada l bar2 hahahaah hadi baqi fiha difo khassni nkamel 3liha 
            if (bar2.Location.Y + bar2.Height  > ball.Location.Y && bar2.Location.Y + bar2.Height > ball.Location.Y + ball.Height && bar2.Location.X  -                 28<= ball.Location.X  && (ball.Location.Y>= bar2.Location.Y || ball.Location.Y < bar2.Location.Y + bar2.Height) && ball.Top > bar2.Top                      && ball.Top < bar2.Top +bar1.Height)
            {
                lose();
                wsalleft = true;//bax yrje3 
                
                score2++;
                pl2.Text = string.Format("{0}",score2);
           
                
                
            }
         
        }

        private void form4_KeyDown(object sender, KeyEventArgs e)
        {
            //player 2

            if (e.KeyData == Keys.Up)
            {
                bar2.Top-=6;
            }
            if (e.KeyData == Keys.Down)
            {
                bar2.Top+=6;
            }

            // player1
            if (e.KeyData == Keys.W)
            {
                bar1.Top-=6;
            }
            if (e.KeyData == Keys.X)
            {
                bar1.Top+=6;
            }
           
            if (e.KeyData == Keys.Enter)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("you wanna close it?", "closing", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    music.controls.stop();
                    this.Close();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                {
                    timer1.Start();

                }   
 
               
            }
            // testing for options 

            if (e.KeyData == Keys.P)
            {
                timer1.Stop();
                label1.Text = "Game Paused";
            }
            // resume the game
            if (e.KeyData == Keys.R)
            {
                label1.Text = "Game Continue";
                timer1.Start();
            }
           
          
            // sound the game
            if (e.KeyData == Keys.S)
            {
                label1.Text = "Sound On";
                music.controls.play();
            }
            //sound off
            if (e.KeyData == Keys.C)
            {
                label1.Text = "Sound Off";
                music.controls.pause();
          
            }
           //wraping panel //
            if (bar1.Top >= Height - 55)
            {
                bar1.Top = -13;
            }
            if (bar1.Top < -50)
                bar1.Top = Height - 57;


            if (bar2.Top >= Height - 55)
            {
                bar2.Top = -13;
            }
            if (bar2.Top < -50)
                bar2.Top = Height - 57;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            RestartGame();
            music.controls.play();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            music.controls.stop();
            panel1.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
            
        }

       
    }
}
