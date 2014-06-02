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
            string dataType="";
            if (t.type == "System.Int32")
            { dataType = "int"; }

            return dataType;
        }
    }
}
