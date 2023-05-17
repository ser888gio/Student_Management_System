namespace SMS_Server
{
    partial class ManageMarksForm
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
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridCourse = new System.Windows.Forms.DataGridView();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.cBoxCourse = new System.Windows.Forms.ComboBox();
            this.txtBoxStudentID = new System.Windows.Forms.TextBox();
            this.txtBoxMark = new System.Windows.Forms.TextBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblStudenID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(581, 325);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSearch.TabIndex = 57;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(703, 324);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(703, 414);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(622, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridCourse
            // 
            this.dataGridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourse.Location = new System.Drawing.Point(15, 22);
            this.dataGridCourse.Name = "dataGridCourse";
            this.dataGridCourse.RowHeadersWidth = 51;
            this.dataGridCourse.RowTemplate.Height = 24;
            this.dataGridCourse.Size = new System.Drawing.Size(776, 272);
            this.dataGridCourse.TabIndex = 44;
            this.dataGridCourse.Click += new System.EventHandler(this.dataGridCourse_Click);
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Location = new System.Drawing.Point(12, 363);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(50, 16);
            this.lblPredmet.TabIndex = 67;
            this.lblPredmet.Text = "Course";
            // 
            // cBoxCourse
            // 
            this.cBoxCourse.FormattingEnabled = true;
            this.cBoxCourse.Location = new System.Drawing.Point(75, 357);
            this.cBoxCourse.Name = "cBoxCourse";
            this.cBoxCourse.Size = new System.Drawing.Size(121, 24);
            this.cBoxCourse.TabIndex = 66;
            // 
            // txtBoxStudentID
            // 
            this.txtBoxStudentID.Location = new System.Drawing.Point(96, 324);
            this.txtBoxStudentID.Name = "txtBoxStudentID";
            this.txtBoxStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtBoxStudentID.TabIndex = 63;
            // 
            // txtBoxMark
            // 
            this.txtBoxMark.Location = new System.Drawing.Point(444, 327);
            this.txtBoxMark.Name = "txtBoxMark";
            this.txtBoxMark.Size = new System.Drawing.Size(100, 22);
            this.txtBoxMark.TabIndex = 62;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(444, 362);
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDesc.TabIndex = 61;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(363, 365);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 16);
            this.lblDesc.TabIndex = 60;
            this.lblDesc.Text = "Description";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(401, 331);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(37, 16);
            this.lblMark.TabIndex = 59;
            this.lblMark.Text = "Mark";
            // 
            // lblStudenID
            // 
            this.lblStudenID.AutoSize = true;
            this.lblStudenID.Location = new System.Drawing.Point(12, 328);
            this.lblStudenID.Name = "lblStudenID";
            this.lblStudenID.Size = new System.Drawing.Size(68, 16);
            this.lblStudenID.TabIndex = 58;
            this.lblStudenID.Text = "Student ID";
            // 
            // ManageMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.cBoxCourse);
            this.Controls.Add(this.txtBoxStudentID);
            this.Controls.Add(this.txtBoxMark);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblStudenID);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridCourse);
            this.Name = "ManageMarksForm";
            this.Text = "ManagemarksForm";
            this.Load += new System.EventHandler(this.ManagemarksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridCourse;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.ComboBox cBoxCourse;
        private System.Windows.Forms.TextBox txtBoxStudentID;
        private System.Windows.Forms.TextBox txtBoxMark;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblStudenID;
    }
}