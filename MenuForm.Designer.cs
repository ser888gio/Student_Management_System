namespace SMS_Server
{
    partial class MenuForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelmarks = new System.Windows.Forms.Panel();
            this.btnExportMarks = new System.Windows.Forms.Button();
            this.btnManageMarks = new System.Windows.Forms.Button();
            this.btnNewMark = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.btnExportCourse = new System.Windows.Forms.Button();
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnNewCourse = new System.Windows.Forms.Button();
            this.btnPredmet = new System.Windows.Forms.Button();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.button_students = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblGirlsCount = new System.Windows.Forms.Label();
            this.lblBoysCount = new System.Windows.Forms.Label();
            this.lblStdCount = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.panelmarks.SuspendLayout();
            this.panelCourses.SuspendLayout();
            this.panelStudents.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuPanel.Controls.Add(this.btnHome);
            this.MenuPanel.Controls.Add(this.panelmarks);
            this.MenuPanel.Controls.Add(this.btnMarks);
            this.MenuPanel.Controls.Add(this.panelCourses);
            this.MenuPanel.Controls.Add(this.btnPredmet);
            this.MenuPanel.Controls.Add(this.panelStudents);
            this.MenuPanel.Controls.Add(this.button_students);
            this.MenuPanel.Controls.Add(this.panelLogo);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(134, 586);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 509);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 47);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelmarks
            // 
            this.panelmarks.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelmarks.Controls.Add(this.btnExportMarks);
            this.panelmarks.Controls.Add(this.btnManageMarks);
            this.panelmarks.Controls.Add(this.btnNewMark);
            this.panelmarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmarks.Location = new System.Drawing.Point(0, 416);
            this.panelmarks.Name = "panelmarks";
            this.panelmarks.Size = new System.Drawing.Size(134, 93);
            this.panelmarks.TabIndex = 5;
            // 
            // btnExportMarks
            // 
            this.btnExportMarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportMarks.FlatAppearance.BorderSize = 0;
            this.btnExportMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportMarks.ForeColor = System.Drawing.Color.White;
            this.btnExportMarks.Location = new System.Drawing.Point(0, 46);
            this.btnExportMarks.Name = "btnExportMarks";
            this.btnExportMarks.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExportMarks.Size = new System.Drawing.Size(134, 23);
            this.btnExportMarks.TabIndex = 4;
            this.btnExportMarks.Text = "Export";
            this.btnExportMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportMarks.UseVisualStyleBackColor = true;
            this.btnExportMarks.Click += new System.EventHandler(this.btnExportMarks_Click);
            // 
            // btnManageMarks
            // 
            this.btnManageMarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMarks.FlatAppearance.BorderSize = 0;
            this.btnManageMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMarks.ForeColor = System.Drawing.Color.White;
            this.btnManageMarks.Location = new System.Drawing.Point(0, 23);
            this.btnManageMarks.Name = "btnManageMarks";
            this.btnManageMarks.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManageMarks.Size = new System.Drawing.Size(134, 23);
            this.btnManageMarks.TabIndex = 2;
            this.btnManageMarks.Text = "Manage marks";
            this.btnManageMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMarks.UseVisualStyleBackColor = true;
            this.btnManageMarks.Click += new System.EventHandler(this.btnManageMarks_Click);
            // 
            // btnNewMark
            // 
            this.btnNewMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewMark.FlatAppearance.BorderSize = 0;
            this.btnNewMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMark.ForeColor = System.Drawing.Color.White;
            this.btnNewMark.Location = new System.Drawing.Point(0, 0);
            this.btnNewMark.Name = "btnNewMark";
            this.btnNewMark.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewMark.Size = new System.Drawing.Size(134, 23);
            this.btnNewMark.TabIndex = 1;
            this.btnNewMark.Text = "New mark";
            this.btnNewMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMark.UseVisualStyleBackColor = true;
            this.btnNewMark.Click += new System.EventHandler(this.btnNewMark_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarks.FlatAppearance.BorderSize = 0;
            this.btnMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarks.ForeColor = System.Drawing.Color.White;
            this.btnMarks.Location = new System.Drawing.Point(0, 360);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMarks.Size = new System.Drawing.Size(134, 56);
            this.btnMarks.TabIndex = 4;
            this.btnMarks.Text = "Marks";
            this.btnMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // panelCourses
            // 
            this.panelCourses.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelCourses.Controls.Add(this.btnExportCourse);
            this.panelCourses.Controls.Add(this.btnManageCourse);
            this.panelCourses.Controls.Add(this.btnNewCourse);
            this.panelCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCourses.Location = new System.Drawing.Point(0, 267);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(134, 93);
            this.panelCourses.TabIndex = 3;
            // 
            // btnExportCourse
            // 
            this.btnExportCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportCourse.FlatAppearance.BorderSize = 0;
            this.btnExportCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCourse.ForeColor = System.Drawing.Color.White;
            this.btnExportCourse.Location = new System.Drawing.Point(0, 46);
            this.btnExportCourse.Name = "btnExportCourse";
            this.btnExportCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExportCourse.Size = new System.Drawing.Size(134, 23);
            this.btnExportCourse.TabIndex = 4;
            this.btnExportCourse.Text = "Export";
            this.btnExportCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportCourse.UseVisualStyleBackColor = true;
            this.btnExportCourse.Click += new System.EventHandler(this.btnExportPr_Click);
            // 
            // btnManageCourse
            // 
            this.btnManageCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCourse.FlatAppearance.BorderSize = 0;
            this.btnManageCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCourse.ForeColor = System.Drawing.Color.White;
            this.btnManageCourse.Location = new System.Drawing.Point(0, 23);
            this.btnManageCourse.Name = "btnManageCourse";
            this.btnManageCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManageCourse.Size = new System.Drawing.Size(134, 23);
            this.btnManageCourse.TabIndex = 2;
            this.btnManageCourse.Text = "Manage course";
            this.btnManageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCourse.UseVisualStyleBackColor = true;
            this.btnManageCourse.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewCourse.FlatAppearance.BorderSize = 0;
            this.btnNewCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCourse.ForeColor = System.Drawing.Color.White;
            this.btnNewCourse.Location = new System.Drawing.Point(0, 0);
            this.btnNewCourse.Name = "btnNewCourse";
            this.btnNewCourse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewCourse.Size = new System.Drawing.Size(134, 23);
            this.btnNewCourse.TabIndex = 1;
            this.btnNewCourse.Text = "New course";
            this.btnNewCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCourse.UseVisualStyleBackColor = true;
            this.btnNewCourse.Click += new System.EventHandler(this.btnNewCourse_Click);
            // 
            // btnPredmet
            // 
            this.btnPredmet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPredmet.FlatAppearance.BorderSize = 0;
            this.btnPredmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredmet.ForeColor = System.Drawing.Color.White;
            this.btnPredmet.Location = new System.Drawing.Point(0, 211);
            this.btnPredmet.Name = "btnPredmet";
            this.btnPredmet.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPredmet.Size = new System.Drawing.Size(134, 56);
            this.btnPredmet.TabIndex = 2;
            this.btnPredmet.Text = "Course";
            this.btnPredmet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredmet.UseVisualStyleBackColor = true;
            this.btnPredmet.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // panelStudents
            // 
            this.panelStudents.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelStudents.Controls.Add(this.btnExport);
            this.panelStudents.Controls.Add(this.btnManageStudents);
            this.panelStudents.Controls.Add(this.btnNewStudent);
            this.panelStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudents.Location = new System.Drawing.Point(0, 124);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(134, 87);
            this.panelStudents.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(0, 52);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(134, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStudents.FlatAppearance.BorderSize = 0;
            this.btnManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudents.ForeColor = System.Drawing.Color.White;
            this.btnManageStudents.Location = new System.Drawing.Point(0, 29);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManageStudents.Size = new System.Drawing.Size(134, 23);
            this.btnManageStudents.TabIndex = 2;
            this.btnManageStudents.Text = "Manage students";
            this.btnManageStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudentu_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewStudent.FlatAppearance.BorderSize = 0;
            this.btnNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnNewStudent.Location = new System.Drawing.Point(0, 0);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewStudent.Size = new System.Drawing.Size(134, 29);
            this.btnNewStudent.TabIndex = 1;
            this.btnNewStudent.Text = "New student";
            this.btnNewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnRegistrace_Click);
            // 
            // button_students
            // 
            this.button_students.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_students.FlatAppearance.BorderSize = 0;
            this.button_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_students.ForeColor = System.Drawing.Color.White;
            this.button_students.Location = new System.Drawing.Point(0, 68);
            this.button_students.Name = "button_students";
            this.button_students.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_students.Size = new System.Drawing.Size(134, 56);
            this.button_students.TabIndex = 1;
            this.button_students.Text = "Students";
            this.button_students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_students.UseVisualStyleBackColor = true;
            this.button_students.Click += new System.EventHandler(this.button_students_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(134, 68);
            this.panelLogo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Škola C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "C#";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.lblGirlsCount);
            this.panelMenu.Controls.Add(this.lblBoysCount);
            this.panelMenu.Controls.Add(this.lblStdCount);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(134, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(722, 586);
            this.panelMenu.TabIndex = 3;
            // 
            // lblGirlsCount
            // 
            this.lblGirlsCount.AutoSize = true;
            this.lblGirlsCount.Location = new System.Drawing.Point(397, 475);
            this.lblGirlsCount.Name = "lblGirlsCount";
            this.lblGirlsCount.Size = new System.Drawing.Size(69, 16);
            this.lblGirlsCount.TabIndex = 5;
            this.lblGirlsCount.Text = "Girls count";
            // 
            // lblBoysCount
            // 
            this.lblBoysCount.AutoSize = true;
            this.lblBoysCount.Location = new System.Drawing.Point(221, 475);
            this.lblBoysCount.Name = "lblBoysCount";
            this.lblBoysCount.Size = new System.Drawing.Size(73, 16);
            this.lblBoysCount.TabIndex = 4;
            this.lblBoysCount.Text = "Boys count";
            // 
            // lblStdCount
            // 
            this.lblStdCount.AutoSize = true;
            this.lblStdCount.Location = new System.Drawing.Point(41, 475);
            this.lblStdCount.Name = "lblStdCount";
            this.lblStdCount.Size = new System.Drawing.Size(94, 16);
            this.lblStdCount.TabIndex = 3;
            this.lblStdCount.Text = "Students count";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 586);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panelmarks.ResumeLayout(false);
            this.panelCourses.ResumeLayout(false);
            this.panelStudents.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel panelmarks;
        private System.Windows.Forms.Button btnExportMarks;
        private System.Windows.Forms.Button btnManageMarks;
        private System.Windows.Forms.Button btnNewMark;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Panel panelCourses;
        private System.Windows.Forms.Button btnExportCourse;
        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.Button btnPredmet;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button button_students;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblGirlsCount;
        private System.Windows.Forms.Label lblBoysCount;
        private System.Windows.Forms.Label lblStdCount;
    }
}

