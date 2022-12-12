using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using TruthTable.NodeBase;

namespace TruthTable.MEP
{
    partial class MEPClass
    {
        private string pathString;
        private TabControl control;
        private BinaryReader reader;

        public MEPClass(BinaryReader rd, TabControl tabControl, string path)
        {
            pathString = path;
            control = tabControl;
            reader = rd;
            FormUIElements();
            Element baseElement = new Element(view, reader, new Size(395, 60), "MEP_");

            // File Header
            baseElement.CurrentPanel = baseElement.MainPanels[0];
            baseElement.MainPanels[0].AddHeader("File Header");
            baseElement.ReadStr("Magic:", 4);
            Console.WriteLine(baseElement.CurrentPanel.Header);
            baseElement.ReadU8("Endianess 1");
            baseElement.ReadU8("Endianess 2");
            baseElement.ReadU16(translated:false);
            baseElement.ReadU8("Version 1");
            baseElement.ReadU8("Version 2");
            baseElement.ReadU8("Version 3");
            baseElement.ReadU8("Version 4");
            baseElement.ReadU32("Unk");
            Console.WriteLine(baseElement.CurrentPanel.Header);

            bool isEnd = false;
            while (isEnd == false)
            {
                if (baseElement.GetPos() + 64 == baseElement.FileSize())
                {
                    isEnd = true;
                }
                else
                {
                    Element node = ReadNode(baseElement);
                }
            }
            baseElement.Expand();
        }

        private Element ReadNode(Element baseNode)
        {
            // A base node that doesn't show a DataGridView
            Element node = baseNode.AddChild();
            node.CurrentPanel = node.MainPanels[0];

            node.ReadGuid("GUID");
            // A new node for translating bones into simple enums.
            node.AddOffset(2);
            string boneName = node.ReadStr("Bone String");
            node.AddOffset(29 - boneName.Length);
            short propertySect = node.ReadS16();
            short propertyType = node.ReadS16();
            int propertySize = node.ReadS32();
            propertySize /= 4;
            
            // A new node for translating bone IDs into simple enums.
            int boneID = node.ReadS32(translated:false);
            node.ReadS32("Unk Int");
            if (propertySect == 0)
            {
                node.ReadS32("Controller Type"); // In base node
                node.ReadFloat("Start Frame");
                node.ReadFloat("End Frame");

                if (propertyType == 100) // Limb Flash
                {
                    node.ListOfPanels[0].AddHeader("Limb Flash Unknowns");
                    node.CurrentPanel = node.ListOfPanels[0];
                    node.Text = "LimbFlash";
                    node.ReadS32("Unk 0");
                    node.ReadS32("Unk 1");
                    node.ReadFloat("Unk 2");
                    node.ReadS32("Unk 3");
                    node.ReadFloat("Unk 4");

                    for (int i = 1; i < 4; i++)
                    {
                        node.AddPanel("Outer Flash "+i, node.ListOfPanels);
                        node.ReadFloat("Flash Gradient");
                        node.ReadFloat("Red Flash Color");
                        node.ReadFloat("Green Flash Color");
                        node.ReadFloat("Blue Flash Color");
                        node.ReadFloat("Opacity");
                        node.ReadFloats(size: 3);
                    }

                    node.CurrentPanel = node.UnkPanels[0];
                    node.ReadFloat();
                    node.ReadS32(translated: false);
                    node.ReadU32();

                    node.CurrentPanel = node.UnkPanels[0];
                    node.ReadFloats(size: propertySize - 45);

                    node.AddPanel("Inner Limb Flash", node.ListOfPanels);
                    node.ReadFloat("Flash Opacity");
                    for (int i = 1; i < 4; i++)
                    {

                        node.AddPanel("Inner Flash " + i, node.ListOfPanels);
                        node.ReadFloat("Red Flash Color");
                        node.ReadFloat("Green Flash Color");
                        node.ReadFloat("Blue Flash Color");
                    }
                }
                else
                {
                    node.CurrentPanel = node.UnkPanels[0];
                    node.Text = "Unknown";
                    node.ReadU32s(size: propertySize - 3);
                }
            }


            return node;
        }
    }
}
