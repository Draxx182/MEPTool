using System;
using System.Windows.Forms;
using System.Drawing;
using TruthTable.Visual;
using TruthTable.NodeBase;

/*
Initializes the tab created to fit in with the TabControl
Initializes the basic elements to put in that TabControl (ListBox, DataGridView, etc)
Initializes identification of what script to use when magic is read (Refer to the Templates folder)
*/
namespace TruthTable
{
    static class Initializer
    {
        static public Element Root;

        // *---------------------------------------------------------------------*
        // Tool Strip Visual Elements
        // *---------------------------------------------------------------------*

        /// <summary>
        /// Creates a Tool Strip Seperator with given variables.
        /// </summary>
        /// <param name="text"> Defines both the text of the separator and code name. </param>
        /// <param name="size"> Defines how big the separator will be. </param>
        /// <returns> Returns created Tool Strip Separator. </returns>
        static public ToolStripSeparator CreateStripSeperator(string text, Size size)
        {
            ToolStripSeparator variableToolStripSepartor = new ToolStripSeparator();
            variableToolStripSepartor.Name = text;
            variableToolStripSepartor.Size = size;
            variableToolStripSepartor.Text = text;
            return variableToolStripSepartor;
        }

        /// <summary>
        /// Creates a Tool Strip Button with given variables.
        /// </summary>
        /// <param name="text"> Defines both the text of the button and code name. </param>
        /// <param name="size"> Defines how big the button will be. </param>
        /// <returns> Returns created Tool Strip Button. </returns>
        static public ToolStripButton CreateStripButton(string text, Size size)
        {
            ToolStripButton variableToolStripButton = new ToolStripButton();
            variableToolStripButton.BackColor = Color.Transparent;
            variableToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            variableToolStripButton.ImageTransparentColor = Color.Magenta;
            variableToolStripButton.Name = text;
            variableToolStripButton.Size = size;
            variableToolStripButton.Text = text;
            variableToolStripButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            return variableToolStripButton;
        }

        /// <summary>
        /// Creates a Tool Strip Drop Down Button with given variables.
        /// </summary>
        /// <param name="text"> Defines both the text of the button and code name. </param>
        /// <param name="size"> Defines how big the button will be. </param>
        /// <returns> Returns created Tool Strip Drop Down Button. </returns>
        static public ToolStripDropDownButton CreateStripDropButton(string text, Size size)
        {
            ToolStripDropDownButton variableDropDownButton = new ToolStripDropDownButton();
            variableDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            variableDropDownButton.ImageTransparentColor = Color.Magenta;
            variableDropDownButton.Name = text;
            variableDropDownButton.Size = size;
            variableDropDownButton.Text = text;
            return variableDropDownButton;
        }

        /// <summary>
        /// Creates a Tool Strip Menu Item with given variables.
        /// </summary>
        /// <param name="text"> Defines both the text of the item and code name. </param>
        /// <param name="buttonFunction"> Defines item's EventHandler when clicked (Can be Null).</param>
        /// <param name="size"> Defines how big the item will be. </param>
        /// <returns> Returns created Tool Strip Menu Item. </returns>
        static public ToolStripMenuItem CreateStripItem(string text, Size size)
        {
            ToolStripMenuItem variableStripItem = new ToolStripMenuItem();
            variableStripItem.Name = text;
            variableStripItem.Size = size;
            variableStripItem.Text = text;
            return variableStripItem;
        }

        // *---------------------------------------------------------------------*
        // Node Visual Elements
        // *---------------------------------------------------------------------*

        static public Panel CreatePanel(Point location, Size size)
        {
            Panel variablePanel = new Panel();
            variablePanel.HorizontalScroll.Maximum = 0;
            variablePanel.VerticalScroll.Visible = true;
            variablePanel.HorizontalScroll.Visible = false;
            variablePanel.AutoScroll = true;
            variablePanel.BackColor = SystemColors.Window;
            variablePanel.BorderStyle = BorderStyle.FixedSingle;
            variablePanel.Location = location;
            variablePanel.Size = size;
            variablePanel.TabIndex = 6;
            return variablePanel;
        }

