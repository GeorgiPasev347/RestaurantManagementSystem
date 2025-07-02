namespace MarriageHallManagement
{
    partial class MainPage
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
            button2 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(485, 142);
            button2.Name = "button2";
            button2.Size = new Size(167, 46);
            button2.TabIndex = 4;
            button2.Text = "Customers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button4.ForeColor = Color.Brown;
            button4.Location = new Point(485, 244);
            button4.Name = "button4";
            button4.Size = new Size(167, 46);
            button4.TabIndex = 6;
            button4.Text = "Staff";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 60);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Brown;
            label4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(755, 12);
            label4.Name = "label4";
            label4.Size = new Size(33, 35);
            label4.TabIndex = 9;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 40);
            label1.TabIndex = 0;
            label1.Text = "Vigos Restaurant";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(76, 142);
            label2.Name = "label2";
            label2.Size = new Size(388, 40);
            label2.TabIndex = 1;
            label2.Text = "See your Customers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(91, 244);
            label3.Name = "label3";
            label3.Size = new Size(292, 40);
            label3.TabIndex = 8;
            label3.Text = "See your Staff:";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button2);
            ForeColor = SystemColors.ControlLightLight;
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button4;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}