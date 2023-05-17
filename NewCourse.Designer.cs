namespace SMS_Server
{
    partial class NewCourse
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxCourseName = new System.Windows.Forms.TextBox();
            this.txtBoxCourseHour = new System.Windows.Forms.TextBox();
            this.txtBoxCourseDesc = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.dataGridCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(675, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(585, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxCourseName
            // 
            this.txtBoxCourseName.Location = new System.Drawing.Point(120, 322);
            this.txtBoxCourseName.Name = "txtBoxCourseName";
            this.txtBoxCourseName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseName.TabIndex = 24;
            // 
            // txtBoxCourseHour
            // 
            this.txtBoxCourseHour.Location = new System.Drawing.Point(303, 319);
            this.txtBoxCourseHour.Name = "txtBoxCourseHour";
            this.txtBoxCourseHour.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseHour.TabIndex = 23;
            // 
            // txtBoxCourseDesc
            // 
            this.txtBoxCourseDesc.Location = new System.Drawing.Point(120, 377);
            this.txtBoxCourseDesc.Name = "txtBoxCourseDesc";
            this.txtBoxCourseDesc.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseDesc.TabIndex = 22;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(39, 377);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(261, 322);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(36, 16);
            this.lblHour.TabIndex = 19;
            this.lblHour.Text = "Hour";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(64, 322);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
            this.lblCourse.TabIndex = 17;
            this.lblCourse.Text = "Course";
            // 
            // dataGridCourse
            // 
            this.dataGridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourse.Location = new System.Drawing.Point(19, 13);
            this.dataGridCourse.Name = "dataGridCourse";
            this.dataGridCourse.RowHeadersWidth = 51;
            this.dataGridCourse.RowTemplate.Height = 24;
            this.dataGridCourse.Size = new System.Drawing.Size(776, 272);
            this.dataGridCourse.TabIndex = 16;
            // 
            // NewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxCourseName);
            this.Controls.Add(this.txtBoxCourseHour);
            this.Controls.Add(this.txtBoxCourseDesc);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.dataGridCourse);
            this.Name = "NewCourse";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxCourseName;
        private System.Windows.Forms.TextBox txtBoxCourseHour;
        private System.Windows.Forms.TextBox txtBoxCourseDesc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.DataGridView dataGridCourse;
    }
}