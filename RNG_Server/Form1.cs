using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace RNG_Server
{
    public partial class Form1 : Form
    {
        private RNG_Server Server;
        private Socket ServerSocket;
        private Thread Service;
        public Form1()
        {
            InitializeComponent();
            Server = new RNG_Server("127.0.0.1");
            Service = new Thread(new ThreadStart(Server_Task));
        }

        private void btnOpenConn_Click(object sender, EventArgs e)
        {
            Service.Start();
            status.ForeColor = Color.ForestGreen;
        }

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            Server.StopServer(ref ServerSocket);
            status.ForeColor = Color.Coral;
        }

        private void Server_Task()
        {
            Server.StartServer(ref ServerSocket);
        }
    }
    public class RNG_Server
    {
        private string? data;
        private string? IP;
        private int port;
        private string[] log;

        public RNG_Server()
        {
            data = null;
            IP = "127.0.0.1";
            port = 0;
        }

        public RNG_Server(string IP_server)
        {
            IP = IP_server;
            port = 5000;
        }
        public RNG_Server(string IP_server, int Port)
        {
            IP = IP_server;
            port = Port;
        }
        public void StartServer(ref Socket socket)
        {

            byte[] inboundMsg = new byte[1024];
            int requestNumber;
            int maxNumber;
            IPAddress ip = IPAddress.Parse(IP);
            IPEndPoint Server_EndPoint = new IPEndPoint(ip, port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Bind(Server_EndPoint);
                socket.Listen(2);

                while (true)
                {
                    Socket handler = socket.Accept();

                    while (true)
                    {
                        int bytesReceived = handler.Receive(inboundMsg);
                        data += Encoding.ASCII.GetString(inboundMsg, 0, bytesReceived);
                        if (data.IndexOf("-") > -1)
                        { break; }
                    }
                    requestNumber = data.Substring(0, data.LastIndexOf("?") + 1).Length;
                    data = data.Remove(0, data.LastIndexOf("?") + 1);
                    data = data.Replace("-", "");
                    int[] vs = new int[requestNumber];
                    int limit = Convert.ToInt16(data);
                    for (int i = 0; i < requestNumber; i++)
                    {
                        Random random = new Random();
                        vs[i] = random.Next(limit);
                    }
                    string outMsg = "";

                    for (int i = 0; i < vs.Length; i++)
                        outMsg += Convert.ToString(vs[i]) + " - ";

                    byte[] outputMsg = new byte[1024];
                    outputMsg = Encoding.ASCII.GetBytes(outMsg);
                    handler.Send(outputMsg);
                    handler.Disconnect(true);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void StopServer(ref Socket socket)
        {
            socket.Close();
        }


    }
}
