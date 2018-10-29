using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteContentCrawler
{
    public partial class RegexEditor : Form
    {
        public string Regex { get; set; }
        public RegexEditor(string regex = "")
        {
            InitializeComponent();
            Regex = regex;
            txtRegex.Text = regex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex = txtRegex.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
