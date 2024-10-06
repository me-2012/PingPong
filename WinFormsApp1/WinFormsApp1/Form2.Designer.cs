namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Paddle1 = new PictureBox();
            Paddle2 = new PictureBox();
            Ball = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            P1Score = new Label();
            P2Score = new Label();
            player1Score = new Label();
            ExitButton = new Label();
            EndCard = new Label();
            ((System.ComponentModel.ISupportInitialize)Paddle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Paddle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Paddle1
            // 
            Paddle1.BackColor = Color.White;
            Paddle1.Location = new Point(253, 245);
            Paddle1.Name = "Paddle1";
            Paddle1.Size = new Size(32, 179);
            Paddle1.TabIndex = 0;
            Paddle1.TabStop = false;
            // 
            // Paddle2
            // 
            Paddle2.BackColor = Color.White;
            Paddle2.Location = new Point(1259, 262);
            Paddle2.Name = "Paddle2";
            Paddle2.Size = new Size(32, 179);
            Paddle2.TabIndex = 1;
            Paddle2.TabStop = false;
            // 
            // Ball
            // 
            Ball.BackColor = Color.White;
            Ball.BackgroundImageLayout = ImageLayout.Stretch;
            Ball.Location = new Point(1445, 361);
            Ball.Name = "Ball";
            Ball.Size = new Size(35, 35);
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // P1Score
            // 
            P1Score.AutoSize = true;
            P1Score.Font = new Font("MS PGothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P1Score.ForeColor = Color.White;
            P1Score.Location = new Point(477, 7);
            P1Score.Name = "P1Score";
            P1Score.Size = new Size(0, 34);
            P1Score.TabIndex = 3;
            // 
            // P2Score
            // 
            P2Score.AutoSize = true;
            P2Score.Font = new Font("MS PGothic", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P2Score.ForeColor = Color.White;
            P2Score.Location = new Point(641, 9);
            P2Score.Name = "P2Score";
            P2Score.RightToLeft = RightToLeft.Yes;
            P2Score.Size = new Size(64, 67);
            P2Score.TabIndex = 4;
            P2Score.Text = "0";
            // 
            // player1Score
            // 
            player1Score.AutoSize = true;
            player1Score.Font = new Font("MS PGothic", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1Score.ForeColor = Color.White;
            player1Score.Location = new Point(697, 9);
            player1Score.Name = "player1Score";
            player1Score.RightToLeft = RightToLeft.No;
            player1Score.Size = new Size(64, 67);
            player1Score.TabIndex = 6;
            player1Score.Text = "0";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 20F);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(1408, 7);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(59, 37);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.Click += ExitButton_Click;
            // 
            // EndCard
            // 
            EndCard.AutoSize = true;
            EndCard.Font = new Font("Segoe UI", 100F);
            EndCard.ForeColor = Color.White;
            EndCard.Location = new Point(253, 247);
            EndCard.Name = "EndCard";
            EndCard.Size = new Size(1010, 177);
            EndCard.TabIndex = 8;
            EndCard.Text = "PLAYER _ WON!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1479, 659);
            Controls.Add(EndCard);
            Controls.Add(ExitButton);
            Controls.Add(player1Score);
            Controls.Add(P2Score);
            Controls.Add(P1Score);
            Controls.Add(Ball);
            Controls.Add(Paddle2);
            Controls.Add(Paddle1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Paddle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Paddle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Paddle1;
        private PictureBox Paddle2;
        private PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private Label P1Score;
        private Label P2Score;
        private Label player1Score;
        private Label ExitButton;
        private Label EndCard;
    }
}