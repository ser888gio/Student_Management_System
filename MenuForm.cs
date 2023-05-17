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
    public partial class MenuForm : Form
    {
        StudentClass student = new StudentClass();
        public MenuForm()
        {
            InitializeComponent();
            customDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PocetStd()
        {
            lblStdCount.Text = "Student count: " + student.totalStudent();
            lblBoysCount.Text = "Boys count: " + student.totalStudentM();
            lblGirlsCount.Text = "Girls count: " + student.totalStudentF();
        }

        private void customDesign()
        {
            panelStudents.Visible = false;
            panelCourses.Visible = false;
            panelmarks.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelStudents.Visible == true) 
            {
                panelStudents.Visible = false;  
            }

            if (panelCourses.Visible == true)
            {
                panelCourses.Visible = false;
            }

            if (panelmarks.Visible == true)
            {
                panelmarks.Visible = false;
            }
        }

        private void showSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }

            else
            {
                panel.Visible = false;
            }

        }

        private  void button_students_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudents); 
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCourses);
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmarks);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMenu .Controls.Add(childForm);
            panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistrace_Click(object sender, EventArgs e)
        {
            openChildForm(new NewStudent());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            PocetStd();
        }

        private void btnManageStudentu_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm()); 
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            openChildForm(new ExportStudent());
        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCourse());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
        }

        private void btnExportPr_Click(object sender, EventArgs e)
        {
            openChildForm(new ExportCourse());
        }

        private void btnNewMark_Click(object sender, EventArgs e)
        {
            openChildForm(new NewMark());
        }

        private void btnManageMarks_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageMarksForm());
        }

        private void btnExportMarks_Click(object sender, EventArgs e)
        {
            openChildForm(new ExportMark());
        }
    }
}
