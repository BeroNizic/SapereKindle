
namespace SapereKindle
{
    partial class WordReviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lWord = new System.Windows.Forms.Label();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbOK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lWord
            // 
            this.lWord.AutoSize = true;
            this.lWord.Location = new System.Drawing.Point(12, 13);
            this.lWord.Name = "lWord";
            this.lWord.Size = new System.Drawing.Size(50, 20);
            this.lWord.TabIndex = 0;
            this.lWord.Text = "label1";
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(275, 10);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(342, 27);
            this.tbTranslation.TabIndex = 1;
            this.tbTranslation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(660, 10);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 29);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(772, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(94, 29);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cbOK
            // 
            this.cbOK.AutoSize = true;
            this.cbOK.Location = new System.Drawing.Point(628, 12);
            this.cbOK.Name = "cbOK";
            this.cbOK.Size = new System.Drawing.Size(18, 17);
            this.cbOK.TabIndex = 4;
            this.cbOK.UseVisualStyleBackColor = true;
            // 
            // WordReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbOK);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lWord);
            this.Name = "WordReviewControl";
            this.Size = new System.Drawing.Size(876, 45);
            this.Load += new System.EventHandler(this.WordReviewControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWord;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox cbOK;
    }
}
