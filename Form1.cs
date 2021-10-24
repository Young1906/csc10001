using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrdView_v2
{
    public partial class Products : Form
    {
        // Temporary hold all Product while displaying search result;
        public ListViewItem[] All_Prod;

        public Products()
        {
            // support maxium of 100 cate;
            // Cates = new string[100];

            InitializeComponent();
            InitListview();

            // initially disable edit and delete button
            btnEdit.Enabled = false;
            btnEditcat.Enabled = false;

            btnDelete.Enabled = false;
            btnDeletecat.Enabled = false;

            // not implementing cate search
            btnSearchcat.Enabled = false;
        }

        public void InitListview() {
            // Cate
            lv_prd.FullRowSelect = true;
            lv_prd.MultiSelect = false;
            lv_cat.FullRowSelect = true;
            lv_prd.MultiSelect = false;

            string[] fields = Cate.getAttribute();
            int colWidth = (int) lv_cat.Width / fields.Length;

            foreach (string field in fields)
                lv_cat.Columns.Add(field, colWidth);

            // Product
            fields = Prod.getAttribute();
            colWidth = (int)lv_prd.Width / fields.Length;

            foreach (string field in fields)
                lv_prd.Columns.Add(field, colWidth);

        }

        // return array of cate 
        private string[] getCate() {
            string[] cates = new string[this.lv_cat.Items.Count];
            int j = 0;
            foreach (ListViewItem i in lv_cat.Items) {
                cates[j++] = i.SubItems[1].Text;
            };
                

            Console.WriteLine(cates);
            return cates;

        }


        private void btnAddcat_Click(object sender, EventArgs e)
        {
            Form3 addCat_form = new Form3();
            addCat_form.ShowDialog();

            if (addCat_form.DialogResult == DialogResult.OK)
                cateAdd(addCat_form.return_Cate);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] cates = getCate();

            Form2 addForm = new Form2(cates);
            addForm.ShowDialog();

            if ( addForm.DialogResult == DialogResult.OK )
                prdAdd(addForm.return_Prod);
        }


        private void prdAdd(Prod p) {
            lv_prd.Items.Add(new ListViewItem(p.getValue()));
        }

        private void cateAdd(Cate c) {
            lv_cat.Items.Add(new ListViewItem(c.getValue()));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            // Getting value of currently selected product
            ListViewItem itm = lv_prd.SelectedItems[0];
            string[] attrs;
            attrs = new string[6];

            int i = 0;
            foreach (ListViewItem.ListViewSubItem si in itm.SubItems)
                attrs[i++] = si.Text;

            // getting cate list
            string[] cates = getCate();

            // construct new form;
            Form2 editForm = new Form2(attrs, cates);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK) {
                Prod editProd = editForm.return_Prod;
                string[] edited_val = editProd.getValue();

                int k = 0;
                foreach (ListViewItem.ListViewSubItem si in itm.SubItems)
                    si.Text = edited_val[k++];
            }
        }

        private void lv_prd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView l = sender as ListView;
            if (l.SelectedItems.Count == 1)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem i = lv_prd.SelectedItems[0];
            var confirm = MessageBox.Show($"Delete {i.SubItems[1].Text}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes) {
                for (int j = lv_prd.SelectedItems.Count - 1; j >= 0; j--) {
                    ListViewItem itm = lv_prd.SelectedItems[j];
                    lv_prd.Items[itm.Index].Remove();
                }
            }

        }

        private void btnEditcat_Click(object sender, EventArgs e)
        {
            string[] attrs = new string[3];
            ListViewItem itm = lv_cat.SelectedItems[0];

            int i = 0;
            foreach (ListViewItem.ListViewSubItem si in itm.SubItems)
                attrs[i++] = si.Text;

            Form3 editForm = new Form3(attrs);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK) {
                Cate editCate = editForm.return_Cate;
                string[] edit_val = editCate.getValue();

                int k = 0;
                foreach (ListViewItem.ListViewSubItem si in itm.SubItems)
                    si.Text = edit_val[k++];
            }
            
        }

        private void lv_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView l = sender as ListView;

            if (l.SelectedItems.Count == 1)
            {
                btnEditcat.Enabled = true;
                btnDeletecat.Enabled = true;
            }
            else {
                btnEditcat.Enabled = false;
                btnDeletecat.Enabled = false;
            }
        }

        private void btnDeletecat_Click(object sender, EventArgs e)
        {
            ListViewItem i = lv_cat.SelectedItems[0];
            var confirm = MessageBox.Show($"Delete category : {i.SubItems[1].Text}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                for (int j = lv_cat.SelectedItems.Count - 1; j >= 0; j--)
                {
                    ListViewItem itm = lv_cat.SelectedItems[j];
                    lv_cat.Items[itm.Index].Remove();
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Backup all product 
            this.All_Prod = new ListViewItem[lv_prd.Items.Count];

            int i = 0;
            foreach (ListViewItem itm in lv_prd.Items)
                this.All_Prod[i++] = itm;

            // Console.WriteLine(this.All_Prod.Length);

            string[] cates = getCate();

            search_form sform = new search_form(cates);
            sform.ShowDialog();
            
            Query Search_Query = sform.return_Query;

            if (sform.DialogResult == DialogResult.OK) { 
                lv_prd.Items.Clear();

                // item 
                // id : 0
                // name : 1
                // cate: 2
                // company : 3
                // year: 5

                if (Search_Query.key == "name") {
                    string qname = Search_Query.query.ToLower();
                    lv_prd.Items.AddRange(this.All_Prod.Where(i => i.SubItems[1].Text.ToLower().Contains(qname)).ToArray());
                }

                if (Search_Query.key == "cate")
                {
                    string qname = Search_Query.query;
                    lv_prd.Items.AddRange(this.All_Prod.Where(i => i.SubItems[2].Text.Contains(qname)).ToArray());
                }

                if (Search_Query.key == "company")
                {
                    string qname = Search_Query.query.ToLower();
                    lv_prd.Items.AddRange(this.All_Prod.Where(i => i.SubItems[3].Text.ToLower().Contains(qname)).ToArray());
                }

                if (Search_Query.key == "year")
                {
                    string qname = Search_Query.query;
                    lv_prd.Items.AddRange(this.All_Prod.Where(i => i.SubItems[5].Text.ToLower().Contains(qname)).ToArray());
                }

            }
        }

        private void btn_clear_search_Click(object sender, EventArgs e)
        {
            lv_prd.Items.Clear();
            lv_prd.Items.AddRange(this.All_Prod);
        }
    }
}
