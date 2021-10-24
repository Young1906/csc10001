
namespace PrdView_v2
{
    partial class search_form
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
            this.nmr_Year = new System.Windows.Forms.NumericUpDown();
            this.cbb_Cate = new System.Windows.Forms.ComboBox();
            this.txb_company = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.rbt_Name = new System.Windows.Forms.RadioButton();
            this.rbt_Cate = new System.Windows.Forms.RadioButton();
            this.rbt_Company = new System.Windows.Forms.RadioButton();
            this.rbt_Year = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmr_Year
            // 
            this.nmr_Year.Location = new System.Drawing.Point(161, 105);
            this.nmr_Year.Name = "nmr_Year";
            this.nmr_Year.Size = new System.Drawing.Size(240, 23);
            this.nmr_Year.TabIndex = 24;
            // 
            // cbb_Cate
            // 
            this.cbb_Cate.FormattingEnabled = true;
            this.cbb_Cate.Location = new System.Drawing.Point(161, 41);
            this.cbb_Cate.Name = "cbb_Cate";
            this.cbb_Cate.Size = new System.Drawing.Size(240, 23);
            this.cbb_Cate.TabIndex = 23;
            // 
            // txb_company
            // 
            this.txb_company.Location = new System.Drawing.Point(161, 73);
            this.txb_company.Name = "txb_company";
            this.txb_company.Size = new System.Drawing.Size(240, 23);
            this.txb_company.TabIndex = 18;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(161, 9);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(240, 23);
            this.txb_Name.TabIndex = 15;
            // 
            // rbt_Name
            // 
            this.rbt_Name.AutoSize = true;
            this.rbt_Name.Location = new System.Drawing.Point(21, 10);
            this.rbt_Name.Name = "rbt_Name";
            this.rbt_Name.Size = new System.Drawing.Size(57, 19);
            this.rbt_Name.TabIndex = 25;
            this.rbt_Name.TabStop = true;
            this.rbt_Name.Text = "Name";
            this.rbt_Name.UseVisualStyleBackColor = true;
            // 
            // rbt_Cate
            // 
            this.rbt_Cate.AutoSize = true;
            this.rbt_Cate.Location = new System.Drawing.Point(21, 42);
            this.rbt_Cate.Name = "rbt_Cate";
            this.rbt_Cate.Size = new System.Drawing.Size(73, 19);
            this.rbt_Cate.TabIndex = 26;
            this.rbt_Cate.TabStop = true;
            this.rbt_Cate.Text = "Category";
            this.rbt_Cate.UseVisualStyleBackColor = true;
            // 
            // rbt_Company
            // 
            this.rbt_Company.AutoSize = true;
            this.rbt_Company.Location = new System.Drawing.Point(21, 74);
            this.rbt_Company.Name = "rbt_Company";
            this.rbt_Company.Size = new System.Drawing.Size(77, 19);
            this.rbt_Company.TabIndex = 27;
            this.rbt_Company.TabStop = true;
            this.rbt_Company.Text = "Company";
            this.rbt_Company.UseVisualStyleBackColor = true;
            // 
            // rbt_Year
            // 
            this.rbt_Year.AutoSize = true;
            this.rbt_Year.Location = new System.Drawing.Point(21, 105);
            this.rbt_Year.Name = "rbt_Year";
            this.rbt_Year.Size = new System.Drawing.Size(47, 19);
            this.rbt_Year.TabIndex = 29;
            this.rbt_Year.TabStop = true;
            this.rbt_Year.Text = "Year";
            this.rbt_Year.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(326, 158);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 192);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.rbt_Year);
            this.Controls.Add(this.rbt_Company);
            this.Controls.Add(this.rbt_Cate);
            this.Controls.Add(this.rbt_Name);
            this.Controls.Add(this.nmr_Year);
            this.Controls.Add(this.cbb_Cate);
            this.Controls.Add(this.txb_company);
            this.Controls.Add(this.txb_Name);
            this.Name = "search_form";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmr_Year;
        private System.Windows.Forms.ComboBox cbb_Cate;
        private System.Windows.Forms.TextBox txb_company;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.RadioButton rbt_Name;
        private System.Windows.Forms.RadioButton rbt_Cate;
        private System.Windows.Forms.RadioButton rbt_Company;
        private System.Windows.Forms.RadioButton rbt_Year;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}