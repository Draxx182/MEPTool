using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TruthTable.Visual;

namespace TruthTable.NodeBase
{
    partial class Element : TreeNode
    {
        private List<NodePanel> listOfPanels = new List<NodePanel>();
        private List<NodePanel> mainNodePanels = new List<NodePanel>();
        private List<NodePanel> unkNodePanels = new List<NodePanel>();
        private NodePanel currentPanel;
        private int panelOffset = 0;
        private Size panelSizes;

        // Properties
        public List<NodePanel> ListOfPanels
        {
            get { return listOfPanels; }
            set { listOfPanels = value; }
        }

        public List<NodePanel> MainPanels
        {
            get { return mainNodePanels; }
            set { mainNodePanels = value; }
        }

        public List<NodePanel> UnkPanels
        {
            get { return unkNodePanels; }
            set { unkNodePanels = value; }
        }

        public NodePanel CurrentPanel
        {
            get { return currentPanel; }
            set { currentPanel = value; }
        }

        // Structure

        // Variables
        private const string defaultName = "Unk";
        private bool isBigEndian = true;
        private BinaryReader rd;
        private Stream fileStream;
        private bool expand;
        public TableElement dataTable;
        public List<Element> Children = new List<Element>();
        public string UIType;
        public bool CanDelete;
        public bool CanCopy;

        // *---------------------------------------------------------------------*
        // Private functions, for the class to use and to add readability.
        // *---------------------------------------------------------------------*

        /*
        /// <summary>
        /// Adds row data to DataTable.
        /// </summary>
        /// <param name="name"> Names the description of the row. </param>
        /// <param name="type"> Names the DataType of the row. </param>
        /// <param name="data"> Inserts the actual value of the data. </param>
        private void AddRowToDT(TableElement table, string name, object data)
        {
            RowElement rowData = table.NewRowElement();
            rowData.Description = name;
            rowData.Value = data;
            rowData.DataType = data.GetType();
            table.Add(rowData);
        }
        */

        public NodePanel AddPanel(string panelHeader, List<NodePanel> selectedList)
        {
            panelOffset = 0;
            foreach (NodePanel panel in selectedList) panelOffset += panel.Height;
            NodePanel returnPanel = Initializer.CreateNodePanel(new Point(0, panelOffset), panelSizes);
            returnPanel.AddHeader(panelHeader);
            currentPanel = returnPanel;
            selectedList.Add(returnPanel);
            return returnPanel;
        }

        // *---------------------------------------------------------------------*
        // Constructors, based off TreeView and TreeElement
        // *---------------------------------------------------------------------*

        /// <summary>
        /// A base for this program's Binary Reading and UI functions. Sets the variables needed for the class.
        /// </summary>
        /// <param name="baseTree"> The element will be tied to a specific TreeView. </param>
        /// <param name="baseReader"> Sets the Binary Reader to pass on between different Elements. </param>
        /// <param name="name"> The name of the base node listed in the TreeView. </param>
        /// <param name="expanded"> Sets if the element will preload the node as expanded. </param>
        public Element(TreeView baseTree, BinaryReader baseReader, Size nodeSize, string name = defaultName, bool expanded = false)
        {
            Text = name;
            Name = name;
            fileStream = baseReader.BaseStream;
            if (expanded)
            {
                Expand();
            }
            rd = baseReader;
            UIType = null;

            panelSizes = nodeSize;
            CanDelete = false;
            AddPanel("Node Info", mainNodePanels);
            AddPanel("Unknown Information", unkNodePanels);
            AddPanel("Extra Info", listOfPanels);
            baseTree.Nodes.Add(this);
        }

        /// <summary>
        /// A node to be added upon other Elements, branching off from each other.
        /// </summary>
        /// <param name="baseNode"> The element will be tied to a specific TreeElement. </param>
        /// <param name="baseReader"> Sets the Binary Reader to pass on between different Elements. </param>
        /// <param name="name"> The name of the base node listed in the TreeNode. </param>
        /// <param name="expanded"> Sets if the element will preload the node as expanded. </param>
        /// <param name="uiType"> Sets the UI type of the Element to help decide what UI elements to load. </param>
        /// <param name="size"> Sets the size for a DataArray. </param>
        public Element(Element baseNode, BinaryReader baseReader, Size nodeSize, string name = defaultName, bool expanded = false, string uiType = "DataGridView", int size = 0, bool deletable = false, bool copyable = false)
        {
            Text = name;
            Name = name;
            expand = expanded; // Only for cloning
            fileStream = baseReader.BaseStream;
            if (expanded)
            {
                Expand();
            }
            rd = baseReader;
            UIType = uiType;
            panelSizes = nodeSize;
            CanDelete = deletable;
            CanCopy = copyable;

            dataTable = new TableElement();
            enumedTable = new TableElement();
            colorTable = new TableElement();

            AddPanel("Node Info", mainNodePanels);
            AddPanel("Unknown Information", unkNodePanels);
            AddPanel("Extra Info", listOfPanels);
            baseNode.Nodes.Add(this);
        }

        // *---------------------------------------------------------------------*
        // Public Functions, to add functionality outside the Element class itself.
        // *---------------------------------------------------------------------*

        // *
        // Children functions, which create children under current Element and to add ease of access.
        // *

        /// <summary>
        /// Adds a basic child for the set element, as well as tying a ui element to the node.
        /// </summary>
        /// <param name="name"> Sets the default name for the node in child. </param>
        /// <param name="expanded"> Decides if child has expanded node. </param>
        /// <param name="deletable"> Decides if child can be deleted. </param>
        /// <returns> The newly created element. </returns>
        public Element AddChild(string name = defaultName, bool expanded = false, bool deletable = false, bool copyable = false)
        {
            Element child = new Element(this, rd, panelSizes, name, expanded, deletable : deletable, copyable : copyable);
            return child;
        }

