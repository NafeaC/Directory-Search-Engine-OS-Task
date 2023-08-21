namespace task_os
{
    partial class Form1
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
            this.tbSearchDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpTerm = new System.Windows.Forms.TextBox();
            this.pbprogress = new System.Windows.Forms.ProgressBar();
            this.lbFilleFound = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tbSearchDir
            // 
            this.tbSearchDir.Location = new System.Drawing.Point(164, 12);
            this.tbSearchDir.Name = "tbSearchDir";
            this.tbSearchDir.Size = new System.Drawing.Size(656, 27);
            this.tbSearchDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filename :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tpTerm
            // 
            this.tpTerm.Location = new System.Drawing.Point(115, 69);
            this.tpTerm.Name = "tpTerm";
            this.tpTerm.Size = new System.Drawing.Size(522, 27);
            this.tpTerm.TabIndex = 4;
            // 
            // pbprogress
            // 
            this.pbprogress.Location = new System.Drawing.Point(22, 137);
            this.pbprogress.Name = "pbprogress";
            this.pbprogress.Size = new System.Drawing.Size(810, 29);
            this.pbprogress.TabIndex = 5;
            // 
            // lbFilleFound
            // 
            this.lbFilleFound.FormattingEnabled = true;
            this.lbFilleFound.ItemHeight = 20;
            this.lbFilleFound.Location = new System.Drawing.Point(22, 195);
            this.lbFilleFound.Name = "lbFilleFound";
            this.lbFilleFound.Size = new System.Drawing.Size(810, 444);
            this.lbFilleFound.TabIndex = 6;
            this.lbFilleFound.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(695, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Start";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 706);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbFilleFound);
            this.Controls.Add(this.pbprogress);
            this.Controls.Add(this.tpTerm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchDir);
            this.Name = "Form1";
            this.Text = "Form Searcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbSearchDir;
        private Label label1;
        private Label label2;
        private TextBox tpTerm;
        private ProgressBar pbprogress;
        private ListBox lbFilleFound;
        private Button btnSearch;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}