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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Lab02
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void LoadDrives()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode rootNode = new TreeNode(drive.Name)
                {
                    Tag = drive.RootDirectory
                };
                treeView.Nodes.Add(rootNode);
                LoadDummyNode(rootNode);
            }
        }

        private void LoadDummyNode(TreeNode node)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(node.Tag.ToString());
                if (directoryInfo.GetDirectories().Any() || directoryInfo.GetFiles().Any())
                {
                    node.Nodes.Add(new TreeNode());
                }
            }
            catch (UnauthorizedAccessException) { }
        }

        private void LoadDirectories(TreeNode node)
        {
            var directoryInfo = new DirectoryInfo(node.Tag.ToString());
            try
            {
                node.Nodes.Clear();

                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var dirNode = new TreeNode(directory.Name) { Tag = directory.FullName };
                    node.Nodes.Add(dirNode);
                    LoadDummyNode(dirNode);
                }

                foreach (var file in directoryInfo.GetFiles())
                {
                    var fileNode = new TreeNode(file.Name) { Tag = file.FullName };
                    node.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException) { }
        }

        private void treeView_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null)
            {
                LoadDirectories(node);
            }
            else
            {
                string filePath = node.Tag as string;
                if (File.Exists(filePath))
                {
                    OpenFile(filePath);
                }

            }
        }

        private void OpenFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".txt")
            {
                pictureBox.Visible = false;
                richtb.Text = File.ReadAllText(filePath);
            }
            else if (extension == ".jpg" || extension == ".png")
            {
                pictureBox.Visible = true;
                pictureBox.Image = Image.FromFile(filePath);
            }
            else
            {
                MessageBox.Show("Không hỗ trợ định dạng tệp này.");
            }
        }

    }

}

