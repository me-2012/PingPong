using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        int BallX = 15;
        int BallY = 15;
        int P1 = 0;
        int P2 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Paddle1.Top -= 10;
            }
            else if (e.KeyCode == Keys.S)
            {
                Paddle1.Top += 10;
            }

            if (e.KeyCode == Keys.Up)
            {
                Paddle2.Top -= 10;
            }
            else if (e.KeyCode == Keys.Down)
            {
                Paddle2.Top += 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball.Top += BallY;
            Ball.Left += BallX;

            if (Ball.Location.Y > 620)
            {
                BallY = -BallY;
            }
            else if (Ball.Location.X > 1445)
            {
                BallX = -BallX;
                P1++;
                player1Score.Text = P1.ToString();
            }
            else if (Ball.Location.Y < 0)
            {
                BallY = -BallY;
            }
            else if (Ball.Location.X < 0)
            {
                BallX = -BallX;
                P2++;
                P2Score.Text = P2.ToString();

            }

            if (Ball.Bounds.IntersectsWith(Paddle1.Bounds))
            {
                BallX = -BallX;

            }
            if (Ball.Bounds.IntersectsWith(Paddle2.Bounds))
            {
                BallX = -BallX;
            }
            if (P1 == 10)
            {
                EndCard.Text = "PLAYER 1 WON!!!";
                EndCard.Visible = true;
                timer1.Stop();
            }
            else if (P2 == 10)
            {
                EndCard.Text = "PLAYER 2 WON!!!";
                EndCard.Visible = true;
                timer1.Stop();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EndCard.Visible = false;
            Ball.Location = new Point(750, 350);
            timer1.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
