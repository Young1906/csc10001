
namespace PrdView_v2
{
    partial class Products
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_Prd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lv_prd = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeletecat = new System.Windows.Forms.Button();
            this.btnSearchcat = new System.Windows.Forms.Button();
            this.btnEditcat = new System.Windows.Forms.Button();
            this.btnAddcat = new System.Windows.Forms.Button();
            this.lv_cat = new System.Windows.Forms.ListView();
            this.btn_clear_search = new System.Windows.Forms.Button();
            this.tab_Prd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Prd
            // 
            this.tab_Prd.Controls.Add(this.tabPage1);
            this.tab_Prd.Controls.Add(this.tabPage2);
            this.tab_Prd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Prd.Location = new System.Drawing.Point(0, 0);
            this.tab_Prd.Name = "tab_Prd";
            this.tab_Prd.SelectedIndex = 0;
            this.tab_Prd.Size = new System.Drawing.Size(784, 561);
            this.tab_Prd.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lv_prd);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clear_search);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 30);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(248, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(167, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(86, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lv_prd
            // 
            this.lv_prd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_prd.HideSelection = false;
            this.lv_prd.Location = new System.Drawing.Point(3, 39);
            this.lv_prd.Name = "lv_prd";
            this.lv_prd.Size = new System.Drawing.Size(770, 491);
            this.lv_prd.TabIndex = 0;
            this.lv_prd.UseCompatibleStateImageBehavior = false;
            this.lv_prd.View = System.Windows.Forms.View.Details;
            this.lv_prd.SelectedIndexChanged += new System.EventHandler(this.lv_prd_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lv_cat);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categories";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeletecat);
            this.panel2.Controls.Add(this.btnSearchcat);
            this.panel2.Controls.Add(this.btnEditcat);
            this.panel2.Controls.Add(this.btnAddcat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 30);
            this.panel2.TabIndex = 3;
            // 
            // btnDeletecat
            // 
            this.btnDeletecat.Location = new System.Drawing.Point(248, 3);
            this.btnDeletecat.Name = "btnDeletecat";
            this.btnDeletecat.Size = new System.Drawing.Size(75, 23);
            this.btnDeletecat.TabIndex = 3;
            this.btnDeletecat.Text = "Delete";
            this.btnDeletecat.UseVisualStyleBackColor = true;
            this.btnDeletecat.Click += new System.EventHandler(this.btnDeletecat_Click);
            // 
            // btnSearchcat
            // 
            this.btnSearchcat.Location = new System.Drawing.Point(167, 3);
            this.btnSearchcat.Name = "btnSearchcat";
            this.btnSearchcat.Size = new System.Drawing.Size(75, 23);
            this.btnSearchcat.TabIndex = 2;
            this.btnSearchcat.Text = "Search";
            this.btnSearchcat.UseVisualStyleBackColor = true;
            // 
            // btnEditcat
            // 
            this.btnEditcat.Location = new System.Drawing.Point(86, 3);
            this.btnEditcat.Name = "btnEditcat";
            this.btnEditcat.Size = new System.Drawing.Size(75, 23);
            this.btnEditcat.TabIndex = 1;
            this.btnEditcat.Text = "Edit";
            this.btnEditcat.UseVisualStyleBackColor = true;
            this.btnEditcat.Click += new System.EventHandler(this.btnEditcat_Click);
            // 
            // btnAddcat
            // 
            this.btnAddcat.Location = new System.Drawing.Point(5, 3);
            this.btnAddcat.Name = "btnAddcat";
            this.btnAddcat.Size = new System.Drawing.Size(75, 23);
            this.btnAddcat.TabIndex = 0;
            this.btnAddcat.Text = "Add";
            this.btnAddcat.UseVisualStyleBackColor = true;
            this.btnAddcat.Click += new System.EventHandler(this.btnAddcat_Click);
            // 
            // lv_cat
            // 
            this.lv_cat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_cat.FullRowSelect = true;
            this.lv_cat.HideSelection = false;
            this.lv_cat.Location = new System.Drawing.Point(3, 39);
            this.lv_cat.Name = "lv_cat";
            this.lv_cat.Size = new System.Drawing.Size(770, 491);
            this.lv_cat.TabIndex = 2;
            this.lv_cat.UseCompatibleStateImageBehavior = false;
            this.lv_cat.View = System.Windows.Forms.View.Details;
            this.lv_cat.SelectedIndexChanged += new System.EventHandler(this.lv_cat_SelectedIndexChanged);
            // 
            // btn_clear_search
            // 
            this.btn_clear_search.Location = new System.Drawing.Point(662, 3);
            this.btn_clear_search.Name = "btn_clear_search";
            this.btn_clear_search.Size = new System.Drawing.Size(103, 23);
            this.btn_clear_search.TabIndex = 4;
            this.btn_clear_search.Text = "Clear Search";
            this.btn_clear_search.UseVisualStyleBackColor = true;
            this.btn_clear_search.Click += new System.EventHandler(this.btn_clear_search_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tab_Prd);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.tab_Prd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Prd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_prd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletecat;
        private System.Windows.Forms.Button btnSearchcat;
        private System.Windows.Forms.Button btnEditcat;
        private System.Windows.Forms.Button btnAddcat;
        private System.Windows.Forms.ListView lv_cat;
        private System.Windows.Forms.Button btn_clear_search;
    }
}

