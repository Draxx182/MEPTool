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
            Element baseElement = new Element(view, reader, "MEP_");

            // File Header
            baseElement.CurrentPanel = baseElement.MainData;
            baseElement.MainData.AddHeader("File Header");
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
            node.CurrentPanel = node.MainData;

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
                    node.Text = "LimbFlash";
                    node.ReadS32("Unk 0");
                    node.ReadS32("Unk 1");
                    node.ReadFloat("Unk 2");
                    node.ReadS32("Unk 3");
                    node.ReadFloat("Unk 4");

                    for (int i = 1; i < 4; i++)
                    {
                        node.AddPanel("Outer Limb Flash "+i);
                        node.ReadFloat("Flash Gradient");
                        node.ReadFloat("Red Flash Color");
                        node.ReadFloat("Green Flash Color");
                        node.ReadFloat("Blue Flash Color");
                        node.ReadFloat("Opacity");
                        node.ReadFloats(size: 3);
                    }

                    node.AddPanel("Limb Flash Data");
                    node.ReadFloat();
                    node.ReadS32(translated: false);
                    node.ReadU32();

                    node.CurrentPanel = node.UnkData;
                    node.ReadFloats(size: propertySize - 45);

                    node.ReadFloat("Flash Opacity");
                    for (int i = 1; i < 4; i++)
                    {
                        node.AddPanel("Inner Limb Flash "+i);
                        node.ReadFloat("Red Flash Color");
                        node.ReadFloat("Green Flash Color");
                        node.ReadFloat("Blue Flash Color");
                    }
                }
                else
                {
                    node.CurrentPanel = node.UnkData;
                    node.Text = "Unknown";
                    node.ReadU32s(size: propertySize - 3);
                }
            }


            return node;
        }
    }
}
