using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ball_freemove
{
    public partial class Form1 : Form
    {
        int ballx = 1;
        int bally = 1;
        int tæller = 0;
        int rødFirkant = 0;
        int blåFirkant = 0;
        int grønFirkant = 0;
        int gulFirkant = 0;

        SoundPlayer indreMur = new SoundPlayer(@"C:\Users\zbcmber\Desktop\clank-cartoon.wav");
        SoundPlayer ydreMur = new SoundPlayer(@"C:\Users\zbcmber\Desktop\pipe9.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            pictureBoxBall.Left += ballx;
            pictureBoxBall.Top += bally;

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre1.Bounds))
            {
                bally = -bally;
                ydreMur.Play();
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre2.Bounds))
            {
                ballx = -ballx;
                ydreMur.Play();
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre3.Bounds))
            {
                bally = -bally;
                ydreMur.Play();
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre4.Bounds))
            {
                ballx = -ballx;
                ydreMur.Play();
            }


            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxRødFirkant.Bounds)) //INDRE MUR 1
            {
                rødFirkant++;
                indreMur.Play();
                if (pictureBoxBall.Location.X == 241) // 242 højre side
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxRødFirkant.Location.X)
                {
                    if (pictureBoxBall.Location.Y < 127 || pictureBoxBall.Location.Y == 190) // 191                    
                        bally = -bally;
                    else
                        ballx = -ballx;
                }
                else if (pictureBoxBall.Location.Y < pictureBoxRødFirkant.Location.Y || pictureBoxBall.Location.Y == 190)// 191
                {
                    bally = -bally;
                }
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxBlåFirkant.Bounds)) //INDRE MUR 2
            {
                blåFirkant++;
                indreMur.Play();
                if (pictureBoxBall.Location.X == 395)// 396 højre side
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxBlåFirkant.Location.X)
                {
                    if (pictureBoxBall.Location.Y < 111 || pictureBoxBall.Location.Y == 168)// 169                    
                        bally = -bally;
                    else
                        ballx = -ballx;
                }
                else if (pictureBoxBall.Location.Y < pictureBoxBlåFirkant.Location.Y || pictureBoxBall.Location.Y == 168)// 169
                {
                    bally = -bally;
                }
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxGrønFirkant.Bounds)) //INDRE MUR 3
            {
                grønFirkant++;
                indreMur.Play();
                if (pictureBoxBall.Location.X == 372)// 373 højre side
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxGrønFirkant.Location.X)
                {
                    if (pictureBoxBall.Location.Y < 248 || pictureBoxBall.Location.Y == 344)// 345            
                        bally = -bally;
                    else
                        ballx = -ballx;
                }
                else if (pictureBoxBall.Location.Y < pictureBoxGrønFirkant.Location.Y || pictureBoxBall.Location.Y == 344)// 345             
                {
                    bally = -bally;
                }
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxGulFirkant.Bounds)) //INDRE MUR 4
            {
                gulFirkant++;
                indreMur.Play();
                if (pictureBoxBall.Location.X == 179) // 180 højre side
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxGulFirkant.Location.X)
                {
                    if (pictureBoxBall.Location.Y < 272 || pictureBoxBall.Location.Y == 404)// 405
                        bally = -bally;
                    else
                        ballx = -ballx;
                }
                else if (pictureBoxBall.Location.Y < pictureBoxGulFirkant.Location.Y || pictureBoxBall.Location.Y == 404) // 405                
                {
                    bally = -bally;
                }
            }
            label2.Text = "Rød firkant: " + rødFirkant.ToString() + ".        " + "Blå firkant: " + blåFirkant.ToString() + ".\n" + "Gul firkant: " + gulFirkant.ToString() + ".         " + "Grøn firkant: " + grønFirkant.ToString() + ". ";
        }

        private void Tæller_Tick(object sender, EventArgs e)
        {
            tæller++;
            label1.Text = "Sekunder: " + TimeSpan.FromSeconds(tæller).ToString("ss");
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            int xInput = Convert.ToInt32(textBoxXLocation.Text);
            int yInput = Convert.ToInt32(textBoxYLocation.Text);
            pictureBoxBall.Top = yInput;
            pictureBoxBall.Left = xInput;
            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxBlåFirkant.Bounds) || pictureBoxBall.Bounds.IntersectsWith(pictureBoxRødFirkant.Bounds) || pictureBoxBall.Bounds.IntersectsWith(pictureBoxGrønFirkant.Bounds) || pictureBoxBall.Bounds.IntersectsWith(pictureBoxGulFirkant.Bounds))
            {
                gametimer.Stop();
                Tæller.Stop();
                MessageBox.Show("You can't hit a colored box.. Try again");
            }
            else
            {
                gametimer.Start();
                Tæller.Start();
            }
            tæller = 0;
            int rødFirkant = 0;
            int blåFirkant = 0;
            int grønFirkant = 0;
            int gulFirkant = 0;
            label1.Text = "Sekunder: " + TimeSpan.FromSeconds(tæller).ToString("ss");
            label2.Text = "Rød firkant: " + rødFirkant.ToString() + ".        " + "Blå firkant: " + blåFirkant.ToString() + ".\n" + "Gul firkant: " + gulFirkant.ToString() + ".         " + "Grøn firkant: " + grønFirkant.ToString() + ". ";
        }
    }
}
