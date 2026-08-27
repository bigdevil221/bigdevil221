using System.Text.RegularExpressions;

namespace day4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setclick();
        }
        private List<Dictionary<string, Control>> goodlist = new();
        public void setclick()
        {
            //添加控件到字典，并将控件添加事件
            goodlist.Add(new Dictionary<string, Control>
            {
                ["price"] = label5,
                ["count"] = textBox1,
                ["add"] = button2,
                ["subtract"] = button1
            });

            goodlist.Add(new Dictionary<string, Control>
            {
                ["price"] = label6,
                ["count"] = textBox2,
                ["add"] = button4,
                ["subtract"] = button3
            });
            goodlist.ForEach(item => item["count"].TextChanged += tb_TextChanged);
            goodlist.ForEach(item => item["add"].Click += add_Click);
            goodlist.ForEach(item => item["subtract"].Click += sub_Click);
        }
        //减号方法
        private void sub_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            foreach (var item in goodlist)
            {
                //没做负值检测
                if (item["subtract"]==btn)
                {
                    int count= int.Parse(item["count"].Text);
                    count--;
                    item["count"].Text=count.ToString();
                }
            }
        }
        //加号方法
        private void add_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            foreach (var item in goodlist)
            {
                if (item["add"] == btn)
                {
                    int count = int.Parse(item["count"].Text);
                    count++;
                    item["count"].Text = count.ToString();
                }
            }
        }
        //文本行计算总值方法
        private void tb_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;
            //没做正则判断
            goodlist.ForEach(item =>
            {
                sum += int.Parse(item["price"].Text) * int.Parse(item["count"].Text);
            });
            label9.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗口加载阶段执行一次初始化数值
            int sum = 0;
            goodlist.ForEach(item =>
            {
                sum += int.Parse(item["price"].Text) * int.Parse(item["count"].Text);
            });
            label9.Text = sum.ToString();
        }
    }
}
