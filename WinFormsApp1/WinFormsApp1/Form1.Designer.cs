namespace WinFormsApp1
{
    partial class Play
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.text_1726427088984;
            button1.Location = new Point(543, 382);
            button1.Name = "button1";
            button1.Size = new Size(411, 171);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Your_paragraph_text;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1239, 665);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Play";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
