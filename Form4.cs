using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrdView_v2
{
    public partial class search_form : Form
    {
        public Query return_Query;
        public search_form(string[] cates)
        {
            InitializeComponent();

            nmr_Year.Minimum = 1990;
            nmr_Year.Maximum = 9999;

            btn_search.Enabled = false;


            // initializing cate
            cbb_Cate.Items.Clear();
            foreach (string c in cates)
            {
                // Console.WriteLine(c);
                cbb_Cate.Items.Add(c);
            };

            // disable all input
            txb_Name.Enabled = false;
            txb_company.Enabled = false;
            cbb_Cate.Enabled = false;
            nmr_Year.Enabled = false;

            // adding event handler to all radio btn
            rbt_Name.Click += Handle_Radio_Btn;
            rbt_Company.Click += Handle_Radio_Btn;
            rbt_Cate.Click += Handle_Radio_Btn;
            rbt_Year.Click += Handle_Radio_Btn;

            // adding event handler to inputfield
            txb_Name.TextChanged += HandleValidation;
            txb_Name.Validated += HandleValidation;
            txb_company.TextChanged += HandleValidation;
            txb_company.Validated += HandleValidation;

            cbb_Cate.SelectedIndexChanged += HandleValidation;
            cbb_Cate.Validated += HandleValidation;

            nmr_Year.ValueChanged += HandleValidation;
            nmr_Year.Validated += HandleValidation;

            this.AcceptButton = btn_search;

            btn_search.Click += HandleBtnSearch;
        }

        public void HandleBtnSearch(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;

            if (rbt_Name.Checked)
                this.return_Query = new Query { key = "name", query = txb_Name.Text };
            else if (rbt_Company.Checked)
                this.return_Query = new Query { key = "company", query = txb_company.Text };
            else if (rbt_Cate.Checked)
                this.return_Query = new Query { key = "cate", query = cbb_Cate.SelectedItem.ToString() };
            else if (rbt_Year.Checked)
                this.return_Query = new Query { key = "year", query = ((int)nmr_Year.Value).ToString() };


            // close this form
            this.Close();
        }

        public void HandleValidation(object sender, EventArgs e) {
            if (sender == txb_Name & String.IsNullOrEmpty(txb_Name.Text)){
                errorProvider1.SetError(txb_Name, "Required!");
                btn_search.Enabled = false;
            } else if (sender == txb_company & String.IsNullOrEmpty(txb_company.Text)){
                errorProvider1.SetError(txb_company, "Required!");
                btn_search.Enabled = false;
            } else if (sender == cbb_Cate & cbb_Cate.SelectedIndex == -1) {
                errorProvider1.SetError(cbb_Cate, "Required!");
                btn_search.Enabled = false;
            } else {
                errorProvider1.Clear();
                btn_search.Enabled = true;
            }
        }


        public void Handle_Radio_Btn(object sender, EventArgs e) {
            RadioButton btn = sender as RadioButton;

            if (btn.Name == "rbt_Name") {
                txb_Name.Enabled = (btn.Checked == true) ? true : false;
                txb_company.Enabled = false;
                cbb_Cate.Enabled = false;
                nmr_Year.Enabled = false;
            }

            if (btn.Name == "rbt_Company")
            {
                txb_Name.Enabled = false;
                txb_company.Enabled = (btn.Checked == true) ? true : false;
                cbb_Cate.Enabled = false;
                nmr_Year.Enabled = false;
            }

            if (btn.Name == "rbt_Cate")
            {
                txb_Name.Enabled = false;
                txb_company.Enabled = false;
                cbb_Cate.Enabled = (btn.Checked == true) ? true : false;
                nmr_Year.Enabled = false;
            }

            if (btn.Name == "rbt_Year")
            {
                txb_Name.Enabled = false;
                txb_company.Enabled = false;
                cbb_Cate.Enabled = false;
                nmr_Year.Enabled = (btn.Checked == true) ? true : false;
            }


        }
    }
}
