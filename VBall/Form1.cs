using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBall
{
    public partial class Form1 : Form
    {

        public int speed_left = new Random().Next(2, 10);
        public int speed_top = new Random().Next(5, 10);
        public int key_increse = 0;
        public int UpPoint = 0;   //score
        public int DownPoint = 0;
        public int control = 0;  //default using the auto moving control
        public int modeselect = 0; //default single mode

        public Form1()
        {
            InitializeComponent();

            MenuPanel.Hide();
            ControlPanel.Hide();
            ScorePanel.Hide();
            racket2.Hide();
            Orange.Hide();
            menuLabel.BackColor = Color.DarkTurquoise;
            UpScore.Hide();

            AMoving.BackColor = Color.Gray;
            MMoving.BackColor = Color.Black;

            singleMode.BackColor = Color.Gray;
            MultiMode.BackColor = Color.Black;

            timer1.Enabled = true;
            timer1.Interval = 5;

            ball.Left = playground.Left / 2;
            ball.Top = playground.Top / 2;

            key_increse = playground.Width / 90;

            //for fullscreen
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket1.Left = 0;
            racket1.Top = playground.Bottom * 9 / 10;

            racket2.Left = (playground.Width - racket2.Width) * 1 / 2;
            racket2.Top = playground.Bottom * 1 / 10;
        }

        //timer1 for mouse and racket1 movement
        private void timer1_Tick(object sender, EventArgs e)
        {
            //control 
            racket1.Left = Cursor.Position.X - (racket1.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= racket1.Top && ball.Bottom <= racket1.Bottom && ball.Right >= racket1.Left && ball.Left <= racket1.Right)
            {
                if (modeselect == 0)
                {
                    speed_top += 2;
                    speed_left += 2;
                    speed_top = -speed_top;
                    UpPoint += 1;
                    DownScore.Text = "SCORE: " + UpPoint.ToString();
                }
                else if (modeselect == 1)
                {
                    //speed_top += 2;
                    //speed_left += 2;
                    speed_top = -speed_top;
                }

            }
            else if (ball.Top < racket2.Bottom && ball.Top > racket2.Top && ball.Right >= racket2.Left && ball.Left <= racket2.Right)
            {
                if (modeselect == 0)
                {

                }
                else if (modeselect == 1)
                {
                    //speed_top += 2;
                    //speed_left += 2;
                    speed_top = -speed_top;


                }
            }
            else if (ball.Left <= playground.Left || ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            else if (ball.Top <= playground.Top)
            {
                if (modeselect == 0)
                {
                    speed_top = -speed_top;
                }
                else if (modeselect == 1)
                {
                    timer1.Stop();
                    DownPoint += 1;
                    DownScore.Text = "SCORE: " + DownPoint.ToString();

                    ball.Left = 500;
                    ball.Top = 500;
                    speed_left = new Random().Next(2, 10);
                    speed_top = new Random().Next(2, 10);

                    timer1.Start();
                }


            }
            else if (ball.Bottom >= playground.Bottom)
            {
                if (modeselect == 0)
                {
                    timer1.Stop();
                    ball.Left = new Random().Next(500, 800);
                    ball.Top = new Random().Next(500, 800);
                    speed_left = new Random().Next(2, 10);
                    speed_top = new Random().Next(2, 10);
                    ball.Hide();
                    DownScore.Text = "SCORE: " + UpPoint.ToString();
                    ScorePanel.Show();

                    showScore.Text = UpPoint.ToString();
                    UpPoint = 0;

                }
                else if (modeselect == 1)
                {
                    timer1.Stop();
                    UpPoint += 1;
                    UpScore.Text = "SCORE: " + UpPoint.ToString();

                    ball.Left = 500;
                    ball.Top = 500;
                    speed_left = 8;
                    speed_top = 8;

                    timer1.Start();
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                timer1.Stop();
                timer2.Stop();
                MenuPanel.Show();
                playIcon.Hide();
                pauseIcon.Show();

            }
            if (e.KeyCode == Keys.F2)
            {
                timer1.Start();
                //timer2.Start();
                MenuPanel.Hide();
                playIcon.Show();
                pauseIcon.Hide();

            }
            if (control == 0)
            {

                if (e.KeyCode == Keys.Left)
                {

                    if (timer2.Enabled == false && key_increse > 0)
                    {
                        timer2.Start();
                        timer2.Interval = 5;
                    }
                    else if (timer2.Enabled == true && key_increse > 0)
                    {
                        timer2.Enabled = false;
                    }
                    else if (timer2.Enabled == false && key_increse < 0)
                    {
                        key_increse = -key_increse;
                        timer2.Start();
                        timer2.Interval = 5;
                    }
                    else if (timer2.Enabled == true && key_increse < 0)
                    {
                        key_increse = -key_increse;
                        timer2.Enabled = false;
                    }

                }
                else if (e.KeyCode == Keys.Right)
                {

                    if (timer2.Enabled == false && key_increse < 0)
                    {
                        timer2.Start();
                        timer2.Interval = 5;
                    }
                    else if (timer2.Enabled == true && key_increse < 0)
                    {
                        timer2.Enabled = false;
                    }
                    else if (timer2.Enabled == false && key_increse > 0)
                    {
                        key_increse = -key_increse;
                        timer2.Start();
                        timer2.Interval = 5;
                    }
                    else if (timer2.Enabled == true && key_increse > 0)
                    {
                        key_increse = -key_increse;
                        timer2.Enabled = false;
                    }



                }
                //----------------------------------------future version: adding double speed function-------------------------------------------------
                //if (Control.ModifierKeys == Keys.Alt)      // determine if player put down the alt key (not)
                //{
                //    key_increse = 2 * key_increse;

                //}
                //else            // determine if player put down the alt key (yes)
                //{
                //    //if (key_increse > 0)
                //    //{
                //    //    key_increse = playground.Width / 180;
                //    //}
                //    //else
                //    //{
                //    //    key_increse = -playground.Width / 180;
                //    //}
                //}
            }
            else if (control == 1)
            {
                if (e.KeyCode == Keys.Left && Control.ModifierKeys == Keys.Alt)
                {
                    racket2.Left -= 7 * key_increse;

                }
                else if (e.KeyCode == Keys.Right && Control.ModifierKeys == Keys.Alt)
                {
                    racket2.Left += 7 * key_increse;

                }
                else if (e.KeyCode == Keys.Left && Control.ModifierKeys != Keys.Alt)
                {
                    racket2.Left -= key_increse;

                }
                else if (e.KeyCode == Keys.Right && Control.ModifierKeys != Keys.Alt)
                {

                    racket2.Left += key_increse;

                }

            }

        }

        //------------------------Try to use RadioButtom but failed-------------------
        //private void AMoveRB_CheckedChanged(object sender, EventArgs e)
        //{
        //    control = 1;
        //    ControlPanel.Hide();
        //    MenuPanel.Show();
        //}

        //private void MMoveRB_CheckedChanged(object sender, EventArgs e)
        //{
        //    control = 0;
        //    ControlPanel.Hide();
        //    MenuPanel.Show();
        //}

        private void returnIcon_Click(object sender, EventArgs e)
        {
            ControlPanel.Hide();
            MenuPanel.Show();
        }

        private void AMoving_Click(object sender, EventArgs e)
        {
            control = 0;
            AMoving.BackColor = Color.Gray;
            MMoving.BackColor = Color.Black;
            ControlPanel.Hide();
            MenuPanel.Show();
            timer2.Start();
        }

        private void controlLable_Click(object sender, EventArgs e)
        {
            //MenuPanel.Hide();
            ControlPanel.Show();
        }

        private void MMoving_Click(object sender, EventArgs e)
        {
            control = 1;
            AMoving.BackColor = Color.Black;
            MMoving.BackColor = Color.Gray;
            ControlPanel.Hide();
            MenuPanel.Show();
            timer2.Stop();
        }

        private void ReturnToGame_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MenuPanel.Hide();
            playIcon.Show();
            pauseIcon.Hide();
        }

        private void singleMode_Click(object sender, EventArgs e)
        {
            modeselect = 0;
            singleMode.BackColor = Color.Gray;
            MultiMode.BackColor = Color.Black;
            racket2.Hide();
            Orange.Hide();
            UpScore.Hide();
            menuLabel.BackColor = Color.DarkTurquoise;
            UpPoint = 0;
            DownPoint = 0;
        }

        private void MultiMode_Click(object sender, EventArgs e)
        {
            modeselect = 1;
            singleMode.BackColor = Color.Black;
            MultiMode.BackColor = Color.Gray;
            racket2.Show();
            UpScore.Show();
            Orange.Show();
            menuLabel.BackColor = Color.Orange;
            UpPoint = 0;
            DownPoint = 0;

        }

        private void replay_Click(object sender, EventArgs e)
        {
            ScorePanel.Hide();
            ball.Show();
            timer1.Start();
        }


        private void AboutMe_Click(object sender, EventArgs e)
        {
            if (AboutMe.Text != "VINCE!!")
                AboutMe.Text = "VINCE!!";
            else
                AboutMe.Text = "ABOUT";
        }

        private void CloseGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (racket2.Left > playground.Left && racket2.Right < playground.Right)
            {
                racket2.Left -= key_increse;
            }
            else
            {
                key_increse = -key_increse;
                racket2.Left -= key_increse;
                timer2.Stop();
            }

        }

    }
}
