namespace day6
{
    public partial class Form1 : Form
    {
        //form1窗体是增加图书
        public Form1()
        {
            InitializeComponent();
        }
        internal event Action<bookinfo> sendData;

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            string bookname = input1.Text;
            string author = input2.Text;
            double price = (double)inputNumber1.Value; ;
            string lab = input4.Text;
            bool isborrow = false;
            sendData.Invoke(new bookinfo(id, bookname, author, price, lab, isborrow));
            this.Close();
        }
        
    }
}
