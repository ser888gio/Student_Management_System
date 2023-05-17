namespace SMS_Server
{
    partial class NewMark
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
            this.txtBoxStudentID = new System.Windows.Forms.TextBox();
            this.txtBoxMark = new System.Windows.Forms.TextBox();
            this.txtBoxCourseDesc = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblStudenID = new System.Windows.Forms.Label();
            this.dataGridStudenti = new System.Windows.Forms.DataGridView();
            this.cBoxPredmet = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnShowStd = new System.Windows.Forms.Button();
            this.btnShowMarks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(713, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(632, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxStudentID
            // 
            this.txtBoxStudentID.Location = new System.Drawing.Point(115, 343);
            this.txtBoxStudentID.Name = "txtBoxStudentID";
            this.txtBoxStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtBoxStudentID.TabIndex = 36;
            // 
            // txtBoxMark
            // 
            this.txtBoxMark.Location = new System.Drawing.Point(467, 349);
            this.txtBoxMark.Name = "txtBoxMark";
            this.txtBoxMark.Size = new System.Drawing.Size(100, 22);
            this.txtBoxMark.TabIndex = 35;
            // 
            // txtBoxCourseDesc
            // 
            this.txtBoxCourseDesc.Location = new System.Drawing.Point(467, 387);
            this.txtBoxCourseDesc.Name = "txtBoxCourseDesc";
            this.txtBoxCourseDesc.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCourseDesc.TabIndex = 34;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(386, 393);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 33;
            this.lblDescription.Text = "Description";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(417, 352);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(37, 16);
            this.lblMark.TabIndex = 32;
            this.lblMark.Text = "Mark";
            // 
            // lblStudenID
            // 
            this.lblStudenID.AutoSize = true;
            this.lblStudenID.Location = new System.Drawing.Point(31, 346);
            this.lblStudenID.Name = "lblStudenID";
            this.lblStudenID.Size = new System.Drawing.Size(68, 16);
            this.lblStudenID.TabIndex = 31;
            this.lblStudenID.Text = "Student ID";
            // 
            // dataGridStudenti
            // 
            this.dataGridStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudenti.Location = new System.Drawing.Point(12, 53);
            this.dataGridStudenti.Name = "dataGridStudenti";
            this.dataGridStudenti.RowHeadersWidth = 51;
            this.dataGridStudenti.RowTemplate.Height = 24;
            this.dataGridStudenti.Size = new System.Drawing.Size(776, 272);
            this.dataGridStudenti.TabIndex = 30;
            this.dataGridStudenti.Click += new System.EventHandler(this.dataGridStudenti_Click);
            // 
            // cBoxPredmet
            // 
            this.cBoxPredmet.FormattingEnabled = true;
            this.cBoxPredmet.Location = new System.Drawing.Point(94, 379);
            this.cBoxPredmet.Name = "cBoxPredmet";
            this.cBoxPredmet.Size = new System.Drawing.Size(121, 24);
            this.cBoxPredmet.TabIndex = 39;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(31, 385);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
            this.lblCourse.TabIndex = 40;
            this.lblCourse.Text = "Course";
            // 
            // btnShowStd
            // 
            this.btnShowStd.Location = new System.Drawing.Point(25, 24);
            this.btnShowStd.Name = "btnShowStd";
            this.btnShowStd.Size = new System.Drawing.Size(130, 23);
            this.btnShowStd.TabIndex = 44;
            this.btnShowStd.Text = "Show students";
            this.btnShowStd.UseVisualStyleBackColor = true;
            this.btnShowStd.Click += new System.EventHandler(this.btnZobrazStd_Click);
            // 
            // btnShowMarks
            // 
            this.btnShowMarks.Location = new System.Drawing.Point(655, 24);
            this.btnShowMarks.Name = "btnShowMarks";
            this.btnShowMarks.Size = new System.Drawing.Size(133, 23);
            this.btnShowMarks.TabIndex = 45;
            this.btnShowMarks.Text = "Show marks";
            this.btnShowMarks.UseVisualStyleBackColor = true;
            this.btnShowMarks.Click += new System.EventHandler(this.btnZobrazmarks_Click);
            // 
            // NewMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowMarks);
            this.Controls.Add(this.btnShowStd);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cBoxPredmet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxStudentID);
            this.Controls.Add(this.txtBoxMark);
            this.Controls.Add(this.txtBoxCourseDesc);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblStudenID);
            this.Controls.Add(this.dataGridStudenti);
            this.Name = "NewMark";
            this.Text = "NovaMark";
            this.Load += new System.EventHandler(this.NovaMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxStudentID;
        private System.Windows.Forms.TextBox txtBoxMark;
        private System.Windows.Forms.TextBox txtBoxCourseDesc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblStudenID;
        private System.Windows.Forms.DataGridView dataGridStudenti;
        private System.Windows.Forms.ComboBox cBoxPredmet;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnShowStd;
        private System.Windows.Forms.Button btnShowMarks;
    }
}