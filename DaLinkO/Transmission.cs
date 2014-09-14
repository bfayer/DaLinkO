using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO
{
    [Serializable]
    public class Transmission
    {
        [Serializable]
        public class TElementBindingList<T> : BindingList<T>
        { }

        public TElementBindingList<TElement> TElementList = new TElementBindingList<TElement>();
        
        public Transmission()
        {
            
        }


        //List management functions

        public void ReattachElements()
        {
            foreach (TElement t in TElementList)
            {
                //Calls a method in the datamanger that replaces the TElement objects with the new ones by name
                //OR maybe it creates the 
                
                

            }
        }
        public void AddTElement(TElement te)
        {
            this.TElementList.Add(te);
        }
        public void FormatTElement(TElement eToFormat)
        {
            //if (eToFormat.TElementType == 0)
            //{

            //}
        }

        // general methods

        public byte[] ProvideTransmission //this is probably super inefficient should use blockcopy?
        {
            get {

            List<byte> byteList = new List<byte>(); //creates a list of bytes rather than an array because size is unknown
            foreach (TElement el in TElementList)
            {
                byteList.AddRange(el.elementBytes);
            }

            return byteList.ToArray();
            }
            set
            {

            }

        }


        public int GetByteCount()
        {
            int x = 0;
            foreach (TElement element in this.TElementList)
            {
                x += element.numberOfBytes;
            }
            return x;
        }

    }
    [Serializable]
    public class TElement
    {
        public DE linkedElement = new DE();
        public string elementSourceName { get; set; }
        public string modversion { get; set; }
        public virtual string elementName { get; set; }
        public virtual byte[] elementBytes { get; set; }
        public virtual string elementValueAsText
        {
            get
            {

                return linkedElement.V;

            }
            set { }
        }
        //public virtual int TElementType { get; set; }//0=constant, 1 = int32
        public virtual string type
        {
            get
            {

                return linkedElement.T;

            }
            set { }
        }
        public virtual int numberOfBytes
        {
            get
            {
                int x = elementBytes.Count();
                return x;
            }
            set { }
        }
        public virtual string elementTextBytes { get { return CVRT.getString(elementBytes); } set { } }
    }

    //C# Type	.Net type    	Signed? Bytes   Possible Values
    //int	    System.Int32	Yes 	4	    -2147483648 to 2147483647
    //bool	    System.Boolean	N/A	    1 / 2?	true or false, don'tknow when you would have 2 bytes though..
    //double	System.Double	Yes	    8	    Approximately ±5.0 x 10-324 to ±1.7 x 10308 with 15 or 16 significant figures
    //sbyte	    System.Sbyte	Yes	    1	    -128 to 127
    //short	    System.Int16	Yes	    2	    -32768 to 32767
    //long	    System.Int64	Yes	    8	    -9223372036854775808 to 9223372036854775807
    //byte	    System.Byte	    No	    1	    0 to 255
    //ushort	System.Uint16	No	    2   	0 to 65535
    //uint	    System.UInt32	No  	4	    0 to 4294967295
    //ulong	    System.Uint64	No	    8	    0 to 18446744073709551615
    //float	    System.Single	Yes	    4	    Approximately ±1.5 x 10-45 to ±3.4 x 1038 with 7 significant figures
    //decimal	System.Decimal	Yes	    12	    Approximately ±1.0 x 10-28 to ±7.9 x 1028 with 28 or 29 significant figures
    //char	    System.Char	    N/A	    2	    Any Unicode character (16 bit)
     
    [Serializable]
    public class TElement_Constant : TElement
    {
        public TElement_Constant(string name, byte[] BytesIn)//overload for Constants
        {
            //TElementType = 0;
            elementName = name;
            elementBytes = BytesIn;

        }
        private byte[] constants;
        public override string type
        {
            get
            {
                 return "byte"; 

            }
            set { }
        }
        public override byte[] elementBytes
        {
            get
            {
                return constants; 

            }
            set
            {
                
                constants = value; 
            }
        }
        public override string elementValueAsText
        {
            get
            {
                return Encoding.UTF8.GetString(constants, 0, constants.Length);
            }
            set { }
        }
    }
    [Serializable]
    public class TElement_Int32:TElement
    {
        public TElement_Int32(string name, DE element) 
        {
            //TElementType = 1;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        { 
            get{

                byte[] check = BitConverter.GetBytes(Convert.ToInt32(linkedElement.V));
                return check; 
            
            }
            set{} 
        }
    }
    public class TElement_Boolean : TElement
    {
        public TElement_Boolean(string name, DE element)
        {
            //TElementType = 2;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {

                byte[] check = BitConverter.GetBytes(Convert.ToBoolean(linkedElement.V));
                return check;

            }
            set { }
        }
    }
    public class TElement_Double : TElement
    {
                public TElement_Double(string name, DE element) 
        {
           // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        { 
            get{

                byte[] check = BitConverter.GetBytes(Convert.ToDouble(linkedElement.V));
                return check; 
            }
            set{} 
        }
    }
    [Serializable]
    public class TElement_SByte : TElement //for some reason elementBytes is spitting out two bytes for this
    {
        public TElement_SByte(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {
                //sbyte[] signed = new sbyte[1];
                //signed[0] = Convert.ToSByte(Convert.ToInt16(linkedElement.V));

                 
                //byte[] check = Array.ConvertAll(signed, (a) => (byte)a);
                sbyte signed =Convert.ToSByte(linkedElement.V);

                
                byte[] check = new byte[1];
                check[0]=(byte)signed;



                return check;
            }
            set { }
        }
    }
    public class TElement_Int16 : TElement //aka short
    {
        public TElement_Int16(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {
                byte[] check = BitConverter.GetBytes(Convert.ToInt16(linkedElement.V));
                return check;
            }
            set { }
        }
    }
    public class TElement_Int64 : TElement //aka long
    {
        public TElement_Int64(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {
                
                byte[] check = BitConverter.GetBytes(Convert.ToInt64(linkedElement.V));
                return check;
            }
            set { }
        }
    }
    [Serializable]
    public class TElement_Byte : TElement
    {
        public TElement_Byte(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {
                byte[] check = {Convert.ToByte(linkedElement.V)};
                return check;
            }
            set { }
        }
    }
    public class TElement_UInt16 : TElement //aka ushort
    {
        public TElement_UInt16(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {

                byte[] check = BitConverter.GetBytes(Convert.ToUInt16(linkedElement.V));
                return check;
            }
            set { }
        }
    }
    public class TElement_UInt32 : TElement //aka uint
    {
        public TElement_UInt32(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {

                byte[] check = BitConverter.GetBytes(Convert.ToUInt32(linkedElement.V));
                return check;
            }
            set { }
        }
    }
    public class TElement_UInt64 : TElement //aka ulong
    {
        public TElement_UInt64(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {

                byte[] check = BitConverter.GetBytes(Convert.ToUInt64(linkedElement.V));
                return check;
            }
            set { }
        }
    }
    public class TElement_Single : TElement
    {
        public TElement_Single(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {

                byte[] check = BitConverter.GetBytes(Convert.ToSingle(linkedElement.V));
                return check;
            }
            set { }
        }
    } //aka float - not working?
    //public class TElement_Decimal : TElement //not working yet
    //{
    //    public TElement_Decimal(string name, DE element)
    //    {
    //        // TElementType = 3;
    //        elementName = name;
    //        linkedElement = element;
    //    }
    //    public override byte[] elementBytes
    //    {
    //        get
    //        {

    //            byte[] check = BitConverter.GetBytes(Convert.ToDecimal(linkedElement.V));
    //            return check;
    //        }
    //        set { }
    //    }
    //}
    [Serializable]
    public class TElement_Char : TElement
    {
        public TElement_Char(string name, DE element)
        {
            // TElementType = 3;
            elementName = name;
            linkedElement = element;
        }
        public override byte[] elementBytes
        {
            get
            {

                byte[] check = BitConverter.GetBytes(Convert.ToChar(linkedElement.V));
                return check;
            }
            set { }
        }
    }

    public static class TElementFactory
    {
        public static TElement TElementPicker (string name, DE inDE)
        {
            TElement dataElement;
                    

                    if (inDE.T == "System.Int32" || inDE.T=="int")
                    {
                        dataElement = new TElement_Int32(name, inDE);
                        
                    }
                    else if (inDE.T == "System.Boolean" || inDE.T == "bool")
                    {
                        dataElement = new TElement_Boolean(name, inDE);
                        
                    }
                    else if (inDE.T == "System.Double" || inDE.T == "double")
                    {
                        dataElement = new TElement_Double(name, inDE);
                        
                    }
                    else if (inDE.T == "System.SByte" || inDE.T == "sbyte")
                    {
                        dataElement = new TElement_SByte(name, inDE);
                        
                    }

                    else if (inDE.T == "System.Int16" || inDE.T == "short")
                    {
                        dataElement = new TElement_Int16(name, inDE);
                        
                    }
                    else if (inDE.T == "System.Int64" || inDE.T == "long")
                    {
                        dataElement = new TElement_Int64(name, inDE);
                        
                    }
                    else if (inDE.T == "System.Byte" || inDE.T == "byte")
                    {
                        dataElement = new TElement_Byte(name, inDE);
                        
                    }
                    else if (inDE.T == "System.UInt16" || inDE.T == "ushort")
                    {
                        dataElement = new TElement_UInt16(name, inDE);
                        
                    }
                    else if (inDE.T == "System.UInt32" || inDE.T == "uint")
                    {
                        dataElement = new TElement_UInt32(name, inDE);
                    }
                    else if (inDE.T == "System.UInt64" || inDE.T == "ulong")
                    {
                        dataElement = new TElement_UInt64(name, inDE);
                        
                    }
                    //else if (selectedDataElement.T == "System.Single")
                    //{
                    //    this.dataElement = new TElement_Single(tbDataName.Text, selectedDataElement);
                    //    this.DialogResult = DialogResult.OK;
                    //}
                    //decimal??
                    else if (inDE.T == "System.Char" || inDE.T == "char")
                    {
                        dataElement = new TElement_Char(name, inDE);
                        
                    }
                    else
                    {
                        byte[] bytearray = new byte[1];
                        bytearray[0] = 0;
                        dataElement = new TElement_Constant("broken", bytearray);
                        //MessageBox.Show("incompatible data type");
                    }

                    return dataElement;
        }
    }

    
}
