namespace day6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            input4 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            inputNumber1 = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(176, 12);
            label1.Name = "label1";
            label1.Size = new Size(97, 43);
            label1.TabIndex = 0;
            label1.Text = "图书新增";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(60, 72);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 1;
            label2.Text = "图书名称：";
            // 
            // label3
            // 
            label3.Location = new Point(60, 120);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 1;
            label3.Text = "作者：";
            // 
            // label4
            // 
            label4.Location = new Point(60, 172);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 1;
            label4.Text = "价格：";
            // 
            // label5
            // 
            label5.Location = new Point(60, 232);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 1;
            label5.Text = "标签：";
            // 
            // input1
            // 
            input1.Location = new Point(124, 61);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入图书名称";
            input1.Size = new Size(217, 44);
            input1.TabIndex = 2;
            // 
            // input4
            // 
            input4.Location = new Point(124, 211);
            input4.Multiline = true;
            input4.Name = "input4";
            input4.PlaceholderText = "请输入标签(一个标签占一行)";
            input4.Size = new Size(217, 97);
            input4.TabIndex = 2;
            // 
            // input2
            // 
            input2.Location = new Point(124, 111);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入作者名称";
            input2.Size = new Size(217, 44);
            input2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(176, 337);
            button1.Name = "button1";
            button1.Size = new Size(85, 48);
            button1.TabIndex = 3;
            button1.Text = "新增";
            button1.Click += button1_Click;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(124, 161);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.PlaceholderText = "请输入价格";
            inputNumber1.Size = new Size(217, 44);
            inputNumber1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 414);
            Controls.Add(inputNumber1);
            Controls.Add(button1);
            Controls.Add(input4);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Input input1;
        private AntdUI.Input input4;
        private AntdUI.Input input2;
        private AntdUI.Button button1;
        private AntdUI.InputNumber inputNumber1;
    }
}
