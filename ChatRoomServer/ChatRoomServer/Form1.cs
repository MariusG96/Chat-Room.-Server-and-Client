using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatRoomServer
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client;
        Thread thread;
        object hum = new object();
        Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;         
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int port = int.Parse(PortTextBox.Text);

            Listen(port);
        }

        private void Listen(int port)
        {
            int count = 1;

            // Listen for input coming from any IP address on specified port
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            DisplayTextBox.AppendText("Server Running" + Environment.NewLine);

            try
            { 
                while (true)
                {
                    // Create an event handler for dealing with incoming connections
                    client = listener.AcceptTcpClient();
                    lock (hum) list_clients.Add(count, client);


                    thread = new Thread(receiver);
                    thread.Start(count);
                    count++;
                }
            }
            catch(Exception) { }
            //For some reason it kind of crashes but it continues to run still receiving users, broadcasting messages, etc......
        }

        private void receiver(object o)
        {

            int id = (int)o;
            TcpClient client;
            lock (hum) client = list_clients[id];
           
            try
            { 
                while (true)
                {
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int byte_count = stream.Read(buffer, 0, buffer.Length);

                    if (byte_count == 0)
                    {
                        break;
                    }

                    string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                    //DisplayTextBox.AppendText(data + Environment.NewLine);
                    broadcast(data);
                    
                }
            }
            catch(Exception) { }

            lock (hum) list_clients.Remove(id);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();
        }

        private void broadcast(string data)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);

            lock (hum)
            {
                foreach (TcpClient c in list_clients.Values)
                {
                    NetworkStream stream = c.GetStream();

                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            listener.Stop();
        }


    }
}