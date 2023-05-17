namespace SMS_Server
{
    partial class ManageStudentForm
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
            this.dataGridStudenti = new System.Windows.Forms.DataGridView();
            this.panelSprStd = new System.Windows.Forms.Panel();
            this.txtBoxSearchStd = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rBttnGenderM = new System.Windows.Forms.RadioButton();
            this.rBttnGenderF = new System.Windows.Forms.RadioButton();
            this.dateTimeDB = new System.Windows.Forms.DateTimePicker();
            this.txtBoxFN = new System.Windows.Forms.TextBox();
            this.txtBoxlast_name = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblStdId = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblfirst_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
            this.panelSprStd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridStudenti
            // 
            this.dataGridStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudenti.Location = new System.Drawing.Point(12, 12);
            this.dataGridStudenti.Name = "dataGridStudenti";
            this.dataGridStudenti.RowHeadersWidth = 51;
            this.dataGridStudenti.RowTemplate.Height = 24;
            this.dataGridStudenti.Size = new System.Drawing.Size(776, 272);
            this.dataGridStudenti.TabIndex = 16;
            this.dataGridStudenti.Click += new System.EventHandler(this.dataGridStudenti_Click);
            // 
            // panelSprStd
            // 
            this.panelSprStd.Controls.Add(this.txtBoxSearchStd);
            this.panelSprStd.Controls.Add(this.btnClear);
            this.panelSprStd.Controls.Add(this.btnUpdate);
            this.panelSprStd.Controls.Add(this.btnDelete);
            this.panelSprStd.Controls.Add(this.btnSearch);
            this.panelSprStd.Controls.Add(this.rBttnGenderM);
            this.panelSprStd.Controls.Add(this.rBttnGenderF);
            this.panelSprStd.Controls.Add(this.dateTimeDB);
            this.panelSprStd.Controls.Add(this.txtBoxFN);
            this.panelSprStd.Controls.Add(this.txtBoxlast_name);
            this.panelSprStd.Controls.Add(this.txtBoxId);
            this.panelSprStd.Controls.Add(this.lblDB);
            this.panelSprStd.Controls.Add(this.lblStdId);
            this.panelSprStd.Controls.Add(this.lblSurname);
            this.panelSprStd.Controls.Add(this.lblGender);
            this.panelSprStd.Controls.Add(this.lblfirst_name);
            this.panelSprStd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSprStd.Location = new System.Drawing.Point(0, 290);
            this.panelSprStd.Name = "panelSprStd";
            this.panelSprStd.Size = new System.Drawing.Size(800, 160);
            this.panelSprStd.TabIndex = 17;
            // 
            // txtBoxSearchStd
            // 
            this.txtBoxSearchStd.Location = new System.Drawing.Point(580, 4);
            this.txtBoxSearchStd.Name = "txtBoxSearchStd";
            this.txtBoxSearchStd.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSearchStd.TabIndex = 31;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(551, 117);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(632, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(702, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rBttnGenderM
            // 
            this.rBttnGenderM.AutoSize = true;
            this.rBttnGenderM.Location = new System.Drawing.Point(156, 79);
            this.rBttnGenderM.Name = "rBttnGenderM";
            this.rBttnGenderM.Size = new System.Drawing.Size(39, 20);
            this.rBttnGenderM.TabIndex = 26;
            this.rBttnGenderM.TabStop = true;
            this.rBttnGenderM.Text = "M";
            this.rBttnGenderM.UseVisualStyleBackColor = true;
            // 
            // rBttnGenderF
            // 
            this.rBttnGenderF.AutoSize = true;
            this.rBttnGenderF.Location = new System.Drawing.Point(105, 79);
            this.rBttnGenderF.Name = "rBttnGenderF";
            this.rBttnGenderF.Size = new System.Drawing.Size(36, 20);
            this.rBttnGenderF.TabIndex = 25;
            this.rBttnGenderF.TabStop = true;
            this.rBttnGenderF.Text = "F";
            this.rBttnGenderF.UseVisualStyleBackColor = true;
            // 
            // dateTimeDB
            // 
            this.dateTimeDB.Location = new System.Drawing.Point(556, 46);
            this.dateTimeDB.Name = "dateTimeDB";
            this.dateTimeDB.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDB.TabIndex = 24;
            // 
            // txtBoxFN
            // 
            this.txtBoxFN.Location = new System.Drawing.Point(97, 20);
            this.txtBoxFN.Name = "txtBoxFN";
            this.txtBoxFN.Size = new System.Drawing.Size(100, 22);
            this.txtBoxFN.TabIndex = 23;
            // 
            // txtBoxlast_name
            // 
            this.txtBoxlast_name.Location = new System.Drawing.Point(304, 20);
            this.txtBoxlast_name.Name = "txtBoxlast_name";
            this.txtBoxlast_name.Size = new System.Drawing.Size(100, 22);
            this.txtBoxlast_name.TabIndex = 22;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(304, 77);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 22);
            this.txtBoxId.TabIndex = 21;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(471, 46);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(79, 16);
            this.lblDB.TabIndex = 20;
            this.lblDB.Text = "Date of Birth";
            // 
            // lblStdId
            // 
            this.lblStdId.AutoSize = true;
            this.lblStdId.Location = new System.Drawing.Point(278, 80);
            this.lblStdId.Name = "lblStdId";
            this.lblStdId.Size = new System.Drawing.Size(20, 16);
            this.lblStdId.TabIndex = 19;
            this.lblStdId.Text = "ID";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(244, 23);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(47, 81);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender";
            // 
            // lblfirst_name
            // 
            this.lblfirst_name.AutoSize = true;
            this.lblfirst_name.Location = new System.Drawing.Point(27, 23);
            this.lblfirst_name.Name = "lblfirst_name";
            this.lblfirst_name.Size = new System.Drawing.Size(72, 16);
            this.lblfirst_name.TabIndex = 16;
            this.lblfirst_name.Text = "First Name";
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSprStd);
            this.Controls.Add(this.dataGridStudenti);
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            this.panelSprStd.ResumeLayout(false);
            this.panelSprStd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridStudenti;
        private System.Windows.Forms.Panel panelSprStd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rBttnGenderM;
        private System.Windows.Forms.RadioButton rBttnGenderF;
        private System.Windows.Forms.DateTimePicker dateTimeDB;
        private System.Windows.Forms.TextBox txtBoxFN;
        private System.Windows.Forms.TextBox txtBoxlast_name;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblStdId;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblfirst_name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxSearchStd;
    }
}