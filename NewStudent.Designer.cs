namespace SMS_Server
{
    partial class NewStudent
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
            this.lblFN = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.txtBoxlast_name = new System.Windows.Forms.TextBox();
            this.txtBoxfirst_name = new System.Windows.Forms.TextBox();
            this.dateTimeDB = new System.Windows.Forms.DateTimePicker();
            this.rBttnGenderF = new System.Windows.Forms.RadioButton();
            this.rBttnGenderM = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bttnImportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
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
            this.dataGridStudenti.TabIndex = 0;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(29, 318);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(72, 16);
            this.lblFN.TabIndex = 1;
            this.lblFN.Text = "First Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(57, 379);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(236, 321);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(72, 16);
            this.lblLN.TabIndex = 3;
            this.lblLN.Text = "Last Name";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(479, 321);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(78, 16);
            this.lblDB.TabIndex = 5;
            this.lblDB.Text = "Date of birth";
            // 
            // txtBoxlast_name
            // 
            this.txtBoxlast_name.Location = new System.Drawing.Point(314, 318);
            this.txtBoxlast_name.Name = "txtBoxlast_name";
            this.txtBoxlast_name.Size = new System.Drawing.Size(100, 22);
            this.txtBoxlast_name.TabIndex = 9;
            // 
            // txtBoxfirst_name
            // 
            this.txtBoxfirst_name.Location = new System.Drawing.Point(107, 318);
            this.txtBoxfirst_name.Name = "txtBoxfirst_name";
            this.txtBoxfirst_name.Size = new System.Drawing.Size(100, 22);
            this.txtBoxfirst_name.TabIndex = 10;
            // 
            // dateTimeDB
            // 
            this.dateTimeDB.Location = new System.Drawing.Point(563, 318);
            this.dateTimeDB.Name = "dateTimeDB";
            this.dateTimeDB.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDB.TabIndex = 11;
            // 
            // rBttnGenderF
            // 
            this.rBttnGenderF.AutoSize = true;
            this.rBttnGenderF.Location = new System.Drawing.Point(115, 377);
            this.rBttnGenderF.Name = "rBttnGenderF";
            this.rBttnGenderF.Size = new System.Drawing.Size(36, 20);
            this.rBttnGenderF.TabIndex = 12;
            this.rBttnGenderF.TabStop = true;
            this.rBttnGenderF.Text = "F";
            this.rBttnGenderF.UseVisualStyleBackColor = true;
            // 
            // rBttnGenderM
            // 
            this.rBttnGenderM.AutoSize = true;
            this.rBttnGenderM.Location = new System.Drawing.Point(166, 377);
            this.rBttnGenderM.Name = "rBttnGenderM";
            this.rBttnGenderM.Size = new System.Drawing.Size(39, 20);
            this.rBttnGenderM.TabIndex = 13;
            this.rBttnGenderM.TabStop = true;
            this.rBttnGenderM.Text = "M";
            this.rBttnGenderM.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(600, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(690, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bttnImportCSV
            // 
            this.bttnImportCSV.Location = new System.Drawing.Point(482, 415);
            this.bttnImportCSV.Name = "bttnImportCSV";
            this.bttnImportCSV.Size = new System.Drawing.Size(112, 23);
            this.bttnImportCSV.TabIndex = 16;
            this.bttnImportCSV.Text = "Import CSV";
            this.bttnImportCSV.UseVisualStyleBackColor = true;
            this.bttnImportCSV.Click += new System.EventHandler(this.bttnImportCSV_Click);
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnImportCSV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rBttnGenderM);
            this.Controls.Add(this.rBttnGenderF);
            this.Controls.Add(this.dateTimeDB);
            this.Controls.Add(this.txtBoxfirst_name);
            this.Controls.Add(this.txtBoxlast_name);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.dataGridStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewStudent";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStudenti;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.TextBox txtBoxlast_name;
        private System.Windows.Forms.TextBox txtBoxfirst_name;
        private System.Windows.Forms.DateTimePicker dateTimeDB;
        private System.Windows.Forms.RadioButton rBttnGenderF;
        private System.Windows.Forms.RadioButton rBttnGenderM;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bttnImportCSV;
    }
}