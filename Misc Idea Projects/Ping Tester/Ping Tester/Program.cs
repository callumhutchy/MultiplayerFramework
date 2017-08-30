using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace PingTester
{
    //Code used is from http://www.csharpdeveloping.net/Snippet/how_to_ping_ip
    //Will allow the ability to ping different servers and see which on provides the best connection.

    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            PingReply pingReply = ping.Send("8.8.8.8");

            Console.WriteLine("Address: {0}", pingReply.Address);
            Console.WriteLine("Time in milliseconds: {0}", pingReply.RoundtripTime);
            Console.WriteLine("Status: {0}", pingReply.Status);

            ping = new Ping();
            pingReply = ping.Send("bbc.co.uk");

            Console.WriteLine("Address: {0}", pingReply.Address);
            Console.WriteLine("Time in milliseconds: {0}", pingReply.RoundtripTime);
            Console.WriteLine("Status: {0}", pingReply.Status);

            ping = new Ping();
            pingReply = ping.Send("massivelyop.com");

            Console.WriteLine("Address: {0}", pingReply.Address);
            Console.WriteLine("Time in milliseconds: {0}", pingReply.RoundtripTime);
            Console.WriteLine("Status: {0}", pingReply.Status);

            Console.Read();

        }
    }
}
