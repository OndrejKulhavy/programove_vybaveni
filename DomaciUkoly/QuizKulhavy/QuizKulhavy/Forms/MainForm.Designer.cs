namespace QuizKulhavy
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripFolderPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToMarkDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEditQuiz = new System.Windows.Forms.Button();
            this.BtnRemoveQuiz = new System.Windows.Forms.Button();
            this.BtnOpenQuiz = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Length = new System.Windows.Forms.ColumnHeader();
            this.Path = new System.Windows.Forms.ColumnHeader();
            this.BtnAddQuizMaterial = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFolderPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripFolderPath
            // 
            this.ToolStripFolderPath.Name = "ToolStripFolderPath";
            this.ToolStripFolderPath.Size = new System.Drawing.Size(86, 20);
            this.ToolStripFolderPath.Text = "D:/Location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToMarkDownToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToMarkDownToolStripMenuItem
            // 
            this.exportToMarkDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markdownToolStripMenuItem,
            this.hTMLToolStripMenuItem});
            this.exportToMarkDownToolStripMenuItem.Name = "exportToMarkDownToolStripMenuItem";
            this.exportToMarkDownToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exportToMarkDownToolStripMenuItem.Text = " Export dataset";
            // 
            // markdownToolStripMenuItem
            // 
            this.markdownToolStripMenuItem.Name = "markdownToolStripMenuItem";
            this.markdownToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.markdownToolStripMenuItem.Text = "Markdown";
            this.markdownToolStripMenuItem.Click += new System.EventHandler(this.BtnExportAsMdClicked);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.BtnExportAsHTMLClicked);
            // 
            // BtnEditQuiz
            // 
            this.BtnEditQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditQuiz.Enabled = false;
            this.BtnEditQuiz.Location = new System.Drawing.Point(568, 651);
            this.BtnEditQuiz.Name = "BtnEditQuiz";
            this.BtnEditQuiz.Size = new System.Drawing.Size(94, 29);
            this.BtnEditQuiz.TabIndex = 9;
            this.BtnEditQuiz.Text = "Edit";
            this.BtnEditQuiz.UseVisualStyleBackColor = true;
            this.BtnEditQuiz.Click += new System.EventHandler(this.BtnEditDeckClicked);
            // 
            // BtnRemoveQuiz
            // 
            this.BtnRemoveQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveQuiz.Enabled = false;
            this.BtnRemoveQuiz.Location = new System.Drawing.Point(468, 651);
            this.BtnRemoveQuiz.Name = "BtnRemoveQuiz";
            this.BtnRemoveQuiz.Size = new System.Drawing.Size(94, 29);
            this.BtnRemoveQuiz.TabIndex = 8;
            this.BtnRemoveQuiz.Text = "Remove";
            this.BtnRemoveQuiz.UseVisualStyleBackColor = true;
            this.BtnRemoveQuiz.Click += new System.EventHandler(this.BtnRemoveDeck);
            // 
            // BtnOpenQuiz
            // 
            this.BtnOpenQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenQuiz.Enabled = false;
            this.BtnOpenQuiz.Location = new System.Drawing.Point(678, 651);
            this.BtnOpenQuiz.Name = "BtnOpenQuiz";
            this.BtnOpenQuiz.Size = new System.Drawing.Size(94, 29);
            this.BtnOpenQuiz.TabIndex = 7;
            this.BtnOpenQuiz.Text = "Open";
            this.BtnOpenQuiz.UseVisualStyleBackColor = true;
            this.BtnOpenQuiz.Click += new System.EventHandler(this.BtnOpenQuizClicked);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Date,
            this.Length,
            this.Path});
            this.ListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListView.Location = new System.Drawing.Point(0, 28);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(784, 614);
            this.ListView.TabIndex = 6;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.SelectedDeckChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 80;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            this.Length.Width = 100;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 400;
            // 
            // BtnAddQuizMaterial
            // 
            this.BtnAddQuizMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddQuizMaterial.Location = new System.Drawing.Point(12, 651);
            this.BtnAddQuizMaterial.Name = "BtnAddQuizMaterial";
            this.BtnAddQuizMaterial.Size = new System.Drawing.Size(138, 29);
            this.BtnAddQuizMaterial.TabIndex = 5;
            this.BtnAddQuizMaterial.Text = "Add material";
            this.BtnAddQuizMaterial.UseVisualStyleBackColor = true;
            this.BtnAddQuizMaterial.Click += new System.EventHandler(this.BtnAddDeckClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 709);
            this.Controls.Add(this.BtnEditQuiz);
            this.Controls.Add(this.BtnRemoveQuiz);
            this.Controls.Add(this.BtnOpenQuiz);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.BtnAddQuizMaterial);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Quiz App by Ondrej Kulhavy";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripFolderPath;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToMarkDownToolStripMenuItem;
        private ToolStripMenuItem markdownToolStripMenuItem;
        private Button BtnEditQuiz;
        private Button BtnRemoveQuiz;
        private Button BtnOpenQuiz;
        private ListView ListView;
        private ColumnHeader Title;
        private ColumnHeader Date;
        private ColumnHeader Length;
        private ColumnHeader Path;
        private Button BtnAddQuizMaterial;
        private ToolStripMenuItem hTMLToolStripMenuItem;
    }
}