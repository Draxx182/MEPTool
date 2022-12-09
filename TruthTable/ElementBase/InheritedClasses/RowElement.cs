using System;
using System.Data;

namespace TruthTable.Visual
{
    class RowElement : DataRow
    {
        public Type DataType;
        // Code taken from:
        // https://www.codeproject.com/Articles/30490/How-to-Manually-Create-a-Typed-DataTable
        public string Description
        {
            get { return (string)base["Description"]; }
            set { base["Description"] = value; }
        }

        public object Value
        {
            get { return base["Value"]; }
            set { base["Value"] = value; }
        }

        internal RowElement(DataRowBuilder builder) : base(builder)
        {
            Description=String.Empty;
            Value=null;
        }
    }
}
