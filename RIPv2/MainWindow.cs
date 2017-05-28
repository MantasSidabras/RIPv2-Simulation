using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIPv2
{
    public partial class neighboursLabel : Form
    {
        private int routerCount = 0;
        List<Node> nodes;

        public neighboursLabel()
        {
            InitializeComponent();

            nodes = new List<Node>();

            nodes = FillTestNodes();

            UpdateNodeListBox();
            

        }

        public void UpdateNodes()
        {
            foreach (var node in nodes)
            {
                foreach (var neighbour in node.Neighbours)
                {
                    foreach (var entry in neighbour.RoutingTable)
                    {
                        if (entry.DestinationNode != node)
                        {
                            EntryTable table = new EntryTable();
                            table.DestinationNode = entry.DestinationNode;
                            table.Metric = entry.Metric + 1;
                            table.NextHop = neighbour;

                            var knownRouteToNode = (from r in node.RoutingTable
                                                    where r.DestinationNode == table.DestinationNode
                                                    select r).ToList().FirstOrDefault();

                            if (table.Metric < 16)
                            {
                                if (knownRouteToNode != null)
                                {
                                    if (knownRouteToNode.Metric > table.Metric && table.NextHop != node)
                                    {
                                        node.RoutingTable.Remove(knownRouteToNode);
                                        node.RoutingTable.Add(table);
                                    }
                                }
                                else
                                {
                                    node.RoutingTable.Add(table);
                                }
                            }


                        }
                    }
                }
            }
        }


        private List<Node> FillTestNodes()
        {
            List<Node> nodes = new List<Node>();
            for (int i = 0; i < 7; i++)
            {
                nodes.Add(new Node(GenerateNewRouterName()));
            }

            LinkNeghbours("RA", "RB", nodes);
            LinkNeghbours("RB", "RG", nodes);
            LinkNeghbours("RB", "RC", nodes);
            LinkNeghbours("RG", "RD", nodes);
            LinkNeghbours("RD", "RF", nodes);
            LinkNeghbours("RF", "RE", nodes);
            LinkNeghbours("RC", "RE", nodes);


            return nodes;

        }

        private void LinkNeghbours(Node A, Node B)
        {
            if (!A.Neighbours.Contains(B) && !B.Neighbours.Contains(A))
            {
                A.Neighbours.Add(B);
                B.Neighbours.Add(A);
            }
        }

        private void LinkNeghbours(string A, string B, List<Node> nodes)
        {
            var xa = (from n in nodes
                      where n.NodeName == A
                      select n).FirstOrDefault();
            var xb = (from n in nodes
                      where n.NodeName == B
                      select n).FirstOrDefault();
            if (xa != null && xb != null && !xa.Neighbours.Contains(xb) && !xb.Neighbours.Contains(xa))
            {
                xa.Neighbours.Add(xb);
                xb.Neighbours.Add(xa);
                xa.RoutingTable.RemoveAll(q => q.DestinationNode == xb);
                xa.RoutingTable.Add(
                    new EntryTable()
                    {
                        DestinationNode = xb,
                        Metric = 1,
                        NextHop = xb
                    });

                xb.RoutingTable.RemoveAll(q => q.DestinationNode == xa);
                xb.RoutingTable.Add(
                    new EntryTable()
                    {
                        DestinationNode = xa,
                        Metric = 1,
                        NextHop = xa
                    });

            }
            else
            {
                throw new Exception();
            }


            //A.Neighbours.Add(B);
            //B.Neighbours.Add(A);
        }

        private string GenerateNewRouterName()
        {
            char routerLetter = 'A';
            string routerName = string.Format("R{0}", (char)(routerLetter + routerCount));
            routerCount++;
            return routerName;
        }

        public int dCost(Node A, Node B)
        {
            if (A != B && A.Neighbours.Contains(B) && B.Neighbours.Contains(A))
                return 1;
            else
                return 16; //infinity
        }

        public EntryTable DMetric(Node A, Node B)
        {
            var table = DMetric(A, B, null);
            return table;

        }

        private EntryTable DMetric(Node A, Node B, Node C)
        {
            var entryTable = new EntryTable()
            {
                Metric = 16
            };

            if (A == B)
            {
                return new EntryTable()
                {
                    Metric = 0
                };
            }
            else
            {
                foreach (var neighbour in A.Neighbours)
                {
                    if (neighbour != C)
                    {
                        int value = dCost(A, neighbour) + DMetric(neighbour, B, A).Metric;
                        if (value < entryTable.Metric)
                        {
                            entryTable.DestinationNode = B;
                            entryTable.Metric = value;
                            entryTable.NextHop = neighbour;
                        }
                    }
                }
            }
            return entryTable;
        }

        private void AddAllRoutes(List<Node> nodes)
        {
            foreach (var node1 in nodes)
            {
                foreach (var node2 in nodes)
                {
                    if (node1 != node2)
                        node1.RoutingTable.Add(DMetric(node1, node2));
                }
            }
        }



        private void addNodeButton_Click(object sender, EventArgs e)
        {

        }

        private void nodesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            routingTableListBox.Items.Clear();
            routingTableListBox.Items.AddRange(((Node)nodesListBox.SelectedItem).RoutingTable.ToArray());
            routingTableListBox.DisplayMember = "EntryTableText";


            UpdateNeighbourListBox();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateNodes();

            routingTableListBox.Items.Clear();
            routingTableListBox.Items.AddRange(((Node)nodesListBox.SelectedItem).RoutingTable.ToArray());
            routingTableListBox.DisplayMember = "EntryTableText";
        }

        private void addRouterButton_Click(object sender, EventArgs e)
        {
            nodes.Add(new Node(GenerateNewRouterName()));
            UpdateNodeListBox();
        }

        private void linkNodesButton_Click(object sender, EventArgs e)
        {
            try
            {
                LinkNeghbours(node1TextBox.Text, node2TextBox.Text, nodes);
                node1TextBox.Text = string.Empty;
                node2TextBox.Text = string.Empty;
                routingTableListBox.Items.Clear();
            }
            catch
            {
                node1TextBox.Text = "You";
                node2TextBox.Text = "Failed";
            }
            
        }

        private void deleteNodeButton_Click(object sender, EventArgs e)
        {
            var nodeToDelete = (Node)nodesListBox.SelectedItem;
            foreach(var node in nodes)
            {
                node.RoutingTable.RemoveAll(x => x.NextHop == nodeToDelete);
                node.Neighbours.Remove(nodeToDelete);
            }


            nodes.Remove(nodeToDelete);

            UpdateNodeListBox();
            neighboursListBox.Items.Clear();
            

        }

        public void UpdateNeighbourListBox()
        {
            neighboursListBox.Items.Clear();
            neighboursListBox.Items.AddRange(((Node)nodesListBox.SelectedItem).Neighbours.ToArray());
            neighboursListBox.DisplayMember = "NodeName";

        }

        public void UpdateNodeListBox()
        {
            nodesListBox.Items.Clear();
            nodesListBox.Items.AddRange(nodes.ToArray());
            nodesListBox.DisplayMember = "NodeName";

        }

    }
}
