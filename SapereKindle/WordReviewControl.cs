using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SapereKindle
{
    public partial class WordReviewControl : UserControl
    {
        private string _word;
        private string _translation;
        private SynonymsAntonyms _synonymsAntonyms;

        public WordReviewControl()
        {
            InitializeComponent();
        }

        public WordReviewControl(string word, string translation)
        {
            InitializeComponent();
            _word = word;
            _translation = translation;
        }

        private void WordReviewControl_Load(object sender, EventArgs e)
        {
            lWord.Text = _word;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tbTranslation.Text = _translation;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (_synonymsAntonyms == null)
            {
                _synonymsAntonyms = SynonymsAntonymsUtil.GetAsync(_word).GetAwaiter().GetResult();
            }
            var saForm = new FormSynonymsAntonyms(_synonymsAntonyms);
            saForm.ShowDialog();
        }
    }
}
