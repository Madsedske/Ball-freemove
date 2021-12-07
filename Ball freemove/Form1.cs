using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_freemove
{
    public partial class Form1 : Form
    {
        int ballx = 2;
        int bally = 2;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            gametimer.Start();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            pictureBoxBall.Left += ballx;
            pictureBoxBall.Top += bally;

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre1.Bounds))
                bally = -bally;

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre2.Bounds))
                ballx = -ballx;

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre3.Bounds))
                bally = -bally;

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxYdre4.Bounds))
                ballx = -ballx;


            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxIndre1.Bounds))
            {
                if (pictureBoxBall.Location.X > 242) // 242
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxIndre1.Location.X)
                {
                    ballx = -ballx;
                }
                else
                    bally = -bally;
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxIndre2.Bounds))
            {
                if (pictureBoxBall.Location.X > 396)// 396
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxIndre2.Location.X)
                {
                    ballx = -ballx;
                }
                else
                    bally = -bally;
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxIndre3.Bounds))
            {
                if (pictureBoxBall.Location.X > 373)// 373
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxIndre3.Location.X)
                {
                    ballx = -ballx;
                }
                else
                    bally = -bally;
            }

            if (pictureBoxBall.Bounds.IntersectsWith(pictureBoxIndre4.Bounds))
            {
                if (pictureBoxBall.Location.X > 180) // 180
                {
                    ballx = -ballx;
                }
                else if (pictureBoxBall.Location.X < pictureBoxIndre4.Location.X)
                {
                    ballx = -ballx;
                }
                else
                    bally = -bally;
            }
        }
    }
}
