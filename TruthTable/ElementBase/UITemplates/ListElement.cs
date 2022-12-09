using System;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;
using TruthTable.Visual;

namespace TruthTable.NodeBase
{
    // *---------------------------------------------------------------------*
    // ListBox Functions, to add functionality to the listboxes.
    // *---------------------------------------------------------------------*
    partial class Element
    {
        public TableElement enumedTable;
        public ListDictionary list = new ListDictionary();

        public void SetOriginalItem(object type)
        {
            RowElement rowData = enumedTable.NewRowElement();
            rowData.Description = "Original Item";
            rowData.Value = type;
            enumedTable.Add(rowData);
            list.Add(rowData.Value, "Original Item");
        }

        public void AddListItem(ListDictionary dict)
        {
            foreach (DictionaryEntry entry in dict)
            {
                list.Add(entry.Key, entry.Value);
            }
        }
    }
}
