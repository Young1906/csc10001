using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrdView_v2
{
    public partial class Form3 : Form
    {
        public Cate return_Cate;
        public string uuid;
        // default constructor : create form
        public Form3()
        {
            InitializeComponent();
            this.Text = "Create category";
            this.btn_Final_cate.Text = "Create";
            this.AcceptButton = this.btn_Final_cate;
        }

        public Form3(string[] attrs) {
            InitializeComponent();
            this.Text = "Edit category";
            this.btn_Final_cate.Text = "Save";
            this.AcceptButton = this.btn_Final_cate;

            this.uuid = attrs[0];
            txb_cateName.Text = attrs[1];
            txb_Cate_shortcode.Text = attrs[2];

            foreach (string s in attrs)
                Console.WriteLine(s);

        }

        private void btn_Final_cate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (btn_Final_cate.Text == "Create") {
                this.return_Cate = new Cate
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Name = this.txb_cateName.Text,
                    Description = this.txb_Cate_shortcode.Text
                };
            } else if (btn_Final_cate.Text == "Save")
            {
                this.return_Cate = new Cate
                {
                    Id = this.uuid,
                    Name = this.txb_cateName.Text,
                    Description = this.txb_Cate_shortcode.Text
                };

                foreach(string s in this.return_Cate.getValue())
                    Console.WriteLine(s);

            }
            

        }

        private void form3_validate(object sender, EventArgs e)
        {
            if (sender == txb_cateName & String.IsNullOrEmpty(txb_cateName.Text))
            {
                errorProvider1.SetError(txb_cateName, "Name is required");
                btn_Final_cate.Enabled = false;
            }
            else {
                errorProvider1.Clear();
                btn_Final_cate.Enabled = true;
            }
        }

        private void btn_Cancel_cate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
