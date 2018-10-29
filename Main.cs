using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteContentCrawler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartCrawler();
        }

        private void StartCrawler()
        {
            pbProgress.Style = ProgressBarStyle.Marquee;
            btnStart.Enabled = false;
            backgroundWorkerCrawl.RunWorkerAsync();
        }
        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var regexEditor = new RegexEditor();
            if (regexEditor.ShowDialog() == DialogResult.OK)
            {
                listBoxRegex.Items.Add(regexEditor.Regex);
            }
        }

        private void btnRegexSortUp_Click(object sender, EventArgs e)
        {
            MoveListBoxItem(ref listBoxRegex, -1);
        }

        private void btnRegexSortDown_Click(object sender, EventArgs e)
        {
            MoveListBoxItem(ref listBoxRegex, 1);
        }

        public void MoveListBoxItem(ref ListBox lstBox, int direction)
        {
            if (lstBox.SelectedItem == null || lstBox.SelectedIndex < 0)
            {
                return;
            }
            
            int newIndex = lstBox.SelectedIndex + direction;
            
            if (newIndex < 0 || newIndex >= lstBox.Items.Count)
            {
                return;
            }

            object selected = lstBox.SelectedItem;
            
            lstBox.Items.Remove(selected);
            lstBox.Items.Insert(newIndex, selected);
            lstBox.SetSelected(newIndex, true);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxRegex.SelectedItem == null || listBoxRegex.SelectedIndex < 0)
            {
                return;
            }

            var regexEditor = new RegexEditor(listBoxRegex.SelectedItem.ToString());
            if (regexEditor.ShowDialog() == DialogResult.OK)
            {
                listBoxRegex.Items[listBoxRegex.SelectedIndex] = regexEditor.Regex;
            }
            

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxRegex.SelectedItem == null || listBoxRegex.SelectedIndex < 0)
            {
                return;
            }
            listBoxRegex.Items.Remove(listBoxRegex.SelectedItem);
        }

        private void contextMenuRegex_Opening(object sender, CancelEventArgs e)
        {
            if (listBoxRegex.SelectedItem == null || listBoxRegex.SelectedIndex < 0)
            {
                removeToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            } else
            {
                removeToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
            }
        }

        private string[] GetRegexArray()
        {
            List<string> result = new List<string>();
            foreach (var item in listBoxRegex.Items)
            {
                result.Add(item.ToString());
            }
            return result.ToArray();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogRegex.ShowDialog() == DialogResult.OK) { 
                List<string> regexList = new List<string>();
                File.WriteAllLines(saveFileDialogRegex.FileName, GetRegexArray());
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialogRegex.ShowDialog() == DialogResult.OK)
            {
                listBoxRegex.Items.Clear();
                foreach (var item in File.ReadAllLines(openFileDialogRegex.FileName))
                {
                    listBoxRegex.Items.Add(item);
                }   
            }
        }

        private void backgroundWorkerCrawl_DoWork(object sender, DoWorkEventArgs e)
        {
            string savePath = txtSavePath.Text;
            Directory.CreateDirectory(savePath);

            List<Regex> regexList = new List<Regex>();
            List<string> urlList = new List<string>();

            urlList.AddRange(txtUrls.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
            if (checkBoxCountUp.Checked)
            {
                if(numericUpDownMinCountUp.Value < numericUpDownMaxCountUp.Value)
                {
                    List<string> urlListNew = new List<string>();
                    for (int i = 0; i < urlList.Count; i++)
                    {
                        for (int count = (int)numericUpDownMinCountUp.Value; count < (int)numericUpDownMaxCountUp.Value; count++)
                        {
                            
                            urlListNew.Add(urlList[i].Replace("{count}", count.ToString()));
                        }
                    }
                    urlList = urlListNew;
                    
                } else
                {
                    MessageBox.Show("Min Count cant be greater then Max Count");
                    return;
                }
               
            }
            foreach (var regex in GetRegexArray())
            {
                regexList.Add(new Regex(regex));
            }

            File.AppendAllLines(savePath + Path.DirectorySeparatorChar + "urls1.txt", Crawler.Crawl(regexList.ToArray(), urlList.ToArray()));
            
        }

        private void backgroundWorkerCrawl_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbProgress.Style = ProgressBarStyle.Blocks;
            btnStart.Enabled = true;
        }

        private void checkBoxCountUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCountUp.Checked)
            {
                numericUpDownMinCountUp.Enabled = true;
                numericUpDownMaxCountUp.Enabled = true;
            }
            else
            {
                numericUpDownMinCountUp.Enabled = false;
                numericUpDownMaxCountUp.Enabled = false;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialogUrlList.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogUrlList.FileName, txtUrls.Text);
            }
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialogUrlList.ShowDialog() == DialogResult.OK)
            {
                txtUrls.Text = File.ReadAllText(openFileDialogUrlList.FileName);
            }
        }
    }
}