using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using SapereKindle.Dictionary;
using SapereKindle.TranslationAPI;

namespace SapereKindle
{
    public partial class Form1 : Form
    {
        private TranslationService _translationService;
        private DictionaryService _dictionaryService;
        private Random _random;
        private List<TranslationItem> _reviewItems = new List<TranslationItem>();
        private int _currentReviewIndex = -1;

        public Form1()
        {
            InitializeComponent();
            _random = new Random();
        }
        
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            var translations = _translationService.TranslateTextAsync(tbInput.Text, "it", "en").GetAwaiter().GetResult();
            tbOutput.Text = translations[0];
            tbOutput2.Text = translations[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _translationService = new TranslationService();
            _dictionaryService = new DictionaryService();
            var dictionaries = _dictionaryService.GetAllDictionaries();
            cmbxDictionaries.DataSource = dictionaries;
            cmbxDictionaries.SelectedIndex = 0;
            cmbxReviewDictionary.DataSource = dictionaries;
            cmbxReviewDictionary.SelectedIndex = 0;
            RefreshReviewPosition();
        }

        private void btnImportKindleMate_Click(object sender, EventArgs e)
        {
            var dictFile = (TranslationDictionaryFile)cmbxDictionaries.SelectedValue;
            var changed = _dictionaryService.ImportAsync(tbKindleMateFile.Text, dictFile).GetAwaiter().GetResult();
            MessageBox.Show("Finished. Changed=" + changed);
        }

        private void btnOpenKindleMateFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                tbKindleMateFile.Text = ofd.FileName;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void RefreshReviewPosition()
        {
            lReviewPosition.Text = $"{(_currentReviewIndex + 1)}/{_reviewItems.Count}";
            btnReviewPrevious.Enabled = _currentReviewIndex > 0;
            btnReviewNext.Enabled = _currentReviewIndex < _reviewItems.Count;
            if (_currentReviewIndex >= 0)
            {
                var reviewItem = _reviewItems[_currentReviewIndex];
                tbReviewSentence.Text = reviewItem.Sentence.Text;
                tbReviewWord.Text = reviewItem.Word.Text;
            }
            ClearReviewTranslation();
        }

        private void btnReviewNew_Click(object sender, EventArgs e)
        {
            var currentDictFile = (TranslationDictionaryFile)cmbxReviewDictionary.SelectedValue;
            var dict = currentDictFile.Dictionary;
            var itemIndex = _random.Next(0, dict.Translations.Count);
            var reviewItem = dict.Translations[itemIndex];
            _reviewItems.Add(reviewItem);
            _currentReviewIndex = _reviewItems.Count - 1;           
            RefreshReviewPosition();            
        }

        private void ClearReviewTranslation()
        {
            tbReviewTranslationSentenceAzure.Text = "";
            tbReviewTranslationSentenceGoogle.Text = "";
            tbReviewTranslationWordAzure.Text = "";
            tbReviewTranslationWordGoogle.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbReviewWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbReviewSentence_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbReviewTranslationWordGoogle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReviewTranslate_Click(object sender, EventArgs e)
        {
            var reviewItem = _reviewItems[_currentReviewIndex];
            tbReviewTranslationWordAzure.Text = reviewItem.Word.AzureText;
            tbReviewTranslationWordGoogle.Text = reviewItem.Word.GoogleText;
            tbReviewTranslationSentenceAzure.Text = reviewItem.Sentence.AzureText;
            tbReviewTranslationSentenceGoogle.Text = reviewItem.Sentence.GoogleText;
        }

        private void tbReviewTranslationSentenceAzure_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReviewRepeat_Click(object sender, EventArgs e)
        {
            ClearReviewTranslation();
        }

        private void btnReviewPrevious_Click(object sender, EventArgs e)
        {
            _currentReviewIndex--;
            RefreshReviewPosition();
        }

        private void btnReviewNext_Click(object sender, EventArgs e)
        {
            _currentReviewIndex++;
            RefreshReviewPosition();
        }
    }
}
