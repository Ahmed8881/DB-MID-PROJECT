﻿namespace sample.Forms
{
    partial class CLOS
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
            CLONAME = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ADDCLO = new Button();
            UPDATECLO = new Button();
            DELETECLO = new Button();
            label1 = new Label();
            DatePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CLONAME
            // 
            CLONAME.AutoSize = true;
            CLONAME.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            CLONAME.Location = new Point(46, 85);
            CLONAME.Margin = new Padding(2, 0, 2, 0);
            CLONAME.Name = "CLONAME";
            CLONAME.Size = new Size(56, 23);
            CLONAME.TabIndex = 0;
            CLONAME.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 85);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(339, 83);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(559, 485);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ADDCLO
            // 
            ADDCLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ADDCLO.BackColor = SystemColors.Highlight;
            ADDCLO.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            ADDCLO.ForeColor = SystemColors.ControlLightLight;
            ADDCLO.Image = Properties.Resources.icons8_add_50;
            ADDCLO.ImageAlign = ContentAlignment.MiddleLeft;
            ADDCLO.Location = new Point(339, 605);
            ADDCLO.Margin = new Padding(2, 3, 2, 3);
            ADDCLO.Name = "ADDCLO";
            ADDCLO.Size = new Size(170, 60);
            ADDCLO.TabIndex = 7;
            ADDCLO.Text = "ADD";
            ADDCLO.UseVisualStyleBackColor = false;
            ADDCLO.Click += AddClo_Click;
            // 
            // UPDATECLO
            // 
            UPDATECLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UPDATECLO.BackColor = SystemColors.Highlight;
            UPDATECLO.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UPDATECLO.ForeColor = SystemColors.ControlLightLight;
            UPDATECLO.Image = Properties.Resources.icons8_update_done_24;
            UPDATECLO.ImageAlign = ContentAlignment.MiddleLeft;
            UPDATECLO.Location = new Point(533, 605);
            UPDATECLO.Margin = new Padding(2, 3, 2, 3);
            UPDATECLO.Name = "UPDATECLO";
            UPDATECLO.Size = new Size(154, 60);
            UPDATECLO.TabIndex = 8;
            UPDATECLO.Text = "UPDATE";
            UPDATECLO.UseVisualStyleBackColor = false;
            UPDATECLO.Click += UpdateClo_Click;
            // 
            // DELETECLO
            // 
            DELETECLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DELETECLO.BackColor = SystemColors.Highlight;
            DELETECLO.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DELETECLO.ForeColor = SystemColors.ControlLightLight;
            DELETECLO.Image = Properties.Resources.icons8_delete_48__1_;
            DELETECLO.ImageAlign = ContentAlignment.MiddleLeft;
            DELETECLO.Location = new Point(733, 605);
            DELETECLO.Margin = new Padding(2, 3, 2, 3);
            DELETECLO.Name = "DELETECLO";
            DELETECLO.Size = new Size(175, 60);
            DELETECLO.TabIndex = 9;
            DELETECLO.Text = "DELETE";
            DELETECLO.UseVisualStyleBackColor = false;
            DELETECLO.Click += DeleteClo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(46, 172);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 10;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(105, 172);
            DatePicker.Margin = new Padding(3, 4, 3, 4);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(228, 27);
            DatePicker.TabIndex = 11;
            // 
            // CLOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 714);
            Controls.Add(DatePicker);
            Controls.Add(label1);
            Controls.Add(DELETECLO);
            Controls.Add(UPDATECLO);
            Controls.Add(ADDCLO);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(CLONAME);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CLOS";
            Text = "CLOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CLONAME;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button ADDCLO;
        private Button UPDATECLO;
        private Button DELETECLO;
        private Label label1;
        private DateTimePicker DatePicker;
    }
}