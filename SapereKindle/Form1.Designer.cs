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
            this.btnGetSynonymsAndAntonyms = new System.Windows.Forms.Button();
            this.lReviewPosition = new System.Windows.Forms.Label();
            this.btnReviewNext = new System.Windows.Forms.Button();
            this.btnReviewPrevious = new System.Windows.Forms.Button();
            this.btnReviewRepeat = new System.Windows.Forms.Button();
            this.tbReviewSentence = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReviewTranslationSentenceAzure = new System.Windows.Forms.TextBox();
            this.tbReviewTranslationSentenceGoogle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReviewTranslationWordAzure = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbReviewTranslationWordGoogle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReviewTranslate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReviewWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReviewNew = new System.Windows.Forms.Button();
            this.cmbxReviewDictionary = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageReviewWords = new System.Windows.Forms.TabPage();
            this.btnReviewWordsNew = new System.Windows.Forms.Button();
            this.panelReviewWords = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageExperiments = new System.Windows.Forms.TabPage();
            this.rtbExperimentsTranslation = new System.Windows.Forms.RichTextBox();
            this.btnExperimentsGetTranslation = new System.Windows.Forms.Button();
            this.tbExperimentsWord = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnImportAnki = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.tabPageTranslate.SuspendLayout();
            this.tabPageReview.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageReviewWords.SuspendLayout();
            this.tabPageExperiments.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPageReviewWords);
            this.tabControl1.Controls.Add(this.tabPageExperiments);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 554);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.tabPageImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImport.Size = new System.Drawing.Size(924, 526);
            this.tabPageImport.TabIndex = 0;
            this.tabPageImport.Text = "Import";
            this.tabPageImport.UseVisualStyleBackColor = true;
            this.tabPageImport.Click += new System.EventHandler(this.tabPageImport_Click);
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
            this.tabPageTranslate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTranslate.Size = new System.Drawing.Size(924, 526);
            this.tabPageTranslate.TabIndex = 1;
            this.tabPageTranslate.Text = "Translate";
            this.tabPageTranslate.UseVisualStyleBackColor = true;
            // 
            // tabPageReview
            // 
            this.tabPageReview.Controls.Add(this.btnGetSynonymsAndAntonyms);
            this.tabPageReview.Controls.Add(this.lReviewPosition);
            this.tabPageReview.Controls.Add(this.btnReviewNext);
            this.tabPageReview.Controls.Add(this.btnReviewPrevious);
            this.tabPageReview.Controls.Add(this.btnReviewRepeat);
            this.tabPageReview.Controls.Add(this.tbReviewSentence);
            this.tabPageReview.Controls.Add(this.groupBox1);
            this.tabPageReview.Controls.Add(this.label6);
            this.tabPageReview.Controls.Add(this.btnReviewTranslate);
            this.tabPageReview.Controls.Add(this.label5);
            this.tabPageReview.Controls.Add(this.tbReviewWord);
            this.tabPageReview.Controls.Add(this.label4);
            this.tabPageReview.Controls.Add(this.btnReviewNew);
            this.tabPageReview.Controls.Add(this.cmbxReviewDictionary);
            this.tabPageReview.Controls.Add(this.label3);
            this.tabPageReview.Location = new System.Drawing.Point(4, 24);
            this.tabPageReview.Name = "tabPageReview";
            this.tabPageReview.Size = new System.Drawing.Size(924, 526);
            this.tabPageReview.TabIndex = 2;
            this.tabPageReview.Text = "Review";
            this.tabPageReview.UseVisualStyleBackColor = true;
            this.tabPageReview.Click += new System.EventHandler(this.tabPageReview_Click);
            // 
            // btnGetSynonymsAndAntonyms
            // 
            this.btnGetSynonymsAndAntonyms.Location = new System.Drawing.Point(495, 184);
            this.btnGetSynonymsAndAntonyms.Name = "btnGetSynonymsAndAntonyms";
            this.btnGetSynonymsAndAntonyms.Size = new System.Drawing.Size(153, 23);
            this.btnGetSynonymsAndAntonyms.TabIndex = 15;
            this.btnGetSynonymsAndAntonyms.Text = "Synonyms and Antonyms";
            this.btnGetSynonymsAndAntonyms.UseVisualStyleBackColor = true;
            this.btnGetSynonymsAndAntonyms.Click += new System.EventHandler(this.btnGetSynonymsAndAntonyms_Click);
            // 
            // lReviewPosition
            // 
            this.lReviewPosition.AutoSize = true;
            this.lReviewPosition.Location = new System.Drawing.Point(829, 13);
            this.lReviewPosition.Name = "lReviewPosition";
            this.lReviewPosition.Size = new System.Drawing.Size(24, 15);
            this.lReviewPosition.TabIndex = 14;
            this.lReviewPosition.Text = "0/0";
            // 
            // btnReviewNext
            // 
            this.btnReviewNext.Location = new System.Drawing.Point(867, 9);
            this.btnReviewNext.Name = "btnReviewNext";
            this.btnReviewNext.Size = new System.Drawing.Size(29, 23);
            this.btnReviewNext.TabIndex = 13;
            this.btnReviewNext.Text = ">";
            this.btnReviewNext.UseVisualStyleBackColor = true;
            this.btnReviewNext.Click += new System.EventHandler(this.btnReviewNext_Click);
            // 
            // btnReviewPrevious
            // 
            this.btnReviewPrevious.Location = new System.Drawing.Point(788, 9);
            this.btnReviewPrevious.Name = "btnReviewPrevious";
            this.btnReviewPrevious.Size = new System.Drawing.Size(27, 23);
            this.btnReviewPrevious.TabIndex = 12;
            this.btnReviewPrevious.Text = "<";
            this.btnReviewPrevious.UseVisualStyleBackColor = true;
            this.btnReviewPrevious.Click += new System.EventHandler(this.btnReviewPrevious_Click);
            // 
            // btnReviewRepeat
            // 
            this.btnReviewRepeat.Location = new System.Drawing.Point(309, 185);
            this.btnReviewRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReviewRepeat.Name = "btnReviewRepeat";
            this.btnReviewRepeat.Size = new System.Drawing.Size(82, 22);
            this.btnReviewRepeat.TabIndex = 11;
            this.btnReviewRepeat.Text = "Repeat";
            this.btnReviewRepeat.UseVisualStyleBackColor = true;
            this.btnReviewRepeat.Click += new System.EventHandler(this.btnReviewRepeat_Click);
            // 
            // tbReviewSentence
            // 
            this.tbReviewSentence.Location = new System.Drawing.Point(14, 58);
            this.tbReviewSentence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReviewSentence.Multiline = true;
            this.tbReviewSentence.Name = "tbReviewSentence";
            this.tbReviewSentence.Size = new System.Drawing.Size(882, 94);
            this.tbReviewSentence.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbReviewTranslationSentenceAzure);
            this.groupBox1.Controls.Add(this.tbReviewTranslationSentenceGoogle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbReviewTranslationWordAzure);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbReviewTranslationWordGoogle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(904, 306);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Azure Sentence:";
            // 
            // tbReviewTranslationSentenceAzure
            // 
            this.tbReviewTranslationSentenceAzure.Location = new System.Drawing.Point(14, 197);
            this.tbReviewTranslationSentenceAzure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReviewTranslationSentenceAzure.Multiline = true;
            this.tbReviewTranslationSentenceAzure.Name = "tbReviewTranslationSentenceAzure";
            this.tbReviewTranslationSentenceAzure.Size = new System.Drawing.Size(882, 94);
            this.tbReviewTranslationSentenceAzure.TabIndex = 12;
            this.tbReviewTranslationSentenceAzure.TextChanged += new System.EventHandler(this.tbReviewTranslationSentenceAzure_TextChanged);
            // 
            // tbReviewTranslationSentenceGoogle
            // 
            this.tbReviewTranslationSentenceGoogle.Location = new System.Drawing.Point(14, 74);
            this.tbReviewTranslationSentenceGoogle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReviewTranslationSentenceGoogle.Multiline = true;
            this.tbReviewTranslationSentenceGoogle.Name = "tbReviewTranslationSentenceGoogle";
            this.tbReviewTranslationSentenceGoogle.Size = new System.Drawing.Size(882, 94);
            this.tbReviewTranslationSentenceGoogle.TabIndex = 11;
            this.tbReviewTranslationSentenceGoogle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Google sentence:";
            // 
            // tbReviewTranslationWordAzure
            // 
            this.tbReviewTranslationWordAzure.Location = new System.Drawing.Point(460, 26);
            this.tbReviewTranslationWordAzure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReviewTranslationWordAzure.Name = "tbReviewTranslationWordAzure";
            this.tbReviewTranslationWordAzure.Size = new System.Drawing.Size(264, 23);
            this.tbReviewTranslationWordAzure.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Azure Word:";
            // 
            // tbReviewTranslationWordGoogle
            // 
            this.tbReviewTranslationWordGoogle.Location = new System.Drawing.Point(102, 28);
            this.tbReviewTranslationWordGoogle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReviewTranslationWordGoogle.Name = "tbReviewTranslationWordGoogle";
            this.tbReviewTranslationWordGoogle.Size = new System.Drawing.Size(190, 23);
            this.tbReviewTranslationWordGoogle.TabIndex = 1;
            this.tbReviewTranslationWordGoogle.TextChanged += new System.EventHandler(this.tbReviewTranslationWordGoogle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Google Word:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 8;
            // 
            // btnReviewTranslate
            // 
            this.btnReviewTranslate.Location = new System.Drawing.Point(407, 185);
            this.btnReviewTranslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReviewTranslate.Name = "btnReviewTranslate";
            this.btnReviewTranslate.Size = new System.Drawing.Size(82, 22);
            this.btnReviewTranslate.TabIndex = 7;
            this.btnReviewTranslate.Text = "Translate";
            this.btnReviewTranslate.UseVisualStyleBackColor = true;
            this.btnReviewTranslate.Click += new System.EventHandler(this.btnReviewTranslate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sentence:";
            // 
            // tbReviewWord
            // 
            this.tbReviewWord.Location = new System.Drawing.Point(512, 9);
            this.tbReviewWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReviewWord.Name = "tbReviewWord";
            this.tbReviewWord.Size = new System.Drawing.Size(212, 23);
            this.tbReviewWord.TabIndex = 4;
            this.tbReviewWord.TextChanged += new System.EventHandler(this.tbReviewWord_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Word:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnReviewNew
            // 
            this.btnReviewNew.Location = new System.Drawing.Point(729, 8);
            this.btnReviewNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReviewNew.Name = "btnReviewNew";
            this.btnReviewNew.Size = new System.Drawing.Size(52, 22);
            this.btnReviewNew.TabIndex = 2;
            this.btnReviewNew.Text = "New";
            this.btnReviewNew.UseVisualStyleBackColor = true;
            this.btnReviewNew.Click += new System.EventHandler(this.btnReviewNew_Click);
            // 
            // cmbxReviewDictionary
            // 
            this.cmbxReviewDictionary.FormattingEnabled = true;
            this.cmbxReviewDictionary.Location = new System.Drawing.Point(86, 9);
            this.cmbxReviewDictionary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxReviewDictionary.Name = "cmbxReviewDictionary";
            this.cmbxReviewDictionary.Size = new System.Drawing.Size(373, 23);
            this.cmbxReviewDictionary.TabIndex = 1;
            this.cmbxReviewDictionary.SelectedIndexChanged += new System.EventHandler(this.cmbxReviewDictionary_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dictionary:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPageReviewWords
            // 
            this.tabPageReviewWords.Controls.Add(this.btnReviewWordsNew);
            this.tabPageReviewWords.Controls.Add(this.panelReviewWords);
            this.tabPageReviewWords.Controls.Add(this.comboBox2);
            this.tabPageReviewWords.Controls.Add(this.label11);
            this.tabPageReviewWords.Location = new System.Drawing.Point(4, 24);
            this.tabPageReviewWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageReviewWords.Name = "tabPageReviewWords";
            this.tabPageReviewWords.Size = new System.Drawing.Size(924, 526);
            this.tabPageReviewWords.TabIndex = 3;
            this.tabPageReviewWords.Text = "Review Words";
            this.tabPageReviewWords.UseVisualStyleBackColor = true;
            this.tabPageReviewWords.Click += new System.EventHandler(this.tabPageReviewWords_Click);
            // 
            // btnReviewWordsNew
            // 
            this.btnReviewWordsNew.Location = new System.Drawing.Point(489, 10);
            this.btnReviewWordsNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReviewWordsNew.Name = "btnReviewWordsNew";
            this.btnReviewWordsNew.Size = new System.Drawing.Size(82, 22);
            this.btnReviewWordsNew.TabIndex = 5;
            this.btnReviewWordsNew.Text = "New";
            this.btnReviewWordsNew.UseVisualStyleBackColor = true;
            this.btnReviewWordsNew.Click += new System.EventHandler(this.btnReviewWordsNew_Click);
            // 
            // panelReviewWords
            // 
            this.panelReviewWords.AutoScroll = true;
            this.panelReviewWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReviewWords.Location = new System.Drawing.Point(16, 48);
            this.panelReviewWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelReviewWords.Name = "panelReviewWords";
            this.panelReviewWords.Size = new System.Drawing.Size(897, 468);
            this.panelReviewWords.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 10);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(373, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Dictionary:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tabPageExperiments
            // 
            this.tabPageExperiments.Controls.Add(this.btnImportAnki);
            this.tabPageExperiments.Controls.Add(this.rtbExperimentsTranslation);
            this.tabPageExperiments.Controls.Add(this.btnExperimentsGetTranslation);
            this.tabPageExperiments.Controls.Add(this.tbExperimentsWord);
            this.tabPageExperiments.Controls.Add(this.label12);
            this.tabPageExperiments.Location = new System.Drawing.Point(4, 24);
            this.tabPageExperiments.Name = "tabPageExperiments";
            this.tabPageExperiments.Size = new System.Drawing.Size(924, 526);
            this.tabPageExperiments.TabIndex = 4;
            this.tabPageExperiments.Text = "Experiments";
            this.tabPageExperiments.UseVisualStyleBackColor = true;
            // 
            // rtbExperimentsTranslation
            // 
            this.rtbExperimentsTranslation.Location = new System.Drawing.Point(20, 79);
            this.rtbExperimentsTranslation.Name = "rtbExperimentsTranslation";
            this.rtbExperimentsTranslation.Size = new System.Drawing.Size(883, 430);
            this.rtbExperimentsTranslation.TabIndex = 3;
            this.rtbExperimentsTranslation.Text = "";
            // 
            // btnExperimentsGetTranslation
            // 
            this.btnExperimentsGetTranslation.Location = new System.Drawing.Point(433, 43);
            this.btnExperimentsGetTranslation.Name = "btnExperimentsGetTranslation";
            this.btnExperimentsGetTranslation.Size = new System.Drawing.Size(131, 23);
            this.btnExperimentsGetTranslation.TabIndex = 2;
            this.btnExperimentsGetTranslation.Text = "Get translation";
            this.btnExperimentsGetTranslation.UseVisualStyleBackColor = true;
            this.btnExperimentsGetTranslation.Click += new System.EventHandler(this.btnExperimentsGetTranslation_Click);
            // 
            // tbExperimentsWord
            // 
            this.tbExperimentsWord.Location = new System.Drawing.Point(17, 43);
            this.tbExperimentsWord.Name = "tbExperimentsWord";
            this.tbExperimentsWord.Size = new System.Drawing.Size(379, 23);
            this.tbExperimentsWord.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Word:";
            // 
            // btnImportAnki
            // 
            this.btnImportAnki.Location = new System.Drawing.Point(602, 43);
            this.btnImportAnki.Name = "btnImportAnki";
            this.btnImportAnki.Size = new System.Drawing.Size(106, 23);
            this.btnImportAnki.TabIndex = 4;
            this.btnImportAnki.Text = "Import anki";
            this.btnImportAnki.UseVisualStyleBackColor = true;
            this.btnImportAnki.Click += new System.EventHandler(this.btnImportAnki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SapereKindle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageImport.ResumeLayout(false);
            this.tabPageImport.PerformLayout();
            this.tabPageTranslate.ResumeLayout(false);
            this.tabPageTranslate.PerformLayout();
            this.tabPageReview.ResumeLayout(false);
            this.tabPageReview.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageReviewWords.ResumeLayout(false);
            this.tabPageReviewWords.PerformLayout();
            this.tabPageExperiments.ResumeLayout(false);
            this.tabPageExperiments.PerformLayout();
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
        private System.Windows.Forms.Button btnReviewNew;
        private System.Windows.Forms.ComboBox cmbxReviewDictionary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbReviewTranslationWordGoogle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReviewTranslate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReviewWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReviewTranslationWordAzure;
        private System.Windows.Forms.TextBox tbReviewSentence;
        private System.Windows.Forms.TextBox tbReviewTranslationSentenceGoogle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbReviewTranslationSentenceAzure;
        private System.Windows.Forms.Button btnReviewRepeat;
        private System.Windows.Forms.Label lReviewPosition;
        private System.Windows.Forms.Button btnReviewNext;
        private System.Windows.Forms.Button btnReviewPrevious;
        private System.Windows.Forms.Button btnGetSynonymsAndAntonyms;
        private System.Windows.Forms.TabPage tabPageReviewWords;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelReviewWords;
        private System.Windows.Forms.Button btnReviewWordsNew;
        private System.Windows.Forms.TabPage tabPageExperiments;
        private System.Windows.Forms.RichTextBox rtbExperimentsTranslation;
        private System.Windows.Forms.Button btnExperimentsGetTranslation;
        private System.Windows.Forms.TextBox tbExperimentsWord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnImportAnki;
    }
}

