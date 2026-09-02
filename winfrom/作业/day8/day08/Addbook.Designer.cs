namespace day08
{
    partial class Addbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            input3 = new AntdUI.Input();
            inputNumber1 = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(140, -9);
            label1.Name = "label1";
            label1.Size = new Size(156, 82);
            label1.TabIndex = 0;
            label1.Text = "图书编辑";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(59, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 1;
            label2.Text = "图书名称";
            // 
            // label3
            // 
            label3.Location = new Point(59, 132);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 1;
            label3.Text = "作者";
            // 
            // label4
            // 
            label4.Location = new Point(59, 195);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 1;
            label4.Text = "价格";
            // 
            // label5
            // 
            label5.Location = new Point(59, 265);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 1;
            label5.Text = "标签";
            // 
            // input1
            // 
            input1.Location = new Point(154, 58);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入图书名称";
            input1.Size = new Size(170, 45);
            input1.TabIndex = 2;
            // 
            // input2
            // 
            input2.Location = new Point(154, 132);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入作者";
            input2.Size = new Size(170, 45);
            input2.TabIndex = 2;
            // 
            // input3
            // 
            input3.Location = new Point(154, 244);
            input3.Name = "input3";
            input3.PlaceholderText = "请输入标签";
            input3.Size = new Size(170, 100);
            input3.TabIndex = 2;
            input3.UseContextMenu = false;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(154, 195);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(170, 43);
            inputNumber1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(164, 360);
            button1.Name = "button1";
            button1.Size = new Size(123, 46);
            button1.TabIndex = 4;
            button1.Text = "提交编辑";
            button1.Click += button1_Click;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 431);
            Controls.Add(button1);
            Controls.Add(inputNumber1);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addbook";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Input input1;
        private AntdUI.Input input2;
        private AntdUI.Input input3;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Button button1;
    }
}