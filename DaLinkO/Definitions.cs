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





    }
}
