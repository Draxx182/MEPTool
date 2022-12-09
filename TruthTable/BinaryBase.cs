using System;
using System.IO;

// Contains the functions necessary for Big Endian Binary Reading
namespace TruthTable
{
    public static class BinaryBase
    {
        // Copied code from here: https://stackoverflow.com/questions/8620885/c-sharp-binary-reader-in-big-endian (2nd Answer Down)
        // Note this MODIFIES THE GIVEN ARRAY then returns a reference to the modified array.
        public static byte[] Reverse(this byte[] b)
        {
            Array.Reverse(b);
            return b;
        }

        // Reads Big Endian uShort
        public static UInt16 ReadUInt16BE(this BinaryReader binRdr)
        {
            return BitConverter.ToUInt16(binRdr.ReadBytesRequired(sizeof(UInt16)).Reverse(), 0);
        }

        // Reads Big Endian Short
        public static Int16 ReadInt16BE(this BinaryReader binRdr)
        {
            return BitConverter.ToInt16(binRdr.ReadBytesRequired(sizeof(Int16)).Reverse(), 0);
        }

        // Reads Big Endian uInteger
        public static UInt32 ReadUInt32BE(this BinaryReader binRdr)
        {
            return BitConverter.ToUInt32(binRdr.ReadBytesRequired(sizeof(UInt32)).Reverse(), 0);
        }

        // Reads Big Endian Integer
        public static Int32 ReadInt32BE(this BinaryReader binRdr)
        {
            return BitConverter.ToInt32(binRdr.ReadBytesRequired(sizeof(Int32)).Reverse(), 0);
        }

        public static float ReadSingleBE(this BinaryReader binRdr)
        {
            return BitConverter.ToSingle(binRdr.ReadBytesRequired(sizeof(float)).Reverse(), 0);
        }

        // Reads certain amount of Big Endian Bytes
        public static byte[] ReadBytesRequired(this BinaryReader binRdr, int byteCount)
        {
            var result = binRdr.ReadBytes(byteCount);
            if (result.Length != byteCount)
                throw new EndOfStreamException(string.Format("{0} bytes required from stream, but only {1} returned.", byteCount, result.Length));

            return result;
        }

        // Code derived from here: https://stackoverflow.com/questions/25577593/readstring-from-binaryreader-in-c-sharp-doesnt-read-the-first-byte
        // Reads a string till a null character appears.
        public static string ReadNullString(this BinaryReader binRdr)
        {
            string str = "";
            char ch;
            while ((int)(ch = binRdr.ReadChar()) != 0)
                str = str + ch;
            return str;
        }

        // Reads a certain amount of bytes, convert to string
        public static string ReadStringBytes(this BinaryReader binRdr, int size)
        {
            string str = "";
            for (int i = 0; i < size; i++)
            {
                char ch = binRdr.ReadChar();
                str = str + ch;
            }
            return str;
        }

        public static byte[] ReadCheckSum(this BinaryReader binRdr)
        {
            int sum = 0;
            sum %= 0x100;
            byte[] ch = binRdr.ReadBytesRequired(2);
            ch[0] = (byte)((sum >> 4) + 0x30);
            ch[1] = (byte)((sum & 0xF) + 0x30);
            return ch;
        }
    }
}