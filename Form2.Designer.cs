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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(208, 27);
            label1.Name = "label1";
            label1.Size = new Size(387, 54);
            label1.TabIndex = 0;
            label1.Text = "Bug Tracking System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 130);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(318, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 31);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 190);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 247);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 4;
            label4.Text = "Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 300);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(321, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(321, 311);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 31);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.Location = new Point(334, 377);
            button1.Name = "button1";
            button1.Size = new Size(205, 34);
            button1.TabIndex = 9;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 432);
            label6.Name = "label6";
            label6.Size = new Size(318, 25);
            label6.TabIndex = 10;
            label6.Text = "If you are already Sign up Login Please";
            label6.Click += label6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 496);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
    }
}