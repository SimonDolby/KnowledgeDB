namespace KnowledgeDB
{
    partial class Form1
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
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.btnCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportToDocx = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.docxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerpointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.txtNoteName = new System.Windows.Forms.TextBox();
            this.lblNoteName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoteContents = new System.Windows.Forms.TextBox();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCategory,
            this.documentsToolStripMenuItem,
            this.powerpointsToolStripMenuItem});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(738, 24);
            this.mnuBar.TabIndex = 0;
            this.mnuBar.Text = "menuStrip1";
            // 
            // btnCategory
            // 
            this.btnCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateCategory,
            this.btnGetCategory});
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(67, 20);
            this.btnCategory.Text = "Category";
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(159, 22);
            this.btnCreateCategory.Text = "Create Category";
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnGetCategory
            // 
            this.btnGetCategory.Name = "btnGetCategory";
            this.btnGetCategory.Size = new System.Drawing.Size(159, 22);
            this.btnGetCategory.Text = "Get Category";
            this.btnGetCategory.Click += new System.EventHandler(this.btnGetCategory_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportToDocx});
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // btnExportToDocx
            // 
            this.btnExportToDocx.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDoc,
            this.docxToolStripMenuItem});
            this.btnExportToDocx.Name = "btnExportToDocx";
            this.btnExportToDocx.Size = new System.Drawing.Size(212, 22);
            this.btnExportToDocx.Text = "Export to Word Document";
            this.btnExportToDocx.Click += new System.EventHandler(this.btnExportToDocx_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(100, 22);
            this.btnDoc.Text = "Doc";
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // docxToolStripMenuItem
            // 
            this.docxToolStripMenuItem.Name = "docxToolStripMenuItem";
            this.docxToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.docxToolStripMenuItem.Text = "Docx";
            // 
            // powerpointsToolStripMenuItem
            // 
            this.powerpointsToolStripMenuItem.Name = "powerpointsToolStripMenuItem";
            this.powerpointsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.powerpointsToolStripMenuItem.Text = "Powerpoints";
            this.powerpointsToolStripMenuItem.Visible = false;
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(514, 27);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(195, 160);
            this.lstCategories.TabIndex = 2;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Location = new System.Drawing.Point(328, 73);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(109, 23);
            this.btnCreateNote.TabIndex = 3;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.UseVisualStyleBackColor = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // txtNoteName
            // 
            this.txtNoteName.Location = new System.Drawing.Point(116, 73);
            this.txtNoteName.Name = "txtNoteName";
            this.txtNoteName.Size = new System.Drawing.Size(206, 20);
            this.txtNoteName.TabIndex = 4;
            // 
            // lblNoteName
            // 
            this.lblNoteName.AutoSize = true;
            this.lblNoteName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNoteName.Location = new System.Drawing.Point(36, 76);
            this.lblNoteName.Name = "lblNoteName";
            this.lblNoteName.Size = new System.Drawing.Size(64, 13);
            this.lblNoteName.TabIndex = 5;
            this.lblNoteName.Text = "Note Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Note Contents:";
            // 
            // txtNoteContents
            // 
            this.txtNoteContents.Location = new System.Drawing.Point(116, 126);
            this.txtNoteContents.Multiline = true;
            this.txtNoteContents.Name = "txtNoteContents";
            this.txtNoteContents.Size = new System.Drawing.Size(206, 299);
            this.txtNoteContents.TabIndex = 7;
            // 
            // lstNotes
            // 
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.Location = new System.Drawing.Point(514, 194);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(195, 251);
            this.lstNotes.TabIndex = 8;
            this.lstNotes.SelectedIndexChanged += new System.EventHandler(this.lstNotes_SelectedIndexChanged);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Location = new System.Drawing.Point(328, 103);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(109, 23);
            this.btnEditNote.TabIndex = 9;
            this.btnEditNote.Text = "Edit Note";
            this.btnEditNote.UseVisualStyleBackColor = true;
            this.btnEditNote.Click += new System.EventHandler(this.btnEditNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 463);
            this.Controls.Add(this.btnEditNote);
            this.Controls.Add(this.lstNotes);
            this.Controls.Add(this.txtNoteContents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoteName);
            this.Controls.Add(this.txtNoteName);
            this.Controls.Add(this.btnCreateNote);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.mnuBar);
            this.MainMenuStrip = this.mnuBar;
            this.Name = "Form1";
            this.Text = "Notekeeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem btnCategory;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.TextBox txtNoteName;
        private System.Windows.Forms.Label lblNoteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoteContents;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Button btnEditNote;
        private System.Windows.Forms.ToolStripMenuItem btnCreateCategory;
        private System.Windows.Forms.ToolStripMenuItem btnGetCategory;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerpointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExportToDocx;
        private System.Windows.Forms.ToolStripMenuItem btnDoc;
        private System.Windows.Forms.ToolStripMenuItem docxToolStripMenuItem;
    }
}

