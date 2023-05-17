using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMS_Server
{
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourserForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            dataGridCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxCourseName.Clear();
            txtBoxCourseHour.Clear();
            txtBoxCourseDesc.Clear();
            txtBoxCourseID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxCourseName.Text == "" || txtBoxCourseHour.Text == "" || txtBoxCourseID.Text.Equals(""))
            {
                MessageBox.Show("Empty text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txtBoxCourseID.Text);
                string course_name = txtBoxCourseName.Text;
                int hour = Convert.ToInt32(txtBoxCourseHour.Text);
                string desc = txtBoxCourseDesc.Text;

                if (course.updateCourse(id, course_name, hour, desc))
                {
                    showData();
                    btnClear.PerformClick();
                    MessageBox.Show("Successfully changed", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error while updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxCourseID.Text.Equals(""))
            {
                MessageBox.Show("Empty text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(txtBoxCourseID.Text);


                    if (course.deleteCourse(id))
                    {
                        showData();
                        btnClear.PerformClick();
                        MessageBox.Show("Succesfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }catch(Exception ex)
               
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void dataGridCourse_Click(object sender, EventArgs e)
        {
            txtBoxCourseID.Text = dataGridCourse.CurrentRow.Cells[0].Value.ToString();
            txtBoxCourseName.Text = dataGridCourse.CurrentRow.Cells[1].Value.ToString();
            txtBoxCourseHour.Text = dataGridCourse.CurrentRow.Cells[2].Value.ToString();
            txtBoxCourseDesc.Text = dataGridCourse.CurrentRow.Cells[3].Value.ToString();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridCourse.DataSource = course.searchCourse(txtBoxSearch.Text);
            txtBoxSearch.Clear();
        }

    }
}
