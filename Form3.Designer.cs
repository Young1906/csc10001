
namespace PrdView_v2
{
    partial class Form3
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
            this.txb_cateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Cate_shortcode = new System.Windows.Forms.TextBox();
            this.btn_Cancel_cate = new System.Windows.Forms.Button();
            this.btn_Final_cate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_cateName
            // 
            this.txb_cateName.Location = new System.Drawing.Point(134, 6);
            this.txb_cateName.Name = "txb_cateName";
            this.txb_cateName.Size = new System.Drawing.Size(296, 23);
            this.txb_cateName.TabIndex = 0;
            this.txb_cateName.Validated += new System.EventHandler(this.form3_validate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txb_Cate_shortcode
            // 
            this.txb_Cate_shortcode.Location = new System.Drawing.Point(134, 35);
            this.txb_Cate_shortcode.Multiline = true;
            this.txb_Cate_shortcode.Name = "txb_Cate_shortcode";
            this.txb_Cate_shortcode.Size = new System.Drawing.Size(296, 65);
            this.txb_Cate_shortcode.TabIndex = 3;
            // 
            // btn_Cancel_cate
            // 
            this.btn_Cancel_cate.Location = new System.Drawing.Point(355, 106);
            this.btn_Cancel_cate.Name = "btn_Cancel_cate";
            this.btn_Cancel_cate.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel_cate.TabIndex = 4;
            this.btn_Cancel_cate.Text = "Cancel";
            this.btn_Cancel_cate.UseVisualStyleBackColor = true;
            this.btn_Cancel_cate.Click += new System.EventHandler(this.btn_Cancel_cate_Click);
            // 
            // btn_Final_cate
            // 
            this.btn_Final_cate.Location = new System.Drawing.Point(265, 106);
            this.btn_Final_cate.Name = "btn_Final_cate";
            this.btn_Final_cate.Size = new System.Drawing.Size(75, 23);
            this.btn_Final_cate.TabIndex = 5;
            this.btn_Final_cate.Text = "button2";
            this.btn_Final_cate.UseVisualStyleBackColor = true;
            this.btn_Final_cate.Click += new System.EventHandler(this.btn_Final_cate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 141);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Final_cate);
            this.Controls.Add(this.btn_Cancel_cate);
            this.Controls.Add(this.txb_Cate_shortcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_cateName);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_cateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Cate_shortcode;
        private System.Windows.Forms.Button btn_Cancel_cate;
        private System.Windows.Forms.Button btn_Final_cate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}