using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIPv2
{
    class Packet
    {
        public string Message { get; }
        public string Destination { get; }

        public Packet(string message, string destination)
        {
            Message = message;
            Destination = destination;
        }

    }
}
