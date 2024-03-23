﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample.Forms
{
    public partial class ASSESSMENTS : Form
    {
        public ASSESSMENTS()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dt = AssessmentDL.GetAssessmentData();
            dataGridView1.DataSource = dt;
        }
        private bool AreAllFieldEmpty()
        {
            if (TitleBox.Text == "" && MarksBox.Text == "" && WeightBox.Text == "")
            {
                return true;
            }
            return false;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AreAllFieldEmpty())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            string Title = TitleBox.Text;
            int Marks = Convert.ToInt32(MarksBox.Text);
            int Weight = Convert.ToInt32(WeightBox.Text);
            bool success = AssessmentDL.AddAssessment(Title, Marks, Weight);
            if (success)
            {
                MessageBox.Show("Assessment Added Successfully");
                TitleBox.Text = "";
                MarksBox.Text = "";
                WeightBox.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to Add Assessment");
            }
            LoadData();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            bool success = AssessmentDL.DeleteAssessment(Id);
            if (success)
            {
                MessageBox.Show("Assessment Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Delete Assessment");
            }
            LoadData();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (AreAllFieldEmpty())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Row to Update Data");
                return;
            }
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string Title = TitleBox.Text;
            int Marks = Convert.ToInt32(MarksBox.Text);
            int Weight = Convert.ToInt32(WeightBox.Text);
            bool success = AssessmentDL.UpdateAssessment(Id, Title, Marks, Weight);
            if (success)
            {
                MessageBox.Show("Assessment Updated Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Update Assessment");
            }
            LoadData();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Goto Assessment Components Form
            this.Hide();
            Assessment_Component form = new Assessment_Component();
            form.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MarksBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            WeightBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void ASSESSMENTS_Load(object sender, EventArgs e)
        {

        }
    }
}
