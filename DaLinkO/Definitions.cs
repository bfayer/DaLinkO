using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaLinkO
{
    static class Definitions
    {
        public static string transmissionVersion01_00 = @"<?xml version=""1.0"" encoding=""utf-16""?> 
<DR xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" TV=""1.00"">
  <DP Src=""YourSourceName"" v=""0.01"">
    <DE N=""statLife"" T=""System.Int32"">
      <V>5</V>
    </DE>
    <DE N=""statLifeMax"" T=""System.Int32"">
      <V>100</V>
    </DE>
  </DP>
</DR>

DR=""Data Root""
DP=""Data Pack""
DE=""Data Element""
TV= ""Transmission Version""
Src= ""Source""
v=""Mod Version""
N=""Name""
T=""Type""
V=""Value""
 
The above transmission yields

TV: 1.00
Src: YourSourceName 
v: 0.01
DE:
 [0] int statLife = 5
 [1] int statLifeMax = 100

Note: encoding= ""utf=8"" also works
";


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


    }
}
