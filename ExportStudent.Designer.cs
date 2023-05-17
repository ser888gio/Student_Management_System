namespace SMS_Server
{
    partial class ExportStudent
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
            this.lblVyber = new System.Windows.Forms.Label();
            this.rBtnAll = new System.Windows.Forms.RadioButton();
            this.rBtnM = new System.Windows.Forms.RadioButton();
            this.rBtnF = new System.Windows.Forms.RadioButton();
            this.dataGridStudenti = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVyber
            // 
            this.lblVyber.AutoSize = true;
            this.lblVyber.Location = new System.Drawing.Point(23, 383);
            this.lblVyber.Name = "lblVyber";
            this.lblVyber.Size = new System.Drawing.Size(33, 16);
            this.lblVyber.TabIndex = 2;
            this.lblVyber.Text = "Pick";
            // 
            // rBtnAll
            // 
            this.rBtnAll.AutoSize = true;
            this.rBtnAll.Location = new System.Drawing.Point(72, 381);
            this.rBtnAll.Name = "rBtnAll";
            this.rBtnAll.Size = new System.Drawing.Size(43, 20);
            this.rBtnAll.TabIndex = 5;
            this.rBtnAll.TabStop = true;
            this.rBtnAll.Text = "All";
            this.rBtnAll.UseVisualStyleBackColor = true;
            // 
            // rBtnM
            // 
            this.rBtnM.AutoSize = true;
            this.rBtnM.Location = new System.Drawing.Point(133, 383);
            this.rBtnM.Name = "rBtnM";
            this.rBtnM.Size = new System.Drawing.Size(39, 20);
            this.rBtnM.TabIndex = 6;
            this.rBtnM.TabStop = true;
            this.rBtnM.Text = "M";
            this.rBtnM.UseVisualStyleBackColor = true;
            // 
            // rBtnF
            // 
            this.rBtnF.AutoSize = true;
            this.rBtnF.Location = new System.Drawing.Point(191, 383);
            this.rBtnF.Name = "rBtnF";
            this.rBtnF.Size = new System.Drawing.Size(36, 20);
            this.rBtnF.TabIndex = 7;
            this.rBtnF.TabStop = true;
            this.rBtnF.Text = "F";
            this.rBtnF.UseVisualStyleBackColor = true;
            // 
            // dataGridStudenti
            // 
            this.dataGridStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudenti.Location = new System.Drawing.Point(12, 28);
            this.dataGridStudenti.Name = "dataGridStudenti";
            this.dataGridStudenti.RowHeadersWidth = 51;
            this.dataGridStudenti.RowTemplate.Height = 24;
            this.dataGridStudenti.Size = new System.Drawing.Size(776, 272);
            this.dataGridStudenti.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(247, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 47);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(677, 347);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 52);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ExportStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridStudenti);
            this.Controls.Add(this.rBtnF);
            this.Controls.Add(this.rBtnM);
            this.Controls.Add(this.rBtnAll);
            this.Controls.Add(this.lblVyber);
            this.Name = "ExportStudent";
            this.Text = "PrintStudent";
            this.Load += new System.EventHandler(this.PrintStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVyber;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.RadioButton rBtnM;
        private System.Windows.Forms.RadioButton rBtnF;
        private System.Windows.Forms.DataGridView dataGridStudenti;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
    }
}