        static public NodePanel CreateNodePanel(Point location, Size size)
        {
            NodePanel variableNodePanel = new NodePanel();
            variableNodePanel.AutoSize = false;
            variableNodePanel.BackColor = SystemColors.Menu;
            variableNodePanel.BorderStyle = BorderStyle.FixedSingle;
            variableNodePanel.Location = location;
            variableNodePanel.Size = size;
            variableNodePanel.TabIndex = 3;
            return variableNodePanel;
        }

        static public Label CreateHeaderLabel(Point location, Size size, string label)
        {
            Label variableLabel = new Label();
            variableLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            variableLabel.Location = location;
            variableLabel.Size = size;
            variableLabel.TabIndex = 0;
            variableLabel.Text = label;
            variableLabel.TextAlign = ContentAlignment.MiddleCenter;
            return variableLabel;
        }

        static public Label CreateTextLabel(Point location, Size size, string label)
        {
            Label variableLabel = new Label();
            variableLabel.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            variableLabel.ImageAlign = ContentAlignment.MiddleRight;
            variableLabel.Location = location;
            variableLabel.Size = size;
            variableLabel.TabIndex = 1;
            variableLabel.Text = label;
            variableLabel.TextAlign = ContentAlignment.MiddleRight;
            return variableLabel;
        }

        static public TextBox CreateTextBox(Point location, Size size, string initialValue = "")
        {
            TextBox variableTextBox = new TextBox();
            variableTextBox.Location = location;
            variableTextBox.Text = initialValue;
            variableTextBox.Size = size;
            variableTextBox.TabIndex = 2;
            return variableTextBox;
        }

        // *---------------------------------------------------------------------*
        // General Visual Elements: DataGridViews, ToolStrips, to create on the fly.
        // *---------------------------------------------------------------------*

        /// <summary>
        /// Creates a Tool Strip Visual Item with both a location and size.
        /// </summary>
        /// <param name="location"> Defines where the Tool Strip will be in GUI. </param>
        /// <param name="size"> Defines the size of the Tool Strip. </param>
        /// <returns> Returns the Tool Strip. </returns>
        static public ToolStrip CreateToolStrip(Point location, Size size)
        {
            ToolStrip variableToolStrip = new ToolStrip();
            variableToolStrip.BackColor = Color.WhiteSmoke;
            variableToolStrip.AutoSize = false;
            variableToolStrip.Location = location;
            variableToolStrip.Name = "InToolStrip";
            variableToolStrip.Size = size;
            variableToolStrip.TabIndex = 1;
            variableToolStrip.Text = "InToolStrip";
            return variableToolStrip;
        }

        /// <summary>
        /// Creates a ListBox Item with both a location and size.
        /// </summary>
        /// <param name="location"> Defines where the List Box will be in GUI. </param>
        /// <param name="size"> Defines the size of the List Box. </param>
        /// <returns> Returns the ListBox. </returns>
        static public ListBox CreateListBox(Point location, Size size)
        {
            ListBox variableListBox = new ListBox();
            variableListBox.FormattingEnabled = true;
            variableListBox.DrawMode = DrawMode.OwnerDrawFixed;
            variableListBox.DrawItem += new DrawItemEventHandler(VariableListBox_DrawItem);
            variableListBox.Location = location;
            variableListBox.MultiColumn = true;
            variableListBox.Name = "InListBox";
            variableListBox.Size = size;
            variableListBox.Visible = false;
            return variableListBox;
        }

        /// <summary>
        /// Edits the List Box's DrawItem to outline the items in its index.
        /// </summary>
        static private void VariableListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Checks if listbox is empty
            if (e.Index < 0) return;
            ListBox drawListBox = (ListBox) sender;

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


        /// <summary>
        /// Creates a TreeView with both a location and size.
        /// </summary>
        /// <param name="location"> Defines where the Tree View will be in GUI. </param>
        /// <param name="size"> Defines the size of the Tree View. </param>
        /// <returns> Returns the TreeView. </returns>
        static public TreeView CreateTreeView(Point location, Size size)
        {
            TreeView variableTreeView = new TreeView();
            variableTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            variableTreeView.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            variableTreeView.ItemHeight = 20;
            variableTreeView.Location = location;
            variableTreeView.Name = "InTreeView";
            variableTreeView.Size = size;
            variableTreeView.TabIndex = 5;
            return variableTreeView;
        }

