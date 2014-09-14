using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DaLinkO
{

    [Serializable]
    [XmlRoot("DR")]
    public class DR
    {

        private readonly List<DP> myDataPacks = new List<DP>();
        [XmlElement("DP", typeof(DP))]
        public List<DP> dataPacks { get { return myDataPacks; } }
        [XmlAttribute]
        public string TV { get; set; }

    }
    [Serializable]
    public class DP 
    {
        public DP()
        {
            LastHeardFrom = DateTime.Now;
        }
        [XmlAttribute]
        public string Src { get; set; }
        [XmlAttribute]
        public string v { get; set; }
        public DateTime LastHeardFrom;
        public string LastActiveTime
        {
            get
            {
                        /* Checks the the time ellapsed between data updates on specific packs and 
             * pops out a human readable summary string
             */

            string time;
            
            TimeSpan duration = (DateTime.Now).Subtract(this.LastHeardFrom);
            //time = bActive.Bean[i].LastHeardFrom.Minute.ToString();

            //if (TimeSpan.Compare(duration, TimeSpan.Parse("00:05:00")) == 1)
            //{
            //    time = duration.ToString();
            //}
            //else if
                if (TimeSpan.Compare(duration, TimeSpan.Parse("00:02:00")) == 1)
            {
                time = "~"+duration.Minutes.ToString() + " minutes ago";
            }
            else if (TimeSpan.Compare(duration, TimeSpan.Parse("00:01:00")) == 1)
            {
                time = "~" + duration.Minutes.ToString() + " minute ago";
            }
            else if (TimeSpan.Compare(duration, TimeSpan.Parse("00:00:03")) == 1)
            {
               time = "~" + duration.Seconds.ToString() + " seconds ago";
            }
            else
            {
                time = "Currently Active";
            }

            return time;
            }

            set
            {
                
            }
        }

        public List<DE> myElementList = new List<DE>(); //should be private read only? works for the DR class..
        [XmlElement("DE", typeof(DE))]
        public List<DE> dataElement { get { return myElementList; } }

    }

    [Serializable]
    public class DE //Data Element
    {
        public DE() { }
        public DE(string name, string type, string value) { N = name; T = type; V = value; }
        [XmlAttribute]
        public string N { get; set; } //Name
        [XmlAttribute]
        public string T { get; set; } //Data type
        [XmlElement]
        public string V { get; set; }  //Value - will be int?
    }
}
