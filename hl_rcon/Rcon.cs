using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;


namespace hl_rcon
{
    public struct Server
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public string RconPassword { get; set; }
    }

    class Rcon
    {
        public static string SendRconMessage(Server remoteServer, string rconCommand)
        {
            string result = string.Empty;
            UdpClient client = new UdpClient();
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] bufferSend = PrepareCommand("challenge rcon\n");
            byte[] bufferRec;

            try
            {
                client.Connect(remoteServer.Address, remoteServer.Port);
                client.Send(bufferSend, bufferSend.Length);
                bufferRec = client.Receive(ref remoteIpEndPoint);
            }
            catch (SocketException)
            {
                throw new Exception("Nie udało się połączyć z serwerem!");
            }

            if (bufferRec != null)
            {
                string challenge_rcon = Encoding.ASCII.GetString(bufferRec);
                challenge_rcon = string.Join(null, Regex.Split(challenge_rcon, "[^\\d]"));

                string command = $"rcon \"{challenge_rcon}\" {remoteServer.RconPassword} {rconCommand} \n";
                bufferSend = PrepareCommand(command);
            }

            try
            {
                client.Send(bufferSend, bufferSend.Length);
                bufferRec = client.Receive(ref remoteIpEndPoint);
                result = Encoding.ASCII.GetString(bufferRec);
                client.Close();
            }
            catch (SocketException)
            {
                throw new Exception("Nie udało się połączyć z serwerem! Kod: 2");
            }

            return result.Length >= 5 ? result.Remove(0, 5) : result;
        }

        static byte[] PrepareCommand(string command)
        {
            byte[] bufferTemp = Encoding.ASCII.GetBytes(command);
            byte[] bufferSend = new byte[bufferTemp.Length + 4];

            for (int i = 0; i < 4; i++)
                bufferSend[i] = 0xFF;

            int j = 4;

            for (int i = 0; i < bufferTemp.Length; i++)
                bufferSend[j++] = bufferTemp[i];

            return bufferSend;
        }
    }
}
