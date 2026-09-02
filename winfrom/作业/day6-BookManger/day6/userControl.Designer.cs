namespace day6
{
    partial class userControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "图书名称：";
            // 
            // label2
            // 
            label2.Location = new Point(62, 21);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 0;
            label2.Text = "";
            // 
            // label3
            // 
            label3.Location = new Point(98, 21);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 0;
            label3.Text = "作者：";
            // 
            // label4
            // 
            label4.Location = new Point(143, 21);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 0;
            label4.Text = "";
            // 
            // label5
            // 
            label5.Location = new Point(195, 21);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 0;
            label5.Text = "价格：";
            // 
            // label6
            // 
            label6.Location = new Point(236, 21);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 0;
            label6.Text = "";
            // 
            // label7
            // 
            label7.Location = new Point(332, 21);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 0;
            label7.Text = "label1";
            // 
            // label8
            // 
            label8.Location = new Point(298, 21);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 0;
            label8.Text = "标签：";
            // 
            // label9
            // 
            label9.Location = new Point(351, 21);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 0;
            label9.Text = "";
            // 
            // userControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "userControl";
            Size = new Size(426, 68);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
    }
}
