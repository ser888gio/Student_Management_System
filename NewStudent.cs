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
    public partial class NewStudent : Form
    {
        StudentClass student = new StudentClass();
        readonly string csvimportpath = "C\\";
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string first_name = txtBoxfirst_name.Text;
            string last_name = txtBoxlast_name.Text;
            DateTime DB = dateTimeDB.Value;
            string gender = rBttnGenderM.Checked ? "Male" : "Female";

            int born_year = dateTimeDB.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year < 7 || this_year - born_year > 19))
            {
                MessageBox.Show("Věk musí byt mezi 7 a 19", "Neplatný věk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (verify())
            {
                try
                {
                    if (student.insertStudent(first_name, last_name, DB, gender))
                    {
                        showTable();
                        MessageBox.Show("Nový student přidan", "Přidat studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }catch(Exception ex)
                
                
                {
                    MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("PrazDBý řadek", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verify()
        {
            if((txtBoxfirst_name.Text == "") || (txtBoxlast_name.Text == ""))
                    {
                        return false;
                    }
            else { return true; }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridStudenti.DataSource = student.getStudentList(new MySqlCommand("SELECT * FROM `student`"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxfirst_name.Clear();
            txtBoxlast_name.Clear();
        }


        private void bttnImportCSV_Click(object sender, EventArgs e)
        {
            student.importStudentCSV(csvimportpath);
        }
    }
}
