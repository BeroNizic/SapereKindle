using System;
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
        public Form1()
        {
            InitializeComponent();
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
    }
}
