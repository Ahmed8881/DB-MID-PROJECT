﻿namespace sample.Forms
{
    partial class ASSESSMENTS
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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 59);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(538, 459);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(116, 48);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Location = new Point(158, 183);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "Weight";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Location = new Point(158, 119);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = "Marks";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(911, 459);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(107, 48);
            button2.TabIndex = 7;
            button2.Text = "DELETE\r\n";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(705, 459);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(121, 48);
            button3.TabIndex = 8;
            button3.Text = "UPDATE\r\n";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(519, 23);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(539, 406);
            dataGridView1.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(44, 345);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(362, 50);
            button4.TabIndex = 10;
            button4.Text = "Go To Assessment Comp\r\n Page\r\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 115);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 11;
            label1.Text = "Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 179);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 12;
            label3.Text = "Weightage";
            // 
            // ASSESSMENTS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 714);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "ASSESSMENTS";
            Text = "ASSESSMENTS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label1;
        private Label label3;
    }
}