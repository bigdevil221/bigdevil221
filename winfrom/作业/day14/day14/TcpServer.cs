using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace day14
{
    public partial class TcpServer : Form
    {
        private TcpListener tcpserver;
        private TcpClient tcpclient;
        private NetworkStream stream;
        private byte[] buffer;
        private bool isconnect=false;
        private int y=0;
        public TcpServer()
        {
            InitializeComponent();
            new Tcpclient().Show();
            //发送按钮关闭
            this.button2.Enabled = false;
            this.textBox2.Enabled = false;
        }
        //打开服务按钮 建立tcp服务
        private async void button1_Click(object sender, EventArgs e)
        {
            string IP = "127.0.0.1";
            bool isPORT=int.TryParse(textBox1.Text,out int PORT);
            if (!isPORT||PORT<0||PORT>65535)
            {
                MessageBox.Show("端口号输入有误！");
                return;
            }
            //创建tcp服务器
            tcpserver = new TcpListener(IPAddress.Parse(IP), PORT);
            tcpserver.Start();
            isconnect = true;
            MessageBox.Show("连接成功");
            try
            {
                //创建tcp等待客户端
                tcpclient = await tcpserver.AcceptTcpClientAsync();
                //创建数据流
                stream = tcpclient.GetStream();
            }
            catch (Exception ex)
            {
                //异常执行卸掉资源
                tcpserver.Stop();
                tcpserver.Dispose();
                MessageBox.Show("数据流创建失败");
            }
            buffer=new byte[1024];
            //进行到这里成功就把建立连接关闭
            this.button2.Enabled = true;
            this.textBox2.Enabled = true;
            this.button1.Enabled = false;
            //读数据
            while (true)
            {
                int len=await stream.ReadAsync(buffer,0, buffer.Length);
                if (len == 0)
                {
                    break;
                }
                //将拿到的数据转为字符串
                string getData=Encoding.UTF8.GetString(buffer,0,len);
                //创建新的lab，并将lab存放在控件中
                Label lab = new Label();
                lab.Text = getData;
                lab.Size = new Size(panel1.Width, 30);
                lab.Font = new Font("微软雅黑", 12);
                lab.Location = new Point(0, y);
                y += 30;
                panel1.Controls.Add(lab);
            }
        }
        //发送信息按钮
        private async void button2_Click(object sender, EventArgs e)
        {
            string sendData = textBox2.Text;
            buffer = Encoding.UTF8.GetBytes(sendData);
            try
            {
                await stream.WriteAsync(buffer, 0, buffer.Length);
            }
            catch (Exception)
            {
                isconnect = false;
                MessageBox.Show("发送消息出错");
            }
        }
    }
}
