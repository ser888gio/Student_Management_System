using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Server
{
    public partial class ExportCourse : Form
    {
        CourseClass course = new CourseClass();
        public ExportCourse()
        {
            InitializeComponent();
        }

        private void ExportCourse_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridCourse.DataSource = course.searchCourse(txtBoxSearchStd.Text);
            txtBoxSearchStd.Clear();
        }

        private void showData()
        {
            dataGridCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

  
        private void btnExport_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Build the CSV file data as a Comma separated string.
                StringBuilder csv = new StringBuilder();

                // Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dataGridCourse.Columns)
                {
                    csv.Append(column.HeaderText + ",");
                }

                // Add new line.
                csv.Append(Environment.NewLine);

                // Adding the Rows.
                foreach (DataGridViewRow row in dataGridCourse.Rows)
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
                string folderPath = "C:\\";
                string filePath = Path.Combine(folderPath, "Courses.csv");
                File.WriteAllText(filePath, csv.ToString());
                MessageBox.Show("The data has been exported to " + filePath, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHledat_Click(object sender, EventArgs e)
        {
            dataGridCourse.DataSource = course.searchCourse(txtBoxSearchStd.Text);
            txtBoxSearchStd.Clear();

        }
    }
}
