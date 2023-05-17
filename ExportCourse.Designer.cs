namespace SMS_Server
{
    partial class ExportCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridCourse = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchStd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(686, 399);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(569, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnHledat_Click);
            // 
            // dataGridCourse
            // 
            this.dataGridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourse.Location = new System.Drawing.Point(12, 73);
            this.dataGridCourse.Name = "dataGridCourse";
            this.dataGridCourse.RowHeadersWidth = 51;
            this.dataGridCourse.RowTemplate.Height = 24;
            this.dataGridCourse.Size = new System.Drawing.Size(776, 272);
            this.dataGridCourse.TabIndex = 26;
            // 
            // txtBoxSearchStd
            // 
            this.txtBoxSearchStd.Location = new System.Drawing.Point(661, 29);
            this.txtBoxSearchStd.Name = "txtBoxSearchStd";
            this.txtBoxSearchStd.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSearchStd.TabIndex = 29;
            // 
            // ExportCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 442);
            this.Controls.Add(this.txtBoxSearchStd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridCourse);
            this.Name = "ExportCourse";
            this.Text = "ExportCourse";
            this.Load += new System.EventHandler(this.ExportCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridCourse;
        private System.Windows.Forms.TextBox txtBoxSearchStd;
    }
}