        /*
        /// <summary>
        /// Adds a preset child for determining a new set array. Usually an unknown.
        /// </summary>
        /// <param name="size"> The size of the array to be used. </param>
        /// <param name="name"> Sets the default name for the node in child. </param>
        /// <param name="expanded"> Decides if child has expanded node. </param>
        /// <param name="deletable"> Decides if child can be deleted. </param>
        /// <returns> The newly created element. </returns>
        public Element AddArray(int size, string name = defaultName, bool expanded = false, bool deletable = false, bool copyable = false)
        {
            Element child = new Element(ElementNode, rd, name, expanded, "DataArray", size, deletable: deletable, copyable: copyable);
            Children.Add(child);
            child.ElementNode.Element = child;
            return child;
        }

        /// <summary>
        /// Adds a base child with no UI functions. Can still read bytes, but with no UI.
        /// </summary>
        /// <param name="name"> Sets the default name for the node in child. </param>
        /// <param name="expanded"> Decides if child has expanded node. </param>
        /// <param name="deletable"> Decides if child can be deleted. </param>
        /// <returns> The newly created element. </returns>
        public Element AddBase(string name = defaultName, bool expanded = false, bool deletable = false, bool copyable = false)
        {
            Element child = new Element(ElementNode, rd, name, expanded, "Base", deletable: deletable, copyable : copyable);
            Children.Add(child);
            child.ElementNode.Element = child;
            return child;
        }
        */

        /*
        /// <summary>
        /// Adds a child which presets functions for a ListBox UI.
        /// </summary>
        /// <param name="name"> Sets the default name for the node in child. </param>
        /// <param name="expanded"> Decides if child has expanded node. </param>
        /// <param name="deletable"> Decides if child can be deleted. </param>
        /// <returns></returns>
        public Element AddEnum(string name = defaultName, bool expanded = false, bool deletable = false, bool copyable = false)
        {
            Element child = new Element(this, rd, name, expanded, "EnumView", deletable: deletable, copyable: copyable);
            return child;
        }
        */

        /*
        /// <summary>
        /// Adds a child which presets functions for a PictureBox UI.
        /// </summary>
        /// <param name="name"> Sets the default name for the node in child. </param>
        /// <param name="expanded"> Decides if child has expanded node. </param>
        /// <param name="deletable"> Decides if child can be deleted. </param>
        /// <returns></returns>
        public Element AddColor(string name = defaultName, bool expanded = false, bool deletable = false, bool copyable = false)
        {
            Element child = new Element(ElementNode, rd, name, expanded, "ColorPicker", deletable: deletable, copyable: copyable);
            Children.Add(child);
            child.ElementNode.Element = child;
            return child;
        }

        /// <summary>
        /// Copies all variables from the current element into a new one.
        /// </summary>
        /// <returns></returns>
        override public object Clone()
        {
            // BaseElement copy
            Element mitosis = (Element)base.Clone();
            mitosis.ElementNode.Element = mitosis;
            foreach (RowElement row in dataTable.Rows)
            {
                mitosis.AddRowToDT(mitosis.dataTable, row.Description, row.Value);
            }

            // Enumed Table copy
            if (enumedTable != null)
            {
                mitosis.SetOriginalItem(enumedTable[0].Value);
                mitosis.list = list;
            }

            // ColorElement copy
            if (colorTable != null)
            {
                object copiedRed = Red.DeepCopy();
                mitosis.AddRed(copiedRed);

                object copiedGreen = Green.DeepCopy();
                mitosis.AddGreen(copiedGreen);

                object copiedBlue = Blue.DeepCopy();
                mitosis.AddBlue(copiedBlue);

                mitosis.SetColor();
            }

            foreach (Element e in Children)
            {
                Element newChild = (Element)e.Clone();
                mitosis.Children.Add(newChild);
                mitosis.ElementNode.Nodes.Add(newChild.ElementNode);
            }
            return mitosis;
        }
        */

        // *---------------------------------------------------------------------*
        // Stream file functions, since you can't access the Element's filestream normally.
        // *---------------------------------------------------------------------*

        /// <summary>
        /// Returns the current stream's position
        /// </summary>
        public long GetPos()
        {
            return fileStream.Position;
        }

        /// <summary>
        /// Sets the current stream's position
        /// </summary>
        /// <param name="position"> Position to be set </param> 
        public void SetPos(int position)
        {
            fileStream.Position = position;
        }

        public long FileSize()
        {
            return fileStream.Length;
        }

        /// <summary>
        /// Sets the stream's position by the offset provided.
        /// </summary>
        /// <param name="offset"> How many bytes to offset from. </param>
        public void AddOffset(int offset)
        {
            fileStream.Seek(offset, SeekOrigin.Current);
        }

        /*
        // *---------------------------------------------------------------------*
        // Functions to edit the Element class itself
        // *---------------------------------------------------------------------*

        public void Rename(string name)
        {
            ElementNode.Text = name;
        }

        /// <summary>
        /// Changes Element's endian to Big Endian.
        /// </summary>
        public void BigEndian()
        {
            isBigEndian = true;
        }

        /// <summary>
        /// Changes Element's endian to Little Endian.
        /// </summary>
        public void LittleEndian()
        {
            isBigEndian = false;
        }

        public void SetTableValue(object value, string valueName, TableElement selectTable)
        {
            foreach (RowElement row in selectTable.Rows)
            {
                if (row.Description == valueName)
                {
                    row.Value = value;
                    row.DataType = value.GetType();
                    Red = row.Value;
                    break;
                }
            }
        }
        */
    }


}
