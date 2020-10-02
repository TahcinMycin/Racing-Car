//https://youtu.be/_4EuZI8Q8cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            victory.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coincollection();
        }

        int collectedcoins = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (car1.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(0, 400);
                car1.Location = new Point(x, 0);
            }
            else
            {
                car1.Top += speed;
            }

            if (car2.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(0, 400);
                car2.Location = new Point(x, 0);
            }
            else
            {
                car2.Top += speed;
            }

            if (car3.Top >= 500)
            {
                x = r.Next(250, 400);
                y = r.Next(0, 400);
                car3.Location = new Point(x, 0);
            }
            else
            {
                car3.Top += speed;
            }

        }

        void gameover()
        {
            if (racer.Bounds.IntersectsWith(car1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (racer.Bounds.IntersectsWith(car2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (racer.Bounds.IntersectsWith(car3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }


            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }


            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }


            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }


            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
            
            victory.Top += speed;
            

        }

        

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(175, 300);
                y = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(200, 200);
                y = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 200);
                y = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);
                y = r.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }

        }

        void coincollection()
        {
            if (racer.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(50, 200);
                y = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }

            else if (racer.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(50, 200);
                y = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }

            else if (racer.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(50, 200);
                y = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }

            else if (racer.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label2.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(50, 200);
                y = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
        }


        int gamespeed = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }        
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void racer_Click(object sender, EventArgs e)
        {

        }

        private void car1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (over.Visible == true || victory.Visible == true)
            {
                victory.Visible = false;
                over.Visible = false;
                collectedcoins = 0;
                label2.Text = "Coins: 0";
                timer1.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form game = new About();
            game.Visible = true;
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is created by Tahcin Ul Karim(Mycin)\nEnjoy it.");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (racer.Left > 30)
                {
                    racer.Left += -8;
                }
            }

            else if (e.KeyCode == Keys.Right)
            {
                if (racer.Right < 470)
                {
                    racer.Left += 8;
                }
            }

            else if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            else if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }
    }
}
