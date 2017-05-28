using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIPv2
{
    public class EntryTable : ICloneable
    {
        public Node DestinationNode { get; set; }
        public int Metric { get; set; }
        public Node NextHop { get; set; }

        public string EntryTableText
        {
            get
            {
                return "dest: " + DestinationNode.NodeName + " metric: " + Metric + " next hop: " + NextHop.NodeName;
            }
            set
            {
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }


    }



}
