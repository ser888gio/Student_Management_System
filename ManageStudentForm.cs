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
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        public void showTable()
        {
            dataGridStudenti.DataSource = student.getStudentList(new MySqlCommand("SELECT * FROM `student`"));
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void dataGridStudenti_Click(object sender, EventArgs e)
        {
            txtBoxId.Text = dataGridStudenti.CurrentRow.Cells[0].Value.ToString();
            txtBoxFN.Text = dataGridStudenti.CurrentRow.Cells[1].Value.ToString();
            txtBoxlast_name.Text = dataGridStudenti.CurrentRow.Cells[2].Value.ToString();
            
            dateTimeDB.Value = (DateTime)dataGridStudenti.CurrentRow.Cells[3].Value;
            if (dataGridStudenti.CurrentRow.Cells[4].Value.ToString() == "M")
                rBttnGenderM.Checked = true;
            else
                rBttnGenderF.Checked = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxFN.Clear();
            txtBoxlast_name.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridStudenti.DataSource = student.searchStudent(txtBoxSearchStd.Text);
        }

        bool verify()
        {
            if ((txtBoxFN.Text == "") || (txtBoxlast_name.Text == ""))
            {
                return false;
            }
            else { return true; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBoxId.Text);
            string first_name = txtBoxFN.Text;
            string last_name = txtBoxlast_name.Text;
            DateTime DB = dateTimeDB.Value;
            string gender = rBttnGenderM.Checked ? "Male" : "Female";

            int born_year = dateTimeDB.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year < 7 || this_year - born_year > 26))
            {
                MessageBox.Show("The age must be between 7 and 26 years old", "Invalid age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (verify())
            {
                try
                {
                    if (student.updateStudent(id, first_name, last_name, DB, gender))
                    {
                        showTable();
                        MessageBox.Show("Succesfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)


                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Empty text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBoxId.Text);
            if (MessageBox.Show("Do you really want to delete it", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (student.deleteStudent(id))
                {
                    showTable();
                    MessageBox.Show("Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnClear.PerformClick();
                }

            }
        }
    }
}
