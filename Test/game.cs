using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class game : Form
    {
        int speed = 4; // Bird Speed
        int score = 0; // In Game Score
        int pipespeed = 12; //Pipe movement speed
        int ghostspeed = 5; // Ghost Speed

        public game()
        {
         
            InitializeComponent();
        }
        private void Timerevent(object sender, EventArgs e) // Timer: 20ms
        {
            bird.Top += speed;
            toppipe.Left -= pipespeed;
            bottompipe.Left -= pipespeed;
            ghost.Left -= 10;
            label1.Text = ("Score: " + score);
            
            if (toppipe.Left <-55)
            {
                score++;
                toppipe.Left = 750;
                if(score % 5 == 0)
                {
                    pipespeed += 3;
                    ghost.Visible = true;
                }
            }
            if (bottompipe.Left < -55)
            {
                score++;
                bottompipe.Left = 900;
                if (score % 5 == 0)
                {
                    pipespeed += 3;
                    ghost.Visible = true;
                }
            }
            if (ghost.Left < -55)
            {
                ghost.Left = 900;

            }
            if (ghost.Visible == true) // Ghost movement
            {
                
                if (ghost.Bounds.IntersectsWith(ground.Bounds))
                {
                    ghostspeed =  -5;
                }
                if(ghost.Bounds.IntersectsWith(panel2.Bounds))
                {
                    ghostspeed = 5;
                }

                ghost.Top += ghostspeed;

                if (bird.Bounds.IntersectsWith(ghost.Bounds))
                {
                    label1.Text = ("Score: " + score);

                    endgame();
                }
            }

            if (bird.Bounds.IntersectsWith(toppipe.Bounds) || bird.Bounds.IntersectsWith(bottompipe.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                label1.Text = ("Score: " + score);
               
                endgame();
            }
        }

        private void Upkey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                speed = -4;
            }
            if (e.KeyCode == Keys.Down)
            {
                speed = 4;
            }
            
        }

        private void endgame()
        {
            menu.Visible = true;
            quit.Visible = true;
            panel1.Visible = true;
            gameover.Visible = true;
            
            timer1.Stop();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.ShowDialog();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            game F = new game();
            F.ShowDialog();

        }


    }
}