        /// <summary>
        /// Creates a DataGridView with both a location and size.
        /// </summary>
        /// <param name="location"> Defines where the Data Grid View will be in GUI. </param>
        /// <param name="size"> Defines the size of the Data Grid View. </param>
        /// <returns> Returns the DataGridView. </returns>
        static public DataGridView CreateDataGridView(Point location, Size size)
        {
            DataGridView variableDataGrid = new DataGridView();
            variableDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            variableDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            variableDataGrid.Location = location;
            variableDataGrid.Name = "InGridView";
            variableDataGrid.Size = size;
            variableDataGrid.TabIndex = 4;
            variableDataGrid.AllowUserToAddRows = false;
            variableDataGrid.Visible = false;
            return variableDataGrid;
        }

        /*
        private void variableDataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (ActiveNodeElement.UIType == "ColorPicker")
            {
                RowElement currentRow = ActiveNodeElement.colorTable[rowIndex];
                OldValue = currentRow.Value;
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ActiveNodeElement.UIType == "ColorPicker")
            {
                int rowIndex = e.RowIndex;
                RowElement currentRow = ActiveNodeElement.colorTable[rowIndex];
                if (currentRow.Description == "Red")
                {
                    ActiveNodeElement.Red = currentRow.Value;
                }
                if (currentRow.Description == "Green")
                {
                    ActiveNodeElement.Green = currentRow.Value;
                }
                if (currentRow.Description == "Blue")
                {
                    ActiveNodeElement.Blue = currentRow.Value;
                }
                ActiveNodeElement.SetColor();
            }
        }
        */

        /// <summary>
        /// Creates a PictureBox with both a location and size.
        /// </summary>
        /// <param name="location"> Defines where the Picture Box will be in GUI. </param>
        /// <param name="size"> Defines the size of the Picture Box View. </param>
        /// <returns> Returns the PictureBox. </returns>
        static public PictureBox CreatePictureBox(Point location, Size size)
        {
            PictureBox variablePictureBox = new PictureBox();
            variablePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            variablePictureBox.Location = location;
            variablePictureBox.BackColor = Color.Black;
            variablePictureBox.Name = "InPictureBox";
            variablePictureBox.Size = size;
            variablePictureBox.TabIndex = 6;
            variablePictureBox.TabStop = false;
            variablePictureBox.Visible = false;
            return variablePictureBox;
        }

        /*
        private void CheckPictureBox(Color color)
        {
            RowElement currentRow = ActiveNodeElement.colorTable[0];
            Type type = currentRow.DataType;
            if (type == typeof(float))
            {
                float red = Convert.ToSingle(color.R) / 100;
                float green = Convert.ToSingle(color.G) / 100;
                float blue = Convert.ToSingle(color.B) / 100;

                ActiveNodeElement.Red = red;
                ActiveNodeElement.Green = green;
                ActiveNodeElement.Blue = blue;

                for (int i = 0; i < 3; i++)
                {
                    RowElement row = ActiveNodeElement.colorTable[i];
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

        /// <summary>
        /// Creates a PictureBox with both a location and size, as well as defining it's name
        /// </summary>
        /// <param name="name"> Defines the TabPage name. </param>
        /// <param name="location"> Defines where the Picture Box will be in GUI. </param>
        /// <param name="size"> Defines the size of the Picture Box View. </param>
        /// <returns> Returns the PictureBox. </returns>
        static public TabPage CreateTab(string name, Point location, Size size)
        {
            TabPage newTab = new TabPage();
            newTab.BackColor = Color.Gainsboro;
            newTab.BorderStyle = BorderStyle.FixedSingle;
            newTab.Location = location; // Point(4, 22)
            newTab.Name = name;
            newTab.Padding = new Padding(0);
            newTab.Size = size; // Size(792, 399)
            newTab.TabIndex = 0;
            newTab.Text = name;
            return newTab;
        }
    }
}
