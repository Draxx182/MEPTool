using System;
using System.Drawing;
using System.Windows.Forms;
using TruthTable.NodeBase;
using TruthTable.Visual;

namespace TruthTable.MEP
{
    partial class MEPClass
    {
        private Element ActiveCopiedElement;

        public void MenuCreate()
        {
            // Takes from MEPBuild
            ToolStripMenuItem createLimbFlash = Initializer.CreateStripItem("Limb Flash", new Size(121, 22));
            //createLimbFlash.Click += new EventHandler(Build_Limflash);
            ToolStripDropDownButton addButton = Initializer.CreateStripDropButton("Add", new Size(54, 22));
            addButton.DropDownItems.Add(createLimbFlash);
            MEPBar.Items.Add(addButton);

            ToolStripButton deleteButton = Initializer.CreateStripButton("Delete", new Size(44, 22));
            //deleteButton.Click += new EventHandler(Delete_Click);
            MEPBar.Items.Add(deleteButton);

            MEPBar.Items.Add(Initializer.CreateStripSeperator("Sep1", new Size(6, 25)));
            ToolStripButton copyButton = Initializer.CreateStripButton("Copy", new Size(44, 22));
            //copyButton.Click += new EventHandler(Copy_Click);
            MEPBar.Items.Add(copyButton);

            ToolStripButton pasteButton = Initializer.CreateStripButton("Paste", new Size(44, 22));
            //pasteButton.Click += new EventHandler(Paste_Click);
            MEPBar.Items.Add(pasteButton);
        }

        /*
        private void Build_Limflash(object sender, EventArgs e)
        {
            Element baseElement = Initializer.Root;
            baseElement.AddBase("Limb Flash");

        }
        */

        /*
        private void Delete_Click(object sender, EventArgs e)
        {
            if (ActiveTreeElement == null) // Checks if any node is selected at all
            {
                return;
            }
            if (ActiveTreeElement.Element.CanDelete) // Checks if Element can be deleted
            {
                RecursiveDelete(ActiveTreeElement);
            }
            else
            {
                MessageBox.Show("Node designated as non-deletable.", "Cannot Delete Node",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void RecursiveDelete(TreeElement parent)
        {
            if (parent == null)
            {
                return;
            }
            if (parent.Nodes != null && parent.Nodes.Count > 0)
            {
                foreach (TreeElement node in parent.Nodes)
                {
                    RecursiveDelete(node);
                }
            }
            parent.Element = null;
            parent.Parent.Nodes.Remove(parent);
        }

        /*
        private void Copy_Click(object sender, EventArgs e)
        {
            if (view.SelectedNode == null) return;
            if (ActiveTreeElement.Element.CanCopy == false)
            {
                MessageBox.Show("Node designated as non-copyable.", "Cannot Copy Node",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        */

        /*
        private void Paste_Click(object sender, EventArgs e)
        {
            if (ActiveCopiedElement == null) return;
            Initializer.Root.ElementNode.Nodes.Add(ActiveCopiedElement.ElementNode);
            Initializer.Root.ElementNode.Element.Children.Add(ActiveCopiedElement);
        }
        */
    }
}
