using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Title = "请选择检测轮胎数量的图片";
                OFD.Filter = "图片|*.jpg;*.jpeg;*.png;*.gif;";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(OFD.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // 使用VisonPro中的图片处理工具 打开图片
                    CogImageFileTool CFT = new CogImageFileTool();
                    CFT.Operator.Open(OFD.FileName, CogImageFileModeConstants.Read);
                    CFT.Run(); // 图片处理工具运行

                    // 拼接 视觉方案的绝对路径
                    string VppFilePath = Path.Combine(Directory.GetCurrentDirectory(), "vpp", "123.vpp");

                    // 将vpp文件中的视觉方案读取到 C#中 
                    object LOF = CogSerializer.LoadObjectFromFile(VppFilePath);

                    // 因为读取后 默认是 object 类型; 不具备Cog工具对象的运行方法,所以转给工具类型
                    CogToolBlock CTB = (LOF as CogToolBlock);

                    // 将CogImageFileTool工具读取到的输出图像 作为(视觉方案)CTB 的 输入图像
                    CTB.Inputs["OutputImage"].Value = CFT.OutputImage;
                    CTB.Run();

                    //MessageBox.Show(CTB.Outputs["Result_Count"].Value.ToString());
                    label1.Text = CTB.Outputs["Results_GetBlobs_Count"].Value.ToString();
                }
            }
        }
    }
}

