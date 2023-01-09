namespace QuizKulhavy.Forms
{
    partial class QuizForm
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
            this.LblQuestion = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TspProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.CheckList = new System.Windows.Forms.CheckedListBox();
            this.BtnQuizNext = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion.Location = new System.Drawing.Point(0, 0);
            this.LblQuestion.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(821, 114);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "Question";
            this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TspProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TspProgress
            // 
            this.TspProgress.Name = "TspProgress";
            this.TspProgress.Size = new System.Drawing.Size(151, 20);
            this.TspProgress.Text = "toolStripStatusLabel1";
            // 
            // CheckList
            // 
            this.CheckList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckList.FormattingEnabled = true;
            this.CheckList.Location = new System.Drawing.Point(262, 147);
            this.CheckList.Name = "CheckList";
            this.CheckList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckList.Size = new System.Drawing.Size(296, 246);
            this.CheckList.TabIndex = 2;
            // 
            // BtnQuizNext
            // 
            this.BtnQuizNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnQuizNext.Location = new System.Drawing.Point(0, 528);
            this.BtnQuizNext.Name = "BtnQuizNext";
            this.BtnQuizNext.Size = new System.Drawing.Size(821, 29);
            this.BtnQuizNext.TabIndex = 3;
            this.BtnQuizNext.Text = "Next";
            this.BtnQuizNext.UseVisualStyleBackColor = true;
            this.BtnQuizNext.Click += new System.EventHandler(this.BtnQuizNext_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 583);
            this.Controls.Add(this.BtnQuizNext);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LblQuestion);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblQuestion;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TspProgress;
        private CheckedListBox CheckList;
        private Button BtnQuizNext;
    }
}