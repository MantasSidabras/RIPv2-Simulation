using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIPv2
{
    public class Node
    {
        public string NodeName { get; set; }
        public List<Node> Neighbours { get; set; }
        public List<EntryTable> RoutingTable { get; set; }

        public string NeighboursText
        {
            get
            {
                return NeighboursToString();
            }
        }

        public string RoutingTableText
        {
            get
            {
                return NeighboursToString();
            }
        }

        public Node(string name)
        {
            NodeName = name;
            Neighbours = new List<Node>();
            RoutingTable = new List<EntryTable>();
        } 

        public string NeighboursToString()
        {
            string text = string.Empty;
            if(RoutingTable != null)
            {
                foreach(var neighbour in Neighbours)
                {
                    text += neighbour.NodeName + " ";
                }
            }
            return text;
        }
        
        public string RoutingTableToString()
        {
            string text = string.Empty;
            if (RoutingTable != null)
            {
                foreach (var r in RoutingTable)
                {
                    text += "dest: " + r.DestinationNode.NodeName + " metric: " + r.Metric + " next hop: " + r.NextHop.NodeName + "\n";
                }
            }
            return text;
        }
    }
}
