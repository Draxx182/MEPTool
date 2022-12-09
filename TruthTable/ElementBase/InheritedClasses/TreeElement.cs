using System;
using System.Windows.Forms;
using TruthTable.NodeBase;

namespace TruthTable.Visual
{
    // https://stackoverflow.com/questions/990112/can-you-data-bind-a-treeview-control

    [Serializable]
    class TreeElement : TreeNode
    {
        public Element Element { get; set; }

        public TreeElement(string value, Element ElementBind)
        {
            if (ElementBind != null) Element = ElementBind;
            Text = value;
            Name = value;
            Element = ElementBind;
        }

        public TreeElement()
        {
        }
    }
}
