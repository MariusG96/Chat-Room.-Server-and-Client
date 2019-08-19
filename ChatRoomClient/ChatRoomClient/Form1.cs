using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChatRoomClient
{
    public partial class Form1 : Form
    {
        Socket socket;
        byte[] buffer = new byte[256];

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DisplayTextBox.ScrollBars = ScrollBars.Vertical;

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string ipaddress = IpaddressTextBox.Text;
            int port = int.Parse(PortTextBox.Text);

            Connect(ipaddress, port);
        }

        private void Connect(string ipaddress, int port)
        {
            try
            {
                // Try to make a socket connection
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.BeginConnect(ipaddress, port, ConnectHandler, socket);
            }
            catch (Exception ex)
            {
                DisplayTextBox.AppendText("Socket Connection error:\n" + ex.ToString());
            }
        }

        private void ConnectHandler(IAsyncResult info)
        {
            //Which socket is this using?
            Socket s = (Socket)info.AsyncState;

            //Complete The Connection
            try
            {
                s.EndConnect(info);
                DisplayTextBox.AppendText("Connected to a server" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                DisplayTextBox.AppendText("Could not Connect to the server as it is refusing any connection" + Environment.NewLine);
            }

            // Set up an event handler for receiving messages on socket s
            Receive(s);
            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Transmit(socket, MessageTextBox.Text);
        }

        private void Transmit(Socket s, string text)
        {
            try
            {
                string nickname = NameBox.Text;
                //Prepare Message
                byte[] messageBytes = Encoding.ASCII.GetBytes(nickname + ": " + text);

                // Send it
                s.BeginSend(messageBytes, 0, messageBytes.Length, 0,
                new AsyncCallback(TransmitHandler), s);
            }
            catch (Exception ex)
            { }
        }

        private void TransmitHandler(IAsyncResult info)
        {
            try
            {
                // Which socket is this using?
                Socket s = (Socket)info.AsyncState;

                int bytesSent = s.EndSend(info);
            }
            catch (Exception ex)
            { }
        }

        private void Receive(Socket s)
        {
            try
            {
                s.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None,
                     ReceiveHandler, s);
            }
            catch (Exception ex)
            { } // Do nothing if there's an exception
        }

        private void ReceiveHandler(IAsyncResult info)
        {

            try
            {

                // Which socket is this using?
                Socket s = (Socket)info.AsyncState;

                // Read Message
                int numBytesReceived = s.EndReceive(info);
                string message = Encoding.ASCII.GetString(buffer, 0, numBytesReceived);

                //Update Display
                DisplayTextBox.AppendText(message);

                //Reset The event Handler for new incoming messages on socket s
                Receive(s);
            }
            catch (Exception ex)
            { }
        }


        private void StopButton_Click(object sender, EventArgs e)
        {
            socket.Close();
        }


    }
}