namespace SMS_Server
{
    partial class ManageCourseForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxCourseName = new System.Windows.Forms.TextBox();
            this.txtBoxCourseHour = new System.Windows.Forms.TextBox();
            this.txtBoxCourseDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.dataGridCourse = new System.Windows.Forms.DataGridView();
            this.txtBoxCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(668, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(578, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxCourseName
            // 
            this.txtBoxCourseName.Location = new System.Drawing.Point(107, 318);
            this.txtBoxCourseName.Name = "txtBoxCourseName";
            this.txtBoxCourseName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseName.TabIndex = 36;
            // 
            // txtBoxCourseHour
            // 
            this.txtBoxCourseHour.Location = new System.Drawing.Point(314, 318);
            this.txtBoxCourseHour.Name = "txtBoxCourseHour";
            this.txtBoxCourseHour.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseHour.TabIndex = 35;
            // 
            // txtBoxCourseDesc
            // 
            this.txtBoxCourseDesc.Location = new System.Drawing.Point(107, 376);
            this.txtBoxCourseDesc.Name = "txtBoxCourseDesc";
            this.txtBoxCourseDesc.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseDesc.TabIndex = 34;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(32, 376);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 16);
            this.lblDesc.TabIndex = 33;
            this.lblDesc.Text = "Description";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(254, 321);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(36, 16);
            this.lblHour.TabIndex = 32;
            this.lblHour.Text = "Hour";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(57, 321);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
            this.lblCourse.TabIndex = 31;
            this.lblCourse.Text = "Course";
            // 
            // dataGridCourse
            // 
            this.dataGridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourse.Location = new System.Drawing.Point(12, 12);
            this.dataGridCourse.Name = "dataGridCourse";
            this.dataGridCourse.RowHeadersWidth = 51;
            this.dataGridCourse.RowTemplate.Height = 24;
            this.dataGridCourse.Size = new System.Drawing.Size(776, 272);
            this.dataGridCourse.TabIndex = 30;
            this.dataGridCourse.Click += new System.EventHandler(this.dataGridCourse_Click);
            // 
            // txtBoxCourseID
            // 
            this.txtBoxCourseID.Location = new System.Drawing.Point(326, 376);
            this.txtBoxCourseID.Name = "txtBoxCourseID";
            this.txtBoxCourseID.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseID.TabIndex = 40;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(254, 376);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(66, 16);
            this.lblCourseID.TabIndex = 39;
            this.lblCourseID.Text = "Course ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(578, 315);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSearch.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(700, 314);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxCourseID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxCourseName);
            this.Controls.Add(this.txtBoxCourseHour);
            this.Controls.Add(this.txtBoxCourseDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.dataGridCourse);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourserForm";
            this.Load += new System.EventHandler(this.ManageCourserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxCourseName;
        private System.Windows.Forms.TextBox txtBoxCourseHour;
        private System.Windows.Forms.TextBox txtBoxCourseDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.DataGridView dataGridCourse;
        private System.Windows.Forms.TextBox txtBoxCourseID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}