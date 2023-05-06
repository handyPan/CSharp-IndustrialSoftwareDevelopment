using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Entity;

namespace ModbusTCPApp
{
    public partial class frmModbusTCPApp : Form
    {
        public frmModbusTCPApp()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(this.btnConnect.Text=="Connect")
            {
                if (Connect(this.cmbIP.Text.Trim(), this.txtPort.Text.Trim()))
                {
                    this.lblConnectionState.Text = "Connection OK";
                    this.lblConnectionState.ForeColor = Color.FromArgb(0, 192, 0);
                    this.btnConnect.Text = "Disconnect";
                }
                else
                {
                    this.lblConnectionState.Text = "Connection Failed";
                    this.lblConnectionState.ForeColor = Color.Red;
                }
            }
            else
            {
                tcpClient.Disconnect(true);
                this.btnConnect.Text = "Connect";
                this.lblConnectionState.Text = "Connection State";
                this.lblConnectionState.ForeColor = Color.Black;
            }
        }

        Socket tcpClient; 
        /// <summary>
        /// Set up Socket connection.
        /// </summary>
        /// <param name="ip">IP Address</param>
        /// <param name="port">Port Number</param>
        /// <returns></returns>
        private bool Connect(string ip, string port)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(port));
            tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                tcpClient.Connect(ie);
            }
            catch (SocketException)
            {

                return false;
            }
            return true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            byte[] res = readOutputStatus(0, 20);
            this.lstData.Items.Clear();
            for(int i=0;i<res.Length;i++)
            {
                this.lstData.Items.Add(res[i]);
            }
        }

        /// <summary>
        /// function 0x01 - read output coil
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        private byte[] readOutputStatus(int addr, int len)
        {
            byte[] result = null;
            // concatenate datagram
            ByteArray byteArray = new ByteArray(12);
            byteArray.Add(new byte[] 
            {
                0, 0, 0, 0, 0, 6, 1, 1
            });
            byteArray.Add((byte)((addr-addr%256)/256));
            byteArray.Add((byte)(addr%256));
            byteArray.Add((byte)((len - len % 256) / 256));
            byteArray.Add((byte)(len % 256));
            // send datagram
            tcpClient.Send(byteArray.array, byteArray.array.Length, SocketFlags.None);
            // receive datagram
            byte[] data = new byte[512];
            tcpClient.Receive(data, 512, SocketFlags.None);
            // determine datagram
            int length = 0;
            if(len % 8 == 0)
            {
                length = len / 8;
            }
            else
            {
                length = len / 8 + 1;
            }
            if (length == data[8])
            {
                // parse datagram
                result = byteMsgToRes(data, 9, length);
            }

            return result;
        }

        /// <summary>
        /// parse byte array
        /// </summary>
        /// <param name="msgByte"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private byte[] byteMsgToRes(byte[] msgByte, int start, int length)
        {
            byte[] result = null;
            if (msgByte != null && msgByte.Length > 0)
            {
                result = new byte[length];
                for(int i=0;i<length;i++)
                {
                    result[i] = msgByte[i + start];
                }
            }
            return result;
        }
    }
}
