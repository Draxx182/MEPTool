using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.IO;
using TruthTable.MEP;

namespace TruthTable
{
    public partial class TruthTable : Form
    {
        public TruthTable()
        {
            InitializeComponent();
            /*
            mepSelector.MouseDown += mepSelector_MouseDown;
            mepSelector.MouseMove += mepSelector_MouseMove;
            */

            /*
            // Allows access to the DrawItem event. 
            mepSelector.DrawMode = TabDrawMode.OwnerDrawFixed;
            mepSelector.Padding = new System.Drawing.Point(8, 4);

            // Binds the event handler DrawOnTab to the DrawItem event 
            // through the DrawItemEventHandler delegate.
            mepSelector.DrawItem += new DrawItemEventHandler(DrawOnTab);*/
        }

        /*
        private void DrawOnTab(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Transparent_X, 7, 7);
            e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 14, e.Bounds.Top + 4);
            e.Graphics.DrawString(mepSelector.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }*/

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Opens file dialog, checks validity, then opens a stream and binary reader.
        private void fileOpenToDialog_Click(object sender, EventArgs e)
        {
            if (OpenMEPDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(OpenMEPDialog.FileName, FileMode.Open))
                {
                    using (var rd = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        FileIdentifier(rd, stream);
                    }
                }
            }
        }

        // Checks what script to use, as to not clutter the function above.
        private void FileIdentifier(BinaryReader rd, FileStream stream)
        {
            string magic = rd.ReadStringBytes(4);
            stream.Position = 0;
            switch (magic)
            {
                case "MEP_":
                    MEPClass newImporter = new MEPClass(rd, mepSelector, OpenMEPDialog.FileName);
                    break;
                default: // If no magic corresponds to any valid type
                    MessageBox.Show("There is no magic that aligns with any of your current templates.", "No Concurrent Magic",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /*
        //Mouse Event: Checks to see if User has clicked certain location to close selected tab.
        //Source for code: https://stackoverflow.com/questions/3183352/close-button-in-tabcontrol
        private void mepSelector_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle r = mepSelector.GetTabRect(mepSelector.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 9, r.Top + 4, 7, 7);
            //Checks if area clicked is the closed button
            if (closeButton.Contains(e.Location))
            {
                //Checks to see if there's only one tab available so user doesn't run out of tabs
                //Only a temporary solution, will fix later. (remind me once users start complaining)
                if (mepSelector.TabPages.Count != 1) 
                {
                    mepSelector.TabPages.Remove(mepSelector.SelectedTab);
                }
            }
        }

        private void mepSelector_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle mouseRect = new Rectangle(e.X, e.Y, 1, 1);
            for (int i = 0; i < mepSelector.TabCount; i++)
            {
                if (mepSelector.GetTabRect(i).IntersectsWith(mouseRect))
                {
                    mepSelector.SelectedIndex = i;
                    break;
                }
            }
        }
        */

        private void Start_Click(object sender, EventArgs e)
        {

        }

        //Exits the Application
        private void fileApplicationClose_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileTabPageClose_Click(object sender, EventArgs e)
        {
            mepSelector.TabPages.Remove(mepSelector.SelectedTab);
        }

        private void fileTabAllClose_Click(object sender, EventArgs e)
        {
            mepSelector.TabPages.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolDeleteNode_Click(object sender, EventArgs e)
        {
            
        }

        private void toolAddNode_Click(object sender, EventArgs e)
        {
            
        }

        private void addLimFlash_click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deleteProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExampleVariable_Click(object sender, EventArgs e)
        {

        }

        private void ExampleLabelHeader_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
