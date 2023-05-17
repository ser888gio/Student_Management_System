using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMS_Server
{
    public partial class ExportStudent : Form
    {
        StudentClass student = new StudentClass();
        public ExportStudent()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `student`"));
        }

        public void showData(MySqlCommand command)
        {
            dataGridStudenti.ReadOnly = true;
            dataGridStudenti.DataSource = student.getList(command);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (rBtnAll.Checked)
            {
                selectQuery = "SELECT * FROM `student`";
            }
            else if (rBtnM.Checked)
            {
                selectQuery = "SELECT * FROM `student` WHERE `Student_Gender` = 'M'";
            }

            else
            {
                selectQuery = "SELECT * FROM `student` WHERE `Student_Gender` = 'F'";
            }
            showData(new MySqlCommand(selectQuery));

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // Build the CSV file data as a Comma separated string.
                StringBuilder csv = new StringBuilder();

                // Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dataGridStudenti.Columns)
                {
                    csv.Append(column.HeaderText + ",");
                }

                // Add new line.
                csv.Append(Environment.NewLine);

                // Adding the Rows.
                foreach (DataGridViewRow row in dataGridStudenti.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            // Add the Data rows.
                            csv.Append(cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ",");
                        }
                    }
                    // Add new line.
                    csv.Append(Environment.NewLine);
                }

                // Exporting to CSV.
                string folderPath = "C://";
                string filePath = Path.Combine(folderPath, "Students.csv");
                File.WriteAllText(filePath, csv.ToString());
                MessageBox.Show("The data has been exported to ", filePath + "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
