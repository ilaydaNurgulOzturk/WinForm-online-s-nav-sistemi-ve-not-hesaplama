namespace WinFormsApp5
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label10 = new Label();
            panel3 = new Panel();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 327);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(15, 271);
            button4.Name = "button4";
            button4.Size = new Size(331, 29);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DortButon;
            // 
            // button3
            // 
            button3.Location = new Point(15, 220);
            button3.Name = "button3";
            button3.Size = new Size(331, 29);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DortButon;
            // 
            // button2
            // 
            button2.Location = new Point(15, 175);
            button2.Name = "button2";
            button2.Size = new Size(331, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DortButon;
            // 
            // button1
            // 
            button1.Location = new Point(15, 127);
            button1.Name = "button1";
            button1.Size = new Size(331, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DortButon;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 13);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(614, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 177);
            panel2.TabIndex = 0;
            panel2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(14, 109);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 3;
            label6.Text = "Puan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(15, 77);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 2;
            label5.Text = "Net";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(15, 48);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 1;
            label4.Text = "Yanlis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(14, 16);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 0;
            label3.Text = "Dogru";
            // 
            // button5
            // 
            button5.Location = new Point(14, 408);
            button5.Name = "button5";
            button5.Size = new Size(158, 76);
            button5.TabIndex = 3;
            button5.Text = "Başlat";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(81, 67);
            label7.Name = "label7";
            label7.Size = new Size(28, 28);
            label7.TabIndex = 4;
            label7.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(58, 67);
            label8.Name = "label8";
            label8.Size = new Size(17, 28);
            label8.TabIndex = 5;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(29, 67);
            label9.Name = "label9";
            label9.Size = new Size(28, 28);
            label9.TabIndex = 6;
            label9.Text = "--";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(29, 35);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 7;
            label10.Text = "Kalan Süreniz:";
            label10.Click += label10_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(614, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 109);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // button6
            // 
            button6.Location = new Point(426, 408);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(181, 79);
            button6.TabIndex = 9;
            button6.Text = "Not Hesaplama";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.duzce_universitesi_kurumsal_kimligini_yeniledi_10102022_1739_ic;
            pictureBox1.Location = new Point(614, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(45, 24);
            label11.Name = "label11";
            label11.Size = new Size(0, 30);
            label11.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Candara", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(14, 24);
            label12.Name = "label12";
            label12.Size = new Size(277, 33);
            label12.TabIndex = 12;
            label12.Text = "Bilişim Dersi Final Sınavı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 608);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "z";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button5;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private Label label10;
        private Panel panel3;
        private Button button6;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
    }
}