using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

class Server
{
    public void startServer()
    {
        byte[] adr = { 127, 0, 0, 1 };
        IPAddress ipAdr = new IPAddress(adr);
        TcpListener newsock = new TcpListener(ipAdr, 6000);
        newsock.Start();
        Console.WriteLine("Waiting for a client...");

        string a = "A";
        byte[] data2 = Encoding.ASCII.GetBytes(a);
        System.Console.WriteLine(data2.Length);






        while (true)
        {
            TcpClient client = newsock.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            byte[] bytesFrom = new byte[1024];
            byte[] newBytes = new byte[0];
            ns.Read(bytesFrom, 0, bytesFrom.Length);

            for (int i = 0; i < bytesFrom.Length; i++)
            {
                if (bytesFrom[i] == 0)
                {
                    newBytes = new byte[i];
                    for (int b = 0; b < i; b++)
                    {

                        // byte[] newBytes = new byte[17];
                        newBytes[b] = bytesFrom[b];
                    }
                    break;
                }

            }

            string data1 = Encoding.ASCII.GetString(newBytes);
            System.Console.WriteLine(data1);

            string json = data1;
            User user = JsonConvert.DeserializeObject<User>(json);

            System.Console.WriteLine(user.ToString());
            ns.Flush();

        }
    }
}