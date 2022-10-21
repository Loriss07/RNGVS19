using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace RNG_Client
{
    public partial class Form1 : Form
    {
        private RNG_Client Client;
        private Socket ClientSocket;
        private string IP;
        private int maxNum;
        private int requests;
        public Form1()
        {
            InitializeComponent();
            Client = new RNG_Client("127.0.0.1");
            IPBar.Text = "127.0.0.1";
            maxNum = Convert.ToInt16(maxNumber.Value);
            requests = Convert.ToInt16(numAmount.Value);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string result = Client.Connect(ref ClientSocket);
            if (result == null)
            {
                MessageBox.Show(result);
                BtnDisconnect.Enabled = true;
                Generate.Enabled = true;
            }

        }

        private void IPBar_TextChanged(object sender, EventArgs e)
        {
            IP = IPBar.Text;
            Client.IP = IP;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
                Num.Items.Add(Client.Request(ref ClientSocket, requests, maxNum));
        }

        private void maxNumber_ValueChanged(object sender, EventArgs e)
        {
            maxNum = Convert.ToInt16(maxNumber.Value);
        }

        private void Numbers_ValueChanged(object sender, EventArgs e)
        {
            requests = Convert.ToInt16(numAmount.Value);
        }
    }
    public class RNG_Client
    {
        private string? data;
        private string _IP;
        private int port;

        public RNG_Client()
        {
            data = null;
            _IP = "127.0.0.1";
            port = 0;
        }

        public RNG_Client(string IP_server)
        {
            _IP = IP_server;
            port = 5000;

        }
        public RNG_Client(string IP_server, int Port)
        {
            _IP = IP_server;
            port = Port;

        }
        public string? IP { get; set; }
        public string Connect(ref Socket socket)
        {
            string output;
            try
            {
                IPAddress ip = IPAddress.Parse(_IP);
                IPEndPoint Client_EndPoint = new IPEndPoint(ip, port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(Client_EndPoint);
                output = null;
            }
            catch (Exception ex)
            {
                socket = null;
                output = ex.Message;
            }
            return output;
        }
        public string Request(ref Socket socket, int requests, int MaxValue)
        {
            byte[] bytes = new byte[1024];
            string? inboundMsg = null;
            try
            {
                string output = "";
                output = "";
                for (int i = 0; i < requests; i++)
                    output += "?";

                output += Convert.ToString(MaxValue) + "-";
                byte[] outMsg = Encoding.ASCII.GetBytes(output);
                socket.Send(outMsg);

                int bytesReply = socket.Receive(bytes);
                inboundMsg = Encoding.ASCII.GetString(bytes, 0, bytesReply);

               
            }
            catch (Exception ex)
            {
                inboundMsg = "";
            }

            return inboundMsg;
        }


    }
}
