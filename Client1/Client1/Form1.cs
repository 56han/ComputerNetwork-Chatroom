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

namespace Client1
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket;


        public Form1()
        {
            InitializeComponent();
            InitializeMyControl();
        }
        private void InitializeMyControl()
        {
            textBox1.Text = "test!";
        }


        private void button1_Click(object sender, EventArgs e)//connet
        {
            clientSocket = new TcpClient();
            try
            {
                clientSocket.Connect("127.0.0.1", 8888);
            }
            catch (Exception ex)
            {
                label1.Text = "Sever not found";
                clientSocket = null;
                return;
            }
            label1.Text = "Connected";
        }

        private void button2_Click(object sender, EventArgs e)//send receive
        {
            if (clientSocket == null)
            {
                label1.Text = "Server is Off";
                return;
            }
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox1.Text);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            label1.Text = "Send: " + textBox1.Text;

            byte[] inStream = new byte[1000];
            serverStream.Read(inStream, 0, 100);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            label1.Text = "Recv:" + returndata;
        }

        
    }
}