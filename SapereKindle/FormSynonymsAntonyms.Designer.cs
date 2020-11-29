
namespace SapereKindle
{
    partial class FormSynonymsAntonyms
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSynonyms = new System.Windows.Forms.ListBox();
            this.lbAntonyms = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Synonyms:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSynonyms
            // 
            this.lbSynonyms.FormattingEnabled = true;
            this.lbSynonyms.ItemHeight = 15;
            this.lbSynonyms.Location = new System.Drawing.Point(13, 68);
            this.lbSynonyms.Name = "lbSynonyms";
            this.lbSynonyms.Size = new System.Drawing.Size(320, 304);
            this.lbSynonyms.TabIndex = 1;
            // 
            // lbAntonyms
            // 
            this.lbAntonyms.FormattingEnabled = true;
            this.lbAntonyms.ItemHeight = 15;
            this.lbAntonyms.Location = new System.Drawing.Point(351, 68);
            this.lbAntonyms.Name = "lbAntonyms";
            this.lbAntonyms.Size = new System.Drawing.Size(320, 304);
            this.lbAntonyms.TabIndex = 2;
            this.lbAntonyms.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(301, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Antonyms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Word:";
            // 
            // lWord
            // 
            this.lWord.AutoSize = true;
            this.lWord.Location = new System.Drawing.Point(61, 13);
            this.lWord.Name = "lWord";
            this.lWord.Size = new System.Drawing.Size(45, 15);
            this.lWord.TabIndex = 6;
            this.lWord.Text = "Not set";
            // 
            // FormSynonymsAntonyms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 423);
            this.Controls.Add(this.lWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbAntonyms);
            this.Controls.Add(this.lbSynonyms);
            this.Controls.Add(this.label1);
            this.Name = "FormSynonymsAntonyms";
            this.Text = "FormSynonymsAntonyms";
            this.Load += new System.EventHandler(this.FormSynonymsAntonyms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSynonyms;
        private System.Windows.Forms.ListBox lbAntonyms;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lWord;
    }
}