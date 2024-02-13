namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(402, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 538);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(123, 236);
            label2.Name = "label2";
            label2.Size = new Size(243, 42);
            label2.TabIndex = 1;
            label2.Text = "The Desktop App is built using\r\n             c# for social icon\r\n";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 83);
            label1.Name = "label1";
            label1.Size = new Size(338, 84);
            label1.TabIndex = 0;
            label1.Text = "Desktop App Login \r\n           Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(87, 35);
            label3.Name = "label3";
            label3.Size = new Size(108, 42);
            label3.TabIndex = 2;
            label3.Text = "Login\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(168, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(87, 225);
            label4.Name = "label4";
            label4.Size = new Size(131, 38);
            label4.TabIndex = 2;
            label4.Text = "Or use your account\r\n\r\n";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Email";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += Form1_Load;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 341);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "Password";
            textBox2.Click += textBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(120, 432);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(93, 378);
            label5.Name = "label5";
            label5.Size = new Size(119, 19);
            label5.TabIndex = 10;
            label5.Text = "Forgot Password ?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 523);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
    }
}
