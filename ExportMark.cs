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
    public partial class ExportMark : Form
    {
        MarkClass mark = new MarkClass();
        public ExportMark()
        {
            InitializeComponent();
        }

        private void btnHledat_Click(object sender, EventArgs e)
        {
            dataGridMark.DataSource = mark.searchMark(txtBoxSearch.Text);
            txtBoxSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Build the CSV file data as a Comma separated string.
                StringBuilder csv = new StringBuilder();

                // Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dataGridMark.Columns)
                {
                    csv.Append(column.HeaderText + ",");
                }

                // Add new line.
                csv.Append(Environment.NewLine);

                // Adding the Rows.
                foreach (DataGridViewRow row in dataGridMark.Rows)
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
                string filePath = Path.Combine(folderPath, "Marks.csv");
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
