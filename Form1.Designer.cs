namespace MarriageHallManagement
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(494, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 35);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            textBox2.Location = new Point(494, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 35);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(512, 276);
            button1.Name = "button1";
            button1.Size = new Size(143, 49);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(551, 49);
            label1.Name = "label1";
            label1.Size = new Size(76, 27);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(515, 156);
            label2.Name = "label2";
            label2.Size = new Size(140, 27);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 440);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vigos;
            pictureBox1.Location = new Point(52, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(52, 31);
            label3.Name = "label3";
            label3.Size = new Size(292, 31);
            label3.TabIndex = 0;
            label3.Text = "Restaurant Vigos";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Brown;
            linkLabel1.Location = new Point(525, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 35);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Admin";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
