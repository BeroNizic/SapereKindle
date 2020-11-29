using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SapereKindle
{
    public partial class FormSynonymsAntonyms : Form
    {
        public FormSynonymsAntonyms()
        {
            InitializeComponent();
        }

        public FormSynonymsAntonyms(SynonymsAntonyms sa)
        {
            InitializeComponent();
            lbAntonyms.DataSource = sa.Antonyms;
            lbSynonyms.DataSource = sa.Synonyms;
            lWord.Text = sa.Word;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSynonymsAntonyms_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
