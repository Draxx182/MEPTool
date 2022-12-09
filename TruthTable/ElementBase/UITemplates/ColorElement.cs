using System;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TruthTable.Visual;

namespace TruthTable.NodeBase
{
    // *---------------------------------------------------------------------*
    // ColorPicker functions, to add functionality to the color picker.
    // *---------------------------------------------------------------------*
    partial class Element
    {
        public object Red;
        public object Blue;
        public object Green;
        public TableElement colorTable;
        public Color currentColor;
        private int[] ConvertRGBTo32(float r, float g, float b)
        {
            int usedRed = (int)Math.Ceiling(r * 100);
            int usedGreen = (int)Math.Ceiling(g * 100);
            int usedBlue = (int)Math.Ceiling(b * 100);
            int[] rgb = new int[] { usedRed, usedGreen, usedBlue };
            for (int i = 0; i < rgb.Length; i++)
            {
                if (rgb[i] > 255)
                {
                    rgb[i] = 255;
                }
            }
            return rgb;
        }

        public void AddRed(object type)
        {
            RowElement rowData = colorTable.NewRowElement();
            rowData.Description = "Red";
            rowData.Value = type;
            rowData.DataType = type.GetType();
            Red = rowData.Value;
            colorTable.Add(rowData);
        }

        public void AddGreen(object type)
        {
            RowElement rowData = colorTable.NewRowElement();
            rowData.Description = "Green";
            rowData.Value = type;
            rowData.DataType = type.GetType();
            Green = rowData.Value;
            colorTable.Add(rowData);
        }

        public void AddBlue(object type)
        {
            RowElement rowData = colorTable.NewRowElement();
            rowData.Description = "Blue";
            rowData.Value = type;
            rowData.DataType = type.GetType();
            Blue = rowData.Value;
            colorTable.Add(rowData);
        }

        public void SetColor()
        {
            RowElement colorRow = colorTable[0];
            Type type = colorRow.DataType;
            if (type == typeof(float))
            {
                int[] rgb = ConvertRGBTo32(Convert.ToSingle(Red), Convert.ToSingle(Green), Convert.ToSingle(Blue));
                Color newColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);

                currentColor = newColor;
            }
        }
    }
}
