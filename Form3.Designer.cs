﻿namespace WinFormsApp1
{
    partial class Form3
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(318, 18);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 0;
            label1.Text = "Bug Reporting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 99);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Bug Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 144);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Bug Description";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 183);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 3;
            label4.Text = "Step to Reproduce";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 293);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 4;
            label5.Text = "Expected Behaviour";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 335);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 5;
            label6.Text = "Actual Behaviour";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.Location = new Point(318, 387);
            button1.Name = "button1";
            button1.Size = new Size(203, 34);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(318, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 31);
            textBox3.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(319, 191);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(273, 82);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(318, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 31);
            textBox4.TabIndex = 13;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private TextBox textBox4;
    }
}