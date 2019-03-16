using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] adr = { 127, 0, 0, 1 };
            TcpClient client = new TcpClient();

            client.Connect("127.0.0.1", 5000);

            NetworkStream nstrm = client.GetStream();

            byte[] abyString = Encoding.ASCII.GetBytes("Hello from client");
            nstrm.Write(abyString, 0, abyString.Length);
            nstrm.Flush();

            while (true)
            {

                byte[] outMsg = Encoding.ASCII.GetBytes(Console.ReadLine());

                nstrm.Write(outMsg, 0, outMsg.Length);
                nstrm.Flush();

            }
        }
    }
}
