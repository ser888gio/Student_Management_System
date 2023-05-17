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
    public partial class NewMark : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        MarkClass Mark = new MarkClass();
        public NewMark()
        {
            InitializeComponent();
        }

        private void NovaMark_Load(object sender, EventArgs e)
        {
            cBoxPredmet.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            cBoxPredmet.DisplayMember = "Course_Name";
            cBoxPredmet.ValueMember = "Course_Name";

            dataGridStudenti.DataSource = student.getStudentList(new MySqlCommand("SELECT `StudentID`, `Student_FN`, `Student_LN` FROM `student`"));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentID.Text == "" || txtBoxMark.Text == "")
            {
                MessageBox.Show("PrazDBý pole", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int student_id = Convert.ToInt32(txtBoxStudentID.Text);
                string course_name = cBoxPredmet.Text;
                int znamk = Convert.ToInt32(txtBoxMark.Text);
                string Description = txtBoxCourseDesc.Text;
                if(!Mark.checkMark(student_id, course_name))
                {
                    if (Mark.insertMark(student_id, course_name, znamk, Description))
                    {
                        btnClear.PerformClick();
                        MessageBox.Show("Uspěšně přídano", "Přídano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chyba při přidaní", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Známka už existuje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxStudentID.Clear();
            txtBoxMark.Clear();
            txtBoxCourseDesc.Clear();
            cBoxPredmet.SelectedIndex = 0;
        }

        private void showMark()
        {
            dataGridStudenti.DataSource = Mark.getMark(new MySqlCommand("SELECT marks.StudentID, student.Student_FN, student.Student_LN,marks.Mark, marks.Description FROM student INNER JOIN marks ON marks.StudentID = student.StudentID"));
        }

        private void dataGridStudenti_Click(object sender, EventArgs e)
        {
            txtBoxStudentID.Text = dataGridStudenti.CurrentRow.Cells[0].Value.ToString();  
        }

        private void btnZobrazStd_Click(object sender, EventArgs e)
        {
            dataGridStudenti.DataSource = student.getStudentList(new MySqlCommand("SELECT `StudentID`, `Student_FN`, `Student_LN` FROM `student`"));
        }

        private void btnZobrazmarks_Click(object sender, EventArgs e)
        {
            showMark();
        }
    }
}
