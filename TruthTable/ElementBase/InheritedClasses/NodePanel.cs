using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TruthTable.Visual;

namespace TruthTable.Visual
{
    class NodePanel : Panel
    {
        // Private Variables
        private int panelOffset = 0;
        private bool isEmpty = true;
        private Label nodeHeader;
        // Private Lists
        private List<Label> variableLabels = new List<Label>();
        private List<TextBox> variableTextBoxes = new List<TextBox>();

        // Properties
        public int PanelOffset
        {
            get { return panelOffset; }
            set { panelOffset = value; }
        }

        public Label Header
        {
            get { return nodeHeader; }
        }

        public bool Empty
        {
            get { return isEmpty; }
        }

        public void AddHeader(string headerName)
        {
            if (nodeHeader == null) panelOffset += 50;
            Controls.Remove(nodeHeader);

            Label exampleHeaderLabel = Initializer.CreateHeaderLabel(new Point(0, 2), new Size(Width, 35), headerName);
            nodeHeader = exampleHeaderLabel;
            Controls.Add(exampleHeaderLabel);
        }

        public void AddVariable(string variableName, object data)
        {
            Label variableLabel = Initializer.CreateTextLabel(new Point(0, panelOffset), new Size((Width / 2) - 15, 15), variableName);
            TextBox variableTextBox = Initializer.CreateTextBox(new Point((Width / 2) - 15, panelOffset - 1), new Size(Width / 2, 15));
            variableTextBox.Text = data.ToString();
            Controls.Add(variableLabel);
            Controls.Add(variableTextBox);
            variableLabels.Add(variableLabel);
            variableTextBoxes.Add(variableTextBox);
            Size = new Size(Width, Height + 25);
            PanelOffset += 25;
            isEmpty = false;
        }
    }
}
