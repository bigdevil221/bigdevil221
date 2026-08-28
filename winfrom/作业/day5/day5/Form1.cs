namespace day5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ld();
        }
        private Dictionary<string, string[]> selectinfo {  get; set; }
        //初始化数值+绑定事件
        private void Ld()
        {
            selectinfo = new Dictionary<string, string[]>
            {
                ["广东省"] = ["深圳市", "广州市", "东菀市"],
                ["河南省"] = ["洛阳市", "开封市", "平顶山市"]
            };
            foreach (var item in selectinfo)comboBox1.Items.Add(item.Key);
            comboBox1.SelectedIndexChanged += cb_change;
        }

        private void cb_change(object sender, EventArgs e)
        {
            //每次触发之前需要先清空第二个盒子里面的items
            comboBox2.Items.Clear();
            comboBox2.Text = "请选择城市";
            string pro = comboBox1.SelectedItem.ToString();
            comboBox2.Items.AddRange(selectinfo[pro]);
            this.ActiveControl = null;
        }
    }
}
