using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace searchStr
{
    public partial class searchStr_result : Form
    {
        //StreamWriter log;
        private string strQuery;
        Regex rgxExtensions;
        private string strRoot;
        private string strOptions;

        public searchStr_result()
        {
            InitializeComponent();
        }
        public searchStr_result(string strQuery, string[] arrExtensions, string strRoot, bool boolRegex, bool boolCase, bool boolExact)
        {
            InitializeComponent();
            this.strQuery = strQuery;
            string strExtensions = ".*\\.(";
            for (int i = 0; i < arrExtensions.Length; ++i)
            {
                strExtensions += arrExtensions[i] + "|";
            }
            this.rgxExtensions = new Regex(strExtensions.TrimEnd('|') + ")");
            this.strRoot = strRoot;
            strOptions = "/n";
            if (boolRegex)
            {
                strOptions += " /r";
            } else
            {
                strOptions += " /l";
            }
            if (!boolCase)
                strOptions += " /i";
            if (boolExact)
                this.strQuery = " /c:" + this.strQuery;
            trvResult.ImageList = imgIcons;
            //log = File.AppendText(DateTime.Now.ToString("yyyyMMdd-HH-mm-ss") + "-log.txt");
            populateTree();
        }
        private void populateTree()
        {
            DataNode rootNode = new DataNode(strRoot.TrimEnd('\\')) { ImageIndex = 0, SelectedImageIndex = 0};
            trvResult.Nodes.Add(rootNode);
            DataNode placeholder = new DataNode("Loading...") { ImageIndex = 2, SelectedImageIndex = 2 };
            rootNode.Nodes.Add(placeholder);
            populateBranch(rootNode);
            rootNode.Expand();
        }
        private void populateBranch(DataNode node)
        {
            if (!node.isLoaded)
            { 
                try
                {
                    node.FirstNode.Remove();
                    node.isLoaded = true;
                    string[] dirs = Directory.GetDirectories(node.FullPath + '\\');
                    
                    for (int i = 0; i < dirs.Length; ++i)
                    {
                        string dir = dirs[i].TrimEnd('\\').Split('\\').Last();
                        DataNode newNode = new DataNode(dir) { ImageIndex = 0, SelectedImageIndex = 0 };
                        DataNode placeholder = new DataNode("Loading...") {ImageIndex = 2, SelectedImageIndex = 2};
                        newNode.Nodes.Add(placeholder);
                        node.Nodes.Add(newNode);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to get Directory contents.");
                }
                searchFiles(node);
            }

        }
        private void searchFiles(DataNode node)
        {
            try
            {
                string[] files = Directory.GetFiles(node.FullPath + '\\');
                foreach (string file in files)
                {
                    if (rgxExtensions.IsMatch(file))
                    {
                        string result = searchFileContents(file);
                        if (!String.IsNullOrEmpty(result))
                        {
                            string filename = file.Split('\\').Last();
                            DataNode newNode = new DataNode(filename) { ImageIndex = 1, SelectedImageIndex = 1, isFile = true };
                            newNode.setData(result);
                            node.Nodes.Add(newNode);
                            }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to get Directory contents.");
            }
        }
        private string searchFileContents(string file)
        {

            //startInfo.Arguments = strOptions + " " + strQuery + " " + file;
            //startInfo.FileName = "findstr";
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c findstr " + strOptions + " " + strQuery + " \"" + file.Replace("\\", "\\\\") + "\"",
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            //txtFile.Text += processStartInfo.Arguments;
            var process = Process.Start(processStartInfo);
            process.WaitForExit();
            var output = process.StandardOutput.ReadToEnd();
            return output;
        }

        private void searchStr_result_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = (searchStr_home)Tag;
            form1.Show();
        }

        private void trvResult_AfterExpand(object sender, TreeViewEventArgs e)
        {
            populateBranch((DataNode)e.Node);
        }

        private void trvResult_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DataNode activeNode = (DataNode)e.Node;
            if (activeNode.isFile)
            {
                txtFilename.Text = activeNode.FullPath;
                txtFile.Text = activeNode.getData();
            }
        }
    }
}
