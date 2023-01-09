namespace QuizKulhavy.Forms
{
    partial class Editor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnEditorAddItem = new System.Windows.Forms.Button();
            this.BtnEditorRemoveItem = new System.Windows.Forms.Button();
            this.LstViewEditor = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEditorCancel = new System.Windows.Forms.Button();
            this.EditItemGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RtxEditorFalseAnswers = new System.Windows.Forms.RichTextBox();
            this.TbxEditorQuestion = new System.Windows.Forms.TextBox();
            this.BtnEditorSaveAddItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxEditorCorrAnswer = new System.Windows.Forms.TextBox();
            this.BtnEditorSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.EditItemGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnEditorAddItem);
            this.splitContainer1.Panel1.Controls.Add(this.BtnEditorRemoveItem);
            this.splitContainer1.Panel1.Controls.Add(this.LstViewEditor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.BtnEditorCancel);
            this.splitContainer1.Panel2.Controls.Add(this.EditItemGroup);
            this.splitContainer1.Panel2.Controls.Add(this.BtnEditorSave);
            this.splitContainer1.Size = new System.Drawing.Size(970, 575);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnEditorAddItem
            // 
            this.BtnEditorAddItem.Location = new System.Drawing.Point(212, 534);
            this.BtnEditorAddItem.Name = "BtnEditorAddItem";
            this.BtnEditorAddItem.Size = new System.Drawing.Size(94, 29);
            this.BtnEditorAddItem.TabIndex = 9;
            this.BtnEditorAddItem.Text = "Add";
            this.BtnEditorAddItem.UseVisualStyleBackColor = true;
            this.BtnEditorAddItem.Click += new System.EventHandler(this.BtnEditorAddItem_Click);
            // 
            // BtnEditorRemoveItem
            // 
            this.BtnEditorRemoveItem.Location = new System.Drawing.Point(12, 534);
            this.BtnEditorRemoveItem.Name = "BtnEditorRemoveItem";
            this.BtnEditorRemoveItem.Size = new System.Drawing.Size(94, 29);
            this.BtnEditorRemoveItem.TabIndex = 8;
            this.BtnEditorRemoveItem.Text = "Remove";
            this.BtnEditorRemoveItem.UseVisualStyleBackColor = true;
            this.BtnEditorRemoveItem.Click += new System.EventHandler(this.BtnEditorRemoveItem_Click);
            // 
            // LstViewEditor
            // 
            this.LstViewEditor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LstViewEditor.Location = new System.Drawing.Point(3, 3);
            this.LstViewEditor.Name = "LstViewEditor";
            this.LstViewEditor.Size = new System.Drawing.Size(317, 525);
            this.LstViewEditor.TabIndex = 0;
            this.LstViewEditor.UseCompatibleStateImageBehavior = false;
            this.LstViewEditor.View = System.Windows.Forms.View.List;
            this.LstViewEditor.SelectedIndexChanged += new System.EventHandler(this.LstViewEditor_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Question";
            this.columnHeader1.Width = 317;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tip: To add multiple correct answers, use the underscore character (_) as a separ" +
    "ator.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tip: Separate false answers onto separate lines when adding multiple values.";
            // 
            // BtnEditorCancel
            // 
            this.BtnEditorCancel.Location = new System.Drawing.Point(437, 534);
            this.BtnEditorCancel.Name = "BtnEditorCancel";
            this.BtnEditorCancel.Size = new System.Drawing.Size(94, 29);
            this.BtnEditorCancel.TabIndex = 9;
            this.BtnEditorCancel.Text = "Cancel";
            this.BtnEditorCancel.UseVisualStyleBackColor = true;
            this.BtnEditorCancel.Click += new System.EventHandler(this.BtnEditorCancel_Click);
            // 
            // EditItemGroup
            // 
            this.EditItemGroup.Controls.Add(this.label3);
            this.EditItemGroup.Controls.Add(this.label1);
            this.EditItemGroup.Controls.Add(this.RtxEditorFalseAnswers);
            this.EditItemGroup.Controls.Add(this.TbxEditorQuestion);
            this.EditItemGroup.Controls.Add(this.BtnEditorSaveAddItem);
            this.EditItemGroup.Controls.Add(this.label2);
            this.EditItemGroup.Controls.Add(this.TbxEditorCorrAnswer);
            this.EditItemGroup.Enabled = false;
            this.EditItemGroup.Location = new System.Drawing.Point(16, 12);
            this.EditItemGroup.Name = "EditItemGroup";
            this.EditItemGroup.Size = new System.Drawing.Size(615, 382);
            this.EditItemGroup.TabIndex = 8;
            this.EditItemGroup.TabStop = false;
            this.EditItemGroup.Text = "Edit item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "False Answers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // RtxEditorFalseAnswers
            // 
            this.RtxEditorFalseAnswers.Location = new System.Drawing.Point(137, 129);
            this.RtxEditorFalseAnswers.Name = "RtxEditorFalseAnswers";
            this.RtxEditorFalseAnswers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtxEditorFalseAnswers.Size = new System.Drawing.Size(471, 138);
            this.RtxEditorFalseAnswers.TabIndex = 7;
            this.RtxEditorFalseAnswers.Text = "";
            // 
            // TbxEditorQuestion
            // 
            this.TbxEditorQuestion.Location = new System.Drawing.Point(137, 40);
            this.TbxEditorQuestion.Name = "TbxEditorQuestion";
            this.TbxEditorQuestion.Size = new System.Drawing.Size(471, 27);
            this.TbxEditorQuestion.TabIndex = 4;
            // 
            // BtnEditorSaveAddItem
            // 
            this.BtnEditorSaveAddItem.Location = new System.Drawing.Point(514, 347);
            this.BtnEditorSaveAddItem.Name = "BtnEditorSaveAddItem";
            this.BtnEditorSaveAddItem.Size = new System.Drawing.Size(94, 29);
            this.BtnEditorSaveAddItem.TabIndex = 2;
            this.BtnEditorSaveAddItem.Text = "Save Item";
            this.BtnEditorSaveAddItem.UseVisualStyleBackColor = true;
            this.BtnEditorSaveAddItem.Click += new System.EventHandler(this.BtnEditorSaveAddItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correct Answer(s)";
            // 
            // TbxEditorCorrAnswer
            // 
            this.TbxEditorCorrAnswer.Location = new System.Drawing.Point(137, 87);
            this.TbxEditorCorrAnswer.Name = "TbxEditorCorrAnswer";
            this.TbxEditorCorrAnswer.Size = new System.Drawing.Size(471, 27);
            this.TbxEditorCorrAnswer.TabIndex = 5;
            // 
            // BtnEditorSave
            // 
            this.BtnEditorSave.Location = new System.Drawing.Point(537, 534);
            this.BtnEditorSave.Name = "BtnEditorSave";
            this.BtnEditorSave.Size = new System.Drawing.Size(94, 29);
            this.BtnEditorSave.TabIndex = 1;
            this.BtnEditorSave.Text = "Save";
            this.BtnEditorSave.UseVisualStyleBackColor = true;
            this.BtnEditorSave.Click += new System.EventHandler(this.BtnEditorSave_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 575);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Editor";
            this.Text = "Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.EditItemGroup.ResumeLayout(false);
            this.EditItemGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView LstViewEditor;
        private GroupBox EditItemGroup;
        private Label label1;
        private TextBox TbxEditorQuestion;
        private Label label2;
        private TextBox TbxEditorCorrAnswer;
        private RichTextBox RtxEditorFalseAnswers;
        private Button BtnEditorSaveAddItem;
        private Button BtnEditorSave;
        private Button BtnEditorAddItem;
        private Button BtnEditorRemoveItem;
        private Button BtnEditorCancel;
        private ColumnHeader columnHeader1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}