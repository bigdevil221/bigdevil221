using Modbus.Device;
using System.IO.Ports;

namespace day15
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private IModbusSerialMaster master;
        public Form1()
        {
            InitializeComponent();
        }
        //打开服务
        private void button1_Click(object sender, EventArgs e)
        {
            //创建串口对象
            myport = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            myport.Open();
            //创建modbus对象
            master = ModbusSerialMaster.CreateRtu(myport);
            master.Transport.ReadTimeout = 2000;
            master.Transport.Retries = 3;
        }

        //启动按钮
        private async void button2_Click(object sender, EventArgs e)
        {
            await master.WriteSingleRegisterAsync(2, 100, 1);
        }
        //暂停
        private void button3_Click(object sender, EventArgs e)
        {
            master.WriteSingleRegister(2, 100, 0);
        }
        //正转
        private void button4_Click(object sender, EventArgs e)
        {
            master.WriteSingleRegister(2,101,1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            master.WriteSingleRegister(2, 101, 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isspeed= int.TryParse(textBox1.Text, out int speed);
            if (!isspeed||speed<0||speed>10000)
            {
                MessageBox.Show("输入转速有误");
                return;
            }
            master.WriteSingleRegister(2, 102, (ushort)speed);
        }
    }
}
