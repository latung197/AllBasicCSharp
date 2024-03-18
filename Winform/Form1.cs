using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form1 : Form
    {
        private TreeView treeView;
        private Button butTon;
        private TreeViewCancelEventHandler treeViewCancelEventHandler;
        public Form1()
        {
            addConTrol();
            InitializeComponent();

        }

        public void addConTrol()
        {
            treeView = new TreeView();
            butTon = new Button();
            this.SuspendLayout();
            treeView.Anchor = AnchorStyles.Top | AnchorStyles.Left |
    AnchorStyles.Bottom | AnchorStyles.Right;
            treeView.CheckBoxes = true;
            TreeNode node;
            for (int x = 0; x < 3; ++x)
            {
                // Add a root node.
                node = treeView.Nodes.Add(String.Format("Node{0}", x * 4));
                //for (int y = 1; y < 4; ++y)
                //{
                //    // Add a node as a child of the previously added node.
                //    node = node.Nodes.Add(String.Format("Node{0}", x * 4 + y));
                //}
            }

            // Initialize showCheckedNodesButton.
            butTon.Size = new Size(144, 24);
            butTon.Text = "Show Checked Nodes";
            butTon.Click +=
                new EventHandler(showCheckedNodesButton_Click);

            treeView.Location = new Point(0, 25);
            this.ClientSize = new Size(292, 273);
            this.Controls.Add(treeView);
            this.ResumeLayout(false);

        }

        private void showCheckedNodesButton_Click(object sender, EventArgs e)
        {
            // Disable redrawing of treeView1 to prevent flickering 
            // while changes are made.
            treeView.BeginUpdate();

            // Collapse all nodes of treeView1.
            treeView.CollapseAll();

            // Add the checkForCheckedChildren event handler to the BeforeExpand event.
            treeView.BeforeExpand += treeViewCancelEventHandler;

            // Expand all nodes of treeView1. Nodes without checked children are 
            // prevented from expanding by the checkForCheckedChildren event handler.
            treeView.ExpandAll();

            // Remove the checkForCheckedChildren event handler from the BeforeExpand 
            // event so manual node expansion will work correctly.
            treeView.BeforeExpand -= treeViewCancelEventHandler;

            // Enable redrawing of treeView1.
            treeView.EndUpdate();
        }

        private void CheckForCheckedChildrenHandler(object sender,
    TreeViewCancelEventArgs e)
        {
            if (!HasCheckedChildNodes(e.Node)) e.Cancel = true;
        }

        private bool HasCheckedChildNodes(TreeNode node)
        {
            if (node.Nodes.Count == 0) return false;
            foreach (TreeNode childNode in node.Nodes)
            {
                if (childNode.Checked) return true;
                // Recursively check the children of the current child node.
                if (HasCheckedChildNodes(childNode)) return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
