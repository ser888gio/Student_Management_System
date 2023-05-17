using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Server
{
    public partial class ManageMarksForm : Form
    {
        CourseClass course = new CourseClass();
        MarkClass Mark = new MarkClass();
        public ManageMarksForm()
        {
            InitializeComponent();
        }

        private void ManagemarksForm_Load(object sender, EventArgs e)
        {
            cBoxCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            cBoxCourse.DisplayMember = "Course_Name";
            cBoxCourse.ValueMember = "Course_Name";

            showMark();
        }

        public void showMark()
        {
            dataGridCourse.DataSource = Mark.getMark(new MySqlCommand("SELECT marks.StudentID, student.Student_FN, student.Student_LN,marks.Mark, marks.Description FROM student INNER JOIN marks ON marks.StudentID = student.StudentID"));

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentID.Text == "" || txtBoxMark.Text == "")
            {
                MessageBox.Show("PrazDBý pole", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int student_id = Convert.ToInt32(txtBoxStudentID.Text);
                string course_name = cBoxCourse.Text;
                int znamk = Convert.ToInt32(txtBoxMark.Text);
                string Description = txtBoxDesc.Text;
                
                    if (Mark.updateMark(course_name, student_id, znamk, Description))
                    {
                        btnClear.PerformClick();
                        MessageBox.Show("Uspěšně změneno", "Přídano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chyba při změně", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentID.Text == "")
            {
                MessageBox.Show("Chyba při mazání", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txtBoxStudentID.Text);
                if (MessageBox.Show("Opravdu to chcete smazat", "Smazat studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (Mark.deleteMark(id))
                    {
                        showMark();
                        MessageBox.Show("Smázano", "Smázano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnClear.PerformClick();
                    }

                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxStudentID.Clear();
            txtBoxMark.Clear();
            txtBoxDesc.Clear();
            cBoxCourse.SelectedIndex = 0;
        }

        private void dataGridCourse_Click(object sender, EventArgs e)
        {
            txtBoxStudentID.Text = dataGridCourse.CurrentRow.Cells[0].Value.ToString();
            cBoxCourse.Text = dataGridCourse.CurrentRow.Cells[2].Value.ToString();
            txtBoxMark.Text = dataGridCourse.CurrentRow.Cells[3].Value.ToString();
            txtBoxDesc.Text = dataGridCourse.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridCourse.DataSource = Mark.searchMark(txtBoxSearch.Text);
            txtBoxSearch.Clear();
        }

    }
}
