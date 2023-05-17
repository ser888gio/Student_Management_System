using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMS_Server
{
    public partial class NewCourse : Form
    {
        CourseClass course = new CourseClass();
        public NewCourse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxCourseName.Text == "" || txtBoxCourseHour.Text == "")
            {
                MessageBox.Show("Empty text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string course_name = txtBoxCourseName.Text;
                int hr = Convert.ToInt32(txtBoxCourseHour.Text);
                string desc = txtBoxCourseDesc.Text;

                if (course.insertCourse( course_name, hr, desc))
                {
                    showData();
                    btnClear.PerformClick();
                    MessageBox.Show("Succesfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error while adding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }   

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxCourseName.Clear();
            txtBoxCourseHour.Clear();
            txtBoxCourseDesc.Clear();   
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            dataGridCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));

        }
    }
}
