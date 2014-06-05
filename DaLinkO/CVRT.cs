using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DaLinkO
{
    public static class CVRT
    {
        public static byte[] getBytes(string str)
        {
            //byte[] bytes = new byte[str.Length * sizeof(char)];
            //System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            //return bytes;
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
            return bytes;
        } //converts strings to byte arrays
        public static string getString(byte[] bytes)
        {

            //char[] chars = new char[bytes.Length / sizeof(char)];
            //System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            ////return Encoding.ASCII.GetString(bytes, 0, bytes.Length); 
            //return new string(chars);

            //return Encoding.UTF8.GetString(bytes, 0, bytes.Length);

            //var sb = new StringBuilder("new byte[] { ");
            //foreach (var b in bytes)
            //{
            //    sb.Append(b + ", ");
            //}
            //sb.Append("}");
            //Console.WriteLine(sb.ToString());
            //return (sb.ToString());

            string value = "";
            foreach (var byt in bytes)
                value += String.Format("{0:X2} ", byt);

            return value;



        } //converts byte arrays to strings
        public static string getIntAsString(byte[] bytes)
        {

             int x = BitConverter.ToInt32(bytes, 0);
             return Convert.ToString(x);
        }
        public static string objectToXMLString<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
            StringWriter textWriter = new StringWriter();

            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        } //Converts a Bean objects to XML string
        public static string getDataTypeForArduino(TElement t)
        {
                    // arduino  generic   C#.Net type    	Signed? Bytes   Possible Values
                    //  int     int	        System.Int32	Yes 	4	    -2147483648 to 2147483647
                    //  boolean bool	    System.Boolean	N/A	    1 / 2?	true or false, don'tknow when you would have 2 bytes though..
                    //  double  double	    System.Double	Yes	    8	    Approximately ±5.0 x 10-324 to ±1.7 x 10308 with 15 or 16 significant figures
                    //  N/A     sbyte	    System.Sbyte	Yes	    1	    -128 to 127

                    // short    short	    System.Int16	Yes	    2	    -32768 to 32767
                    // long     long	    System.Int64	Yes	    8	    -9223372036854775808 to 9223372036854775807
                    // byte     byte	    System.Byte	    No	    1	    0 to 255
                    // word?    ushort	    System.Uint16	No	    2   	0 to 65535
                // unsigned int uint	    System.UInt32	No  	4	    0 to 4294967295
                //unsigned long long	    System.Uint64	No	    8	    0 to 18446744073709551615
                    // float    float	    System.Single	Yes	    4	    Approximately ±1.5 x 10-45 to ±3.4 x 1038 with 7 significant figures
                    // N/A      decimal	    System.Decimal	Yes	    12	    Approximately ±1.0 x 10-28 to ±7.9 x 1028 with 28 or 29 significant figures
                    // char     char	    System.Char	    N/A	    2	    Any Unicode character (16 bit)

            string dataType;

            if (t.type == "System.Int32")
            { dataType = "int"; }
            else if (t.type == "System.Boolean")
            { dataType = "boolean"; }
            else if (t.type == "System.Double")
            { dataType = "double"; }
            else if (t.type == "System.SByte")
            { dataType = "//sbyte is currently not working for arduino"; }
            else if (t.type == "System.Int16")
            { dataType = "short"; }
            else if (t.type == "System.Int64")
            { dataType = "long"; }
            else if (t.type == "System.Byte")
            { dataType = "byte"; }
            else if (t.type == "System.UInt16")
            { dataType = "word"; }
            else if (t.type == "System.UInt32")
            { dataType = "unsigned int"; }
            else if (t.type == "System.UInt64")
            { dataType = "unsigned long"; }
            else if (t.type == "System.Char")
            { dataType = "char"; }
            else if (t.type == "System.Single")
            { dataType = "//Single float is currently not working for arduino"; }
            else if (t.type == "System.Decimal")
            { dataType = "//Decimal type is currently not working for arduino"; }
            else if (t.type == "byte")
            { dataType = "byte"; }
            else { dataType = ""; }

            return dataType;
        }
    }
}
