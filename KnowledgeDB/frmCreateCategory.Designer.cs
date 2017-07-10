namespace KnowledgeDB
{
    partial class frmCreateCategory
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
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(198, 12);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(96, 23);
            this.btnCreateCategory.TabIndex = 0;
            this.btnCreateCategory.Text = "Create Category";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(13, 13);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(179, 20);
            this.txtCategoryName.TabIndex = 1;
            // 
            // frmCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 50);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.btnCreateCategory);
            this.Name = "frmCreateCategory";
            this.Text = "frmCreateCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
    }
}