using System;
using System.Collections;
using System.Data;

namespace TruthTable.Visual
{
    class TableElement : DataTable
    {
        // Code taken from:
        // https://www.codeproject.com/Articles/30490/How-to-Manually-Create-a-Typed-DataTable

        public TableElement()
        {
            DataColumn description = new DataColumn("Description", typeof(string));
            description.ReadOnly = true;
            DataColumn value = new DataColumn("Value", typeof(object));
            Columns.Add(description);
            Columns.Add(value);
        }

        public RowElement NewRowElement()
        {
            RowElement row = (RowElement)NewRow();

            return row;
        }

        public RowElement this[int idx]
        {
            get { return (RowElement)Rows[idx]; }
        }

        protected override Type GetRowType()
        {
            return typeof(RowElement);
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new RowElement(builder);
        }
        public void Add(RowElement row)
        {
            Rows.Add(row);
        }

        public void Remove(RowElement row)
        {
            Rows.Remove(row);
        }
    }
}
