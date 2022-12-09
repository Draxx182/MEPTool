using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;
using TruthTable.Visual;
using TruthTable.NodeBase;

namespace TruthTable.MEP
{
    partial class MEPClass
    {
        private ToolStrip MEPBar;
        private Panel nodeInfoPanel;
        private Panel nodeUnknownPanel;
        private Panel nodeExtraPanel;
        private TreeView view;

        private void FormUIElements()
        {
            // Initializer & TreeView
            var fileName = Path.GetFileName(pathString);
            view = Initializer.CreateTreeView(new Point(0, 25), new Size(216, 374));
            view.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);

            // TabPage
            TabPage NewTab = Initializer.CreateTab(fileName, new Point(4, 22), new Size(792, 399));

            // MEPStrip
            MEPBar = Initializer.CreateToolStrip(new Point(3, 3), new Size(487, 25));

            // Panel
            nodeInfoPanel = Initializer.CreatePanel(new Point(216, 25), new Size(415, 235));
            nodeUnknownPanel = Initializer.CreatePanel(new Point(216, 260), new Size(415, 295));
            nodeExtraPanel = Initializer.CreatePanel(new Point(631, 25), new Size(415, 530));
            /*
            Panel panel2 = Initializer.CreateNodePanel(new Point(0, 0), new Size(338, 100));
            Panel panel3 = Initializer.CreateNodePanel(new Point(0, 100), new Size(320, 100));
            Panel panel4 = Initializer.CreateNodePanel(new Point(0, 200), new Size(320, 170));
            Panel panel5 = Initializer.CreateNodePanel(new Point(0, 370), new Size(320, 200));
            Label exampleHeaderLabel = Initializer.CreateHeaderLabel(new Point(0, 2), new Size(320, 35), "Example Header");
            Label exampleVariableLabel = Initializer.CreateTextLabel(new Point(0, 50), new Size(160, 15), "Example Variable:");
            TextBox exampleVariableTextBox = Initializer.CreateTextBox(new Point(163, 49), new Size(100, 15));            
            panel.Controls.Add(panel2);
            */

            // HexBox

            // Page Addons
            NewTab.Controls.Add(view);
            NewTab.Controls.Add(MEPBar);
            NewTab.Controls.Add(nodeInfoPanel);
            NewTab.Controls.Add(nodeUnknownPanel);
            NewTab.Controls.Add(nodeExtraPanel);
            control.TabPages.Add(NewTab);
            MenuCreate();
        }

        private void CheckPanel(NodePanel checkPanel, Panel targetPanel)
        {
            targetPanel.BackColor = SystemColors.Window;
            if (!checkPanel.Empty)
            {
                targetPanel.Controls.Add(checkPanel);
            }
            else
            {
                targetPanel.BackColor = SystemColors.ControlDarkDark;
            }
        }

        // *---------*
        // TreeView
        // *---------*
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nodeInfoPanel.VerticalScroll.Value = 0;
            nodeInfoPanel.Controls.Clear();
            nodeUnknownPanel.VerticalScroll.Value = 0;
            nodeUnknownPanel.Controls.Clear();
            nodeExtraPanel.VerticalScroll.Value = 0;
            nodeExtraPanel.Controls.Clear();
            Element currentElement = (Element) view.SelectedNode;
            foreach (NodePanel panel in currentElement.MainPanels) CheckPanel(panel, nodeInfoPanel);
            foreach (NodePanel panel in currentElement.UnkPanels) CheckPanel(panel, nodeUnknownPanel);
            foreach (NodePanel panel in currentElement.ListOfPanels) CheckPanel(panel, nodeExtraPanel);
        }

        // *---------*
        // DataGridView
        // *---------*
        private void DataGridView_RowsAdded(object sender, EventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            grid.Columns[0].Width = 150;
            grid.Columns[1].Width = 150;
        }

        // *---------*
        // ListBox
        // *---------*

        /// <summary>
        /// Changes listbox selected index based on which list was selected
        /// </summary>
        /*
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Creative solution, I know.
            if (sender == enumList1)
            {
                enumList2.SelectedIndex = enumList1.SelectedIndex;
            }
            else
            {
                enumList1.SelectedIndex = enumList2.SelectedIndex;
            }
            ActiveElement.enumedTable[0].Value = enumList1.SelectedItem;
        }
        */

        /*
        // https://www.youtube.com/watch?v=_XBet_gEycg&ab_channel=ProgrammingwithProfessorSluiter
        // Thanks, Professor Sluiter.
        private void Picture_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                // colorPicture.BackColor = colorPicker.Color;

                CheckPictureBox(colorPicker.Color);
            }
        }
        */

        /*
        private void CheckPictureBox(Color color)
        {
            RowElement currentRow = ActiveElement.colorTable[0];
            Type type = currentRow.DataType;
            if (type == typeof(float))
            {
                float red = Convert.ToSingle(color.R) / 100;
                float green = Convert.ToSingle(color.G) / 100;
                float blue = Convert.ToSingle(color.B) / 100;

                ActiveElement.Red = red;
                ActiveElement.Green = green;
                ActiveElement.Blue = blue;

                for (int i = 0; i < 3; i++)
                {
                    RowElement row = ActiveElement.colorTable[i];
                    if (row.Description == "Red")
                    {
                        row.Value = red;
                    }
                    if (row.Description == "Green")
                    {
                        row.Value = green;
                    }
                    if (row.Description == "Blue")
                    {
                        row.Value = blue;
                    }
                }
            }
        }
        */

        /*
        private void variableListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Checks if listbox is empty
            if (e.Index < 0) return;
            ListBox drawListBox;

            if (sender == enumList1)
            {
                drawListBox = enumList1;
            }
            else
            {
                drawListBox = enumList2;
            }

            // If the item is selected, change background color
            // https://stackoverflow.com/questions/3663704/how-to-change-listbox-selection-background-color
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index,
                e.State ^ DrawItemState.Selected,
                e.ForeColor, Color.LightGray);

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            // Draw (dashed) connection line
            // https://stackoverflow.com/questions/6100573/how-to-draw-a-dashed-line-over-an-object
            Pen separatorPen = new Pen(Color.Black, 0.5F);
            float[] dashValues = { 2, 2 };
            separatorPen.DashPattern = dashValues;

            // Draw String
            Single strX = e.Bounds.X - 1;
            Single strY = e.Bounds.Y - 1;
            Single strWidth = e.Bounds.Width - 1;
            Single strHeight = e.Bounds.Height;
            RectangleF strBounds = new RectangleF(strX, strY, strWidth, strHeight);

            // Draw the item text
            e.Graphics.DrawString(drawListBox.Items[e.Index].ToString(),
            e.Font, Brushes.Black, strBounds, StringFormat.GenericDefault);

            // Draw rectangle
            int rectX = e.Bounds.X - 1;
            int rectY = e.Bounds.Y - 1;
            int rectWidth = e.Bounds.Width + 3;
            int rectHeight = e.Bounds.Height + 1;
            e.Graphics.DrawRectangle(separatorPen, rectX, rectY, rectWidth, rectHeight);
        }
        */
    }
}
