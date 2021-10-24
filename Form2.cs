using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrdView_v2
{
    public partial class Form2 : Form
    {
        public string uuid;
        public Prod return_Prod; 
        // Using default constructor to create product;
        public Form2(string[] cates)
        {
            
            InitializeComponent();

            // cbb_Cate.DisplayMember = "Text";

            cbb_Cate.Items.Clear();
            foreach (string c in cates) {
                // Console.WriteLine(c);
                cbb_Cate.Items.Add(c);
            };
            


            // Year max, min val
            this.nmr_Year.Maximum = 9999;
            this.nmr_Year.Minimum = 1990;

            // Change form & btn name
            this.Text = "Create new Product";
            this.btn_Final.Text = "Create";
            this.AcceptButton = this.btn_Final;
        }

        // Using this constructor to edit product;
        public Form2(string[] attr, string[] cates) {
            
            InitializeComponent();

            cbb_Cate.Items.Clear();
            foreach (string c in cates)
            {
                // Console.WriteLine(c);
                cbb_Cate.Items.Add(c);
            };



            // Year max, min val
            this.nmr_Year.Maximum = 9999;
            this.nmr_Year.Minimum = 1990;

            // set value of for field on edit
            this.uuid = attr[0];
            txb_Name.Text = attr[1];
            cbb_Cate.Text = attr[2];
            txb_company.Text = attr[3];
            dpk_Exp.Text = attr[4];
            nmr_Year.Value = Convert.ToInt32(attr[5]);
            
            // Change form & btn name
            this.Text = "Edit";
            this.btn_Final.Text = "Save";
            this.AcceptButton = this.btn_Final;
        }

        private void btn_Final_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (this.btn_Final.Text == "Create")
            {
                this.return_Prod = new Prod
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Name = this.txb_Name.Text,
                    Category = this.cbb_Cate.SelectedItem.ToString(),
                    Company = this.txb_company.Text,
                    Expiration = this.dpk_Exp.Value.Date,
                    Year = Convert.ToInt32(this.nmr_Year.Value)
                };
            }
            else if (this.btn_Final.Text == "Save") {
                this.return_Prod = new Prod
                {
                    Id = this.uuid,
                    Name = this.txb_Name.Text,
                    Category = this.cbb_Cate.SelectedItem.ToString(),
                    Company = this.txb_company.Text,
                    Expiration = this.dpk_Exp.Value.Date,
                    Year = Convert.ToInt32(this.nmr_Year.Value)
                };

            }
            


            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            return;
        }


        private void Validate_Combobox(object sender, EventArgs e) {
            if (sender == txb_Name & String.IsNullOrEmpty(txb_Name.Text))
            {
                errorProvider1.SetError(txb_Name, "Name is required");
                btn_Final.Enabled = false;
            }
            else if (sender == txb_company & String.IsNullOrEmpty(txb_company.Text))
            {
                errorProvider1.SetError(txb_company, "Company is required is required");
                btn_Final.Enabled = false;
            }
            else if (sender == cbb_Cate & cbb_Cate.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbb_Cate, "Category is required is required");
                btn_Final.Enabled = false;
            }
            else {
                errorProvider1.Clear();
                btn_Final.Enabled = true;
            }

        }
    }
}
