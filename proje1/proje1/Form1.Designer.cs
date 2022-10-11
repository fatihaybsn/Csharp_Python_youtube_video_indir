namespace proje1
{
    partial class YouTube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTube));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(140, 172);
            button1.Name = "button1";
            button1.Size = new Size(149, 84);
            button1.TabIndex = 0;
            button1.Text = "En Düşük Kalite";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DodgerBlue;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(140, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumBlue;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(433, 172);
            button2.Name = "button2";
            button2.Size = new Size(149, 84);
            button2.TabIndex = 2;
            button2.Text = "720p";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumBlue;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(140, 322);
            button3.Name = "button3";
            button3.Size = new Size(149, 84);
            button3.TabIndex = 3;
            button3.Text = "1080p";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(175, 45);
            label1.Name = "label1";
            label1.Size = new Size(381, 41);
            label1.TabIndex = 4;
            label1.Text = "YOUTUBE VİDEO İNDİR";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumBlue;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(433, 322);
            button4.Name = "button4";
            button4.Size = new Size(149, 84);
            button4.TabIndex = 5;
            button4.Text = "2160p";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumBlue;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.White;
            button5.Location = new Point(2, 614);
            button5.Name = "button5";
            button5.Size = new Size(128, 84);
            button5.TabIndex = 6;
            button5.Text = "Programı Kapat";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // YouTube
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(739, 732);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            ForeColor = Color.Black;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YouTube";
            Text = "YouTube Video İndir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}
