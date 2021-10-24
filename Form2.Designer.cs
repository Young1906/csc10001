
namespace PrdView_v2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labCat = new System.Windows.Forms.Label();
            this.lab_company = new System.Windows.Forms.Label();
            this.txb_company = new System.Windows.Forms.TextBox();
            this.labExpiration = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.dpk_Exp = new System.Windows.Forms.DateTimePicker();
            this.cbb_Cate = new System.Windows.Forms.ComboBox();
            this.nmr_Year = new System.Windows.Forms.NumericUpDown();
            this.btn_Final = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(133, 6);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(240, 23);
            this.txb_Name.TabIndex = 0;
            this.txb_Name.Validated += new System.EventHandler(this.Validate_Combobox);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(12, 9);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(39, 15);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name";
            // 
            // labCat
            // 
            this.labCat.AutoSize = true;
            this.labCat.Location = new System.Drawing.Point(12, 38);
            this.labCat.Name = "labCat";
            this.labCat.Size = new System.Drawing.Size(55, 15);
            this.labCat.TabIndex = 3;
            this.labCat.Text = "Category";
            // 
            // lab_company
            // 
            this.lab_company.AutoSize = true;
            this.lab_company.Location = new System.Drawing.Point(12, 67);
            this.lab_company.Name = "lab_company";
            this.lab_company.Size = new System.Drawing.Size(59, 15);
            this.lab_company.TabIndex = 5;
            this.lab_company.Text = "Company";
            // 
            // txb_company
            // 
            this.txb_company.Location = new System.Drawing.Point(133, 64);
            this.txb_company.Name = "txb_company";
            this.txb_company.Size = new System.Drawing.Size(240, 23);
            this.txb_company.TabIndex = 4;
            this.txb_company.Validated += new System.EventHandler(this.Validate_Combobox);
            // 
            // labExpiration
            // 
            this.labExpiration.AutoSize = true;
            this.labExpiration.Location = new System.Drawing.Point(12, 96);
            this.labExpiration.Name = "labExpiration";
            this.labExpiration.Size = new System.Drawing.Size(60, 15);
            this.labExpiration.TabIndex = 7;
            this.labExpiration.Text = "Expiration";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(12, 125);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 15);
            this.Year.TabIndex = 9;
            this.Year.Text = "Year";
            // 
            // dpk_Exp
            // 
            this.dpk_Exp.Location = new System.Drawing.Point(133, 93);
            this.dpk_Exp.Name = "dpk_Exp";
            this.dpk_Exp.Size = new System.Drawing.Size(240, 23);
            this.dpk_Exp.TabIndex = 10;
            // 
            // cbb_Cate
            // 
            this.cbb_Cate.FormattingEnabled = true;
            this.cbb_Cate.Location = new System.Drawing.Point(133, 35);
            this.cbb_Cate.Name = "cbb_Cate";
            this.cbb_Cate.Size = new System.Drawing.Size(240, 23);
            this.cbb_Cate.TabIndex = 11;
            this.cbb_Cate.Validated += new System.EventHandler(this.Validate_Combobox);
            // 
            // nmr_Year
            // 
            this.nmr_Year.Location = new System.Drawing.Point(133, 123);
            this.nmr_Year.Name = "nmr_Year";
            this.nmr_Year.Size = new System.Drawing.Size(240, 23);
            this.nmr_Year.TabIndex = 12;
            // 
            // btn_Final
            // 
            this.btn_Final.Enabled = false;
            this.btn_Final.Location = new System.Drawing.Point(208, 201);
            this.btn_Final.Name = "btn_Final";
            this.btn_Final.Size = new System.Drawing.Size(82, 23);
            this.btn_Final.TabIndex = 13;
            this.btn_Final.Text = "button1";
            this.btn_Final.UseVisualStyleBackColor = true;
            this.btn_Final.Click += new System.EventHandler(this.btn_Final_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(296, 201);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Final);
            this.Controls.Add(this.nmr_Year);
            this.Controls.Add(this.cbb_Cate);
            this.Controls.Add(this.dpk_Exp);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.labExpiration);
            this.Controls.Add(this.lab_company);
            this.Controls.Add(this.txb_company);
            this.Controls.Add(this.labCat);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txb_Name);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCat;
        private System.Windows.Forms.Label lab_company;
        private System.Windows.Forms.TextBox txb_company;
        private System.Windows.Forms.Label labExpiration;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.DateTimePicker dpk_Exp;
        private System.Windows.Forms.ComboBox cbb_Cate;
        private System.Windows.Forms.NumericUpDown nmr_Year;
        private System.Windows.Forms.Button btn_Final;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}