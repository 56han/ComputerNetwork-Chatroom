using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace _1
{
    public partial class Form1 : Form
    {
        TcpListener serverSocket;
        TcpClient clientSocket;
        bool on = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//server on
        {
            serverSocket = new TcpListener(8888);
            serverSocket.Start();
            label1.Text = "Server On";
            on = true;
        }

        private void button3_Click(object sender, EventArgs e)//server off
        {
            if (clientSocket != null)
            {
                clientSocket.Close();
            }
            if (on)
            {
                serverSocket.Stop();
                on = false;
                label1.Text = "Server Off";
            }
        }

        private void receive_Click(object sender, EventArgs e)//receive
        {
            if (clientSocket == null)
                   return;
            NetworkStream networkStream = clientSocket.GetStream();
            byte[] bytesFrom = new byte[1000];
            networkStream.Read(bytesFrom, 0, 100);
            string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
            label1.Text = dataFromClient;
            networkStream.Write(bytesFrom, 0, bytesFrom.Length);
            networkStream.Flush();
        }

        private void accept_Click(object sender, EventArgs e)//accept
        {
            if (!serverSocket.Pending())
            {
                label1.Text = "Wait for a client";
                return;
            }
            clientSocket = serverSocket.AcceptTcpClient();
            label1.Text = "Client Accepted";
        }
    }
}