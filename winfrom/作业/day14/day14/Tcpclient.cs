using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace day14
{
    public partial class Tcpclient : Form
    {
        private TcpClient tcpclient;
        private NetworkStream stream;
        private byte[] buffer;
        private bool isconnect = false;
        private int y = 0;
        public Tcpclient()
        {
            InitializeComponent();
            this.button2.Enabled = false;
            this.textBox3.Enabled = false;
        }
        //连接tcp服务
        private async void button1_Click(object sender, EventArgs e)
        {
            string IP = textBox1.Text;
            int PORT = int.Parse(textBox2.Text);
            tcpclient = new TcpClient();
            try
            {
                await tcpclient.ConnectAsync(IPAddress.Parse(IP), PORT);
                //创建数据流
                stream = tcpclient.GetStream();
                MessageBox.Show("连接成功");
            }
            catch (Exception)
            {
                MessageBox.Show("连接失败！");
            }
            buffer = new byte[1024];
            this.button2.Enabled = true;
            this.textBox3.Enabled = true;
            this.button1.Enabled = false;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            //读数据
            while (true)
            {
                //读不到不会往下执行
                int len = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (len == 0)
                {
                    break;
                }
                string getData = Encoding.UTF8.GetString(buffer,0,len);
                Label lab = new Label();
                lab.Text = getData;
                lab.Size = new Size(panel1.Width, 30);
                lab.Font = new Font("微软雅黑", 12);
                lab.Location = new Point(0, y);
                y += 30;
                panel1.Controls.Add(lab);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string sendData = textBox3.Text;
            buffer = Encoding.UTF8.GetBytes(sendData);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}
