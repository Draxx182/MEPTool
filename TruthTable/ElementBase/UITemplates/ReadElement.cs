using System;
using System.Text;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace TruthTable.NodeBase
{
    // *---------------------------------------------------------------------*
    // Binary Reader functions, reads off of stream and then puts it onto GUI.
    // *---------------------------------------------------------------------*

    partial class Element
    {
        /// <summary>
        /// Reads a certain size of string, or until a null byte (0) appears, then adds to Element's DataTable.
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="size"> How many bytes should be read to form the string. </param>
        /// <param name="translated"> Sets whether or not row and return string will add to data table. </param>
        /// <returns> The string read. </returns>
        public string ReadStr(string name = defaultName, int size = 0, Boolean translated = true)
        {
            string returnStr;
            // If size greater than 0, read certain amount of bytes
            if (size > 0)
            {
                returnStr = rd.ReadStringBytes(size);
            }
            // If size not specified or below 0, read til null byte
            else
            {
                returnStr = rd.ReadNullString();
            }

            if (translated)
            {
                currentPanel.AddVariable(name, returnStr);
            }
            return returnStr;
        }

        /// <summary>
        /// Reads a signed integer, then adds to Element's DataTable
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="translated"> Sets whether or not row and return string will add to data table. </param>
        /// <returns> The signed int read. </returns>
        public int ReadS32(string name = defaultName, Boolean translated = true)
        {
            int returnInt;
            if (isBigEndian)
            {
                returnInt = rd.ReadInt32BE();
            }
            else
            {
                returnInt = rd.ReadInt32();
            }

            if (translated)
            {
                currentPanel.AddVariable(name, returnInt);
            }
            return returnInt;
        }

        
        /// <summary>
        /// Reads an unsigned integer, then adds to Element's DataTable
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="translated"> Sets whether or not row and return string will add to data table. </param>
        /// <returns> The unsigned int read. </returns>
        public uint ReadU32(string name = defaultName, Boolean translated = true)
        {
            uint returnInt;
            if (isBigEndian)
            {
                returnInt = rd.ReadUInt32BE();
            }
            else
            {
                returnInt = rd.ReadUInt32();
            }

            if (translated)
            {
                currentPanel.AddVariable(name, returnInt);
            }
            return returnInt;
        }

        /// <summary>
        /// Reads a signed short, then adds to Element's DataTable
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="translated"> Sets whether or not row and return string will add to data table. </param>
        /// <returns> The signed short read. </returns>
        public short ReadS16(string name = defaultName, Boolean translated = true)
        {
            short returnShort;
            if (isBigEndian)
            {
                returnShort = rd.ReadInt16BE();
            }
            else
            {
                returnShort = rd.ReadInt16();
            }

            if (translated)
            {
                currentPanel.AddVariable(name, returnShort);
            }
            return returnShort;
        }

        /// <summary>
        /// Reads an unsigned short, then adds to Element's DataTable
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="translated"> Sets whether or not row and return string will add to data table. </param>
        /// <returns> The unsigned short read. </returns>
        public ushort ReadU16(string name = defaultName, Boolean translated = true)
        {
            ushort returnShort;
            if (isBigEndian)
            {
                returnShort = rd.ReadUInt16BE();
            }
            else
            {
                returnShort = rd.ReadUInt16();
            }

            if (translated)
            {
                currentPanel.AddVariable(name, returnShort);
            }
            return returnShort;
        }

        /// <summary>
        /// Reads a signed byte, then adds to Element's DataTable
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="translated"> Sets whether or not row and return string will add to data table. </param>
        /// <returns> The signed byte read. </returns>
        public sbyte ReadS8(string name = defaultName, Boolean translated = true)
        {
            sbyte returnByte = rd.ReadSByte();
            if (translated)
            {
                currentPanel.AddVariable(name, returnByte);
            }
            return returnByte;
        }

        /// <summary>
        /// Reads an unsigned byte, then adds to Element's DataTable
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="translated"> Sets whether or not the row will show up on GUI. </param>
        /// <returns> The unsigned byte read. </returns>
        public byte ReadU8(string name = defaultName, Boolean translated = true)
        {
            byte returnByte = rd.ReadByte();
            if (translated)
            {
                currentPanel.AddVariable(name, returnByte);
            }
            return returnByte;
        }

        public float ReadFloat(string name = defaultName, Boolean translated = true)
        {
            float returnFloat;
            if (isBigEndian)
            {
                returnFloat = rd.ReadSingleBE();
            }
            else
            {
                returnFloat = rd.ReadSingle();
            }

            if (translated)
            {
                currentPanel.AddVariable(name, returnFloat);
            }
            return returnFloat;
        }

        public uint[] ReadU32s(string name = defaultName, int size = 1, Boolean translated = true)
        {
            uint[] returnInts = new uint[size];
            for (int i = 0; i < size; i++)
            {
                if (isBigEndian)
                {
                    returnInts[i] = rd.ReadUInt32BE();
                }
                else
                {
                    returnInts[i] = rd.ReadUInt32();
                }

                if (translated)
                {
                    currentPanel.AddVariable(name, returnInts[i]);
                }
            }
            return returnInts;
        }

        public float[] ReadFloats(string name = defaultName, int size = 1, Boolean translated = true)
        {
            float[] returnFloat = new float[size];
            for (int i = 0; i < size; i++)
            {
                if (isBigEndian)
                {
                    returnFloat[i] = rd.ReadSingleBE();
                }
                else
                {
                    returnFloat[i] = rd.ReadSingle();
                }

                if (translated)
                {
                    currentPanel.AddVariable(name, returnFloat[i]);
                }
            }
            return returnFloat;
        }
        
        /// <summary>
        /// Reads a number of bytes.
        /// </summary>
        /// <param name="name"> Sets the description of the row on the GUI. </param>
        /// <param name="size"> Sets the number of bytes needed to be read. </param>
        /// <param name="translated"> Sets whether or not the row will show up on GUI. </param>
        /// <returns> Returns an array of bytes read. </returns>
        public byte[] ReadBytes(string name = defaultName, int size = 1, Boolean translated = true)
        {
            byte[] returnByte = rd.ReadBytesRequired(size);
            foreach (var b in returnByte)
            {
                if (translated)
                {
                    currentPanel.AddVariable(name, b);
                }
            }
            return returnByte;
        }

        public Guid ReadGuid(string name = defaultName, Boolean translated = true)
        {
            byte[] buffer = ReadBytes(size: 16, translated: false);
            Guid returnGuid = new Guid(buffer);
            if (translated)
            {
                currentPanel.AddVariable(name, returnGuid);
            }
            return returnGuid;
        }

        /*
        // Reads Checksum and adds to GUI
        public byte[] Chk(string name = "Unknown", Boolean translated = true)
        {
            byte[] returnByte = rd.ReadCheckSum();
            DataRow byteData = dataTable.NewRow();
            byteData[0] = name;
            byteData[1] = "Byte[]";
            byteData[2] = returnByte;
            if (translated)
            {
                AddRowToDT(name, byteIndex, returnByte);
            }
            return returnByte;
        }
        */
    }
}
