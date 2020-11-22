namespace SapereKindle
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
            this.btnTranslate = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbOutput2 = new System.Windows.Forms.TextBox();
            this.btnImportKindleMate = new System.Windows.Forms.Button();
            this.tbKindleMateFile = new System.Windows.Forms.TextBox();
            this.btnSetKindleMateFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.cmbxDictionaries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTranslate = new System.Windows.Forms.TabPage();
            this.tabPageReview = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.tabPageTranslate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(378, 88);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(15, 15);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(775, 23);
            this.tbInput.TabIndex = 1;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(14, 160);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(775, 119);
            this.tbOutput.TabIndex = 2;
            // 
            // tbOutput2
            // 
            this.tbOutput2.Location = new System.Drawing.Point(14, 304);
            this.tbOutput2.Multiline = true;
            this.tbOutput2.Name = "tbOutput2";
            this.tbOutput2.Size = new System.Drawing.Size(775, 115);
            this.tbOutput2.TabIndex = 3;
            // 
            // btnImportKindleMate
            // 
            this.btnImportKindleMate.Location = new System.Drawing.Point(335, 156);
            this.btnImportKindleMate.Name = "btnImportKindleMate";
            this.btnImportKindleMate.Size = new System.Drawing.Size(141, 24);
            this.btnImportKindleMate.TabIndex = 4;
            this.btnImportKindleMate.Text = "Import and Translate";
            this.btnImportKindleMate.UseVisualStyleBackColor = true;
            this.btnImportKindleMate.Click += new System.EventHandler(this.btnImportKindleMate_Click);
            // 
            // tbKindleMateFile
            // 
            this.tbKindleMateFile.Location = new System.Drawing.Point(13, 38);
            this.tbKindleMateFile.Name = "tbKindleMateFile";
            this.tbKindleMateFile.Size = new System.Drawing.Size(728, 23);
            this.tbKindleMateFile.TabIndex = 5;
            // 
            // btnSetKindleMateFile
            // 
            this.btnSetKindleMateFile.Location = new System.Drawing.Point(756, 39);
            this.btnSetKindleMateFile.Name = "btnSetKindleMateFile";
            this.btnSetKindleMateFile.Size = new System.Drawing.Size(40, 23);
            this.btnSetKindleMateFile.TabIndex = 6;
            this.btnSetKindleMateFile.Text = "...";
            this.btnSetKindleMateFile.UseVisualStyleBackColor = true;
            this.btnSetKindleMateFile.Click += new System.EventHandler(this.btnOpenKindleMateFile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageImport);
            this.tabControl1.Controls.Add(this.tabPageTranslate);
            this.tabControl1.Controls.Add(this.tabPageReview);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 472);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageImport
            // 
            this.tabPageImport.Controls.Add(this.cmbxDictionaries);
            this.tabPageImport.Controls.Add(this.label2);
            this.tabPageImport.Controls.Add(this.label1);
            this.tabPageImport.Controls.Add(this.tbKindleMateFile);
            this.tabPageImport.Controls.Add(this.btnImportKindleMate);
            this.tabPageImport.Controls.Add(this.btnSetKindleMateFile);
            this.tabPageImport.Location = new System.Drawing.Point(4, 24);
            this.tabPageImport.Name = "tabPageImport";
            this.tabPageImport.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageImport.Size = new System.Drawing.Size(825, 444);
            this.tabPageImport.TabIndex = 0;
            this.tabPageImport.Text = "Import";
            this.tabPageImport.UseVisualStyleBackColor = true;
            // 
            // cmbxDictionaries
            // 
            this.cmbxDictionaries.FormattingEnabled = true;
            this.cmbxDictionaries.Location = new System.Drawing.Point(13, 106);
            this.cmbxDictionaries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxDictionaries.Name = "cmbxDictionaries";
            this.cmbxDictionaries.Size = new System.Drawing.Size(728, 23);
            this.cmbxDictionaries.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination dictionary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kindle Mate exported file:";
            // 
            // tabPageTranslate
            // 
            this.tabPageTranslate.Controls.Add(this.tbInput);
            this.tabPageTranslate.Controls.Add(this.btnTranslate);
            this.tabPageTranslate.Controls.Add(this.tbOutput);
            this.tabPageTranslate.Controls.Add(this.tbOutput2);
            this.tabPageTranslate.Location = new System.Drawing.Point(4, 24);
            this.tabPageTranslate.Name = "tabPageTranslate";
            this.tabPageTranslate.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageTranslate.Size = new System.Drawing.Size(825, 444);
            this.tabPageTranslate.TabIndex = 1;
            this.tabPageTranslate.Text = "Translate";
            this.tabPageTranslate.UseVisualStyleBackColor = true;
            // 
            // tabPageReview
            // 
            this.tabPageReview.Location = new System.Drawing.Point(4, 24);
            this.tabPageReview.Name = "tabPageReview";
            this.tabPageReview.Size = new System.Drawing.Size(825, 444);
            this.tabPageReview.TabIndex = 2;
            this.tabPageReview.Text = "Review";
            this.tabPageReview.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageImport.ResumeLayout(false);
            this.tabPageImport.PerformLayout();
            this.tabPageTranslate.ResumeLayout(false);
            this.tabPageTranslate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbOutput2;
        private System.Windows.Forms.Button btnImportKindleMate;
        private System.Windows.Forms.TextBox tbKindleMateFile;
        private System.Windows.Forms.Button btnSetKindleMateFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageImport;
        private System.Windows.Forms.TabPage tabPageTranslate;
        private System.Windows.Forms.TabPage tabPageReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxDictionaries;
    }
}

