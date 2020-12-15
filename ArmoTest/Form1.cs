using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmoTest
{
    public partial class Form1 : Form, IFilesDataReceiver
    {
        FileSearcher fileSearcher;
        int filesFound;

        public Form1()
        {
            InitializeComponent();

            StartDirTextBox.Text = Properties.Settings.Default.StartDirectoryPath;
            SearchPatternTextBox.Text = Properties.Settings.Default.SearchPattern;

            fileSearcher = new FileSearcher();
            fileSearcher.Subscribe(this);
        }

        public void AddNewFilePath(TreeNode node)
        {
            this.BeginInvoke(new Action(() =>
            {
                AddNode(node);

                filesFound++;
                filesFoundLabel.Text = $"Файлов найдено: {filesFound}";
            }));

        }

        private void AddNode(TreeNode node)
        {
            TreeNodeCollection formNodes = FileTreeView.Nodes;

            bool flag = false;
            
            while (!flag)
            {
                foreach(TreeNode n in formNodes)
                {
                    if(n.Text.Equals(node.Text))
                    {
                        flag = true;
                        formNodes = n.Nodes;
                        break;

                    }
                }
                if (flag)
                {
                    node = node.Nodes[0];

                    flag = false;
                }
                else
                {
                    break;
                }
                
            }

            formNodes.Add(node);
        }

        public void UpdateCurrentDirData(string currentDir, int filesCount, int currentFileNum)
        {
            this.BeginInvoke(new Action(() =>
            {
                CurrentFileDataLabel.Text = $"{currentFileNum}/{filesCount} {currentDir}";


                
                FileProcessingProgressBar.Value = currentFileNum;
                if (filesCount < currentFileNum)
                {
                    FileProcessingProgressBar.Maximum = currentFileNum;
                }
                else
                {
                    FileProcessingProgressBar.Maximum = filesCount;
                }
                
            }));

        }

        private void PauseSearchButton_Click(object sender, EventArgs e)
        {
            if(fileSearcher.IsSearchPaused == true)
            {
                fileSearcher.IsSearchPaused = false;
                PauseSearchButton.Text = "Пауза";

                TerminateSearchButton.Visible = false;
            }
            else
            {
                fileSearcher.IsSearchPaused = true;
                PauseSearchButton.Text = "Продолжить";

                TerminateSearchButton.Visible = true;
            }
            
        }

        private async void StartSearchButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(StartDirTextBox.Text))
            {
                StartSearchButton.Enabled = false;

                ProcessingPanel.Visible = true;
                filesFound = 0;
                filesFoundLabel.Text = "Файлов найдено: ";
                FileProcessingProgressBar.Value = 0;
                CurrentFileDataLabel.Text = "";
                TerminateSearchButton.Visible = false;
                PauseSearchButton.Visible = true;
                FileTreeView.Nodes.Clear();

                await fileSearcher.StartSearchAsync(StartDirTextBox.Text, SearchPatternTextBox.Text);

                PauseSearchButton.Visible = false;
                StartSearchButton.Enabled = true;
            }
        }

        private void ChoseDirButton_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fb = new FolderBrowserDialog())
            {
                if(fb.ShowDialog() == DialogResult.OK)
                {
                    StartDirTextBox.Text = fb.SelectedPath;
                }
            }
        }

        private void TerminateSearchButton_Click(object sender, EventArgs e)
        {
            fileSearcher.IsSearchCanseled = true;
            ProcessingPanel.Visible = false;
            CurrentFileDataLabel.Text = "";
            FileProcessingProgressBar.Value = 0;
            StartSearchButton.Enabled = true;

            SetProcessingPanelToBeginState();
        }


        private void StartDirTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartDirectoryPath = StartDirTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void SearchPatternTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SearchPattern = SearchPatternTextBox.Text;
            Properties.Settings.Default.Save();
        }


        private void SetProcessingPanelToBeginState()
        {
            ProcessingPanel.Visible = false;

            fileSearcher.IsSearchPaused = false;
            PauseSearchButton.Text = "Пауза";

            TerminateSearchButton.Visible = false;
        }
    }
}
