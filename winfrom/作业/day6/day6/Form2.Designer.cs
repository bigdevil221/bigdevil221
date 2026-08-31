namespace day6
{
    partial class Form2
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
            button1 = new AntdUI.Button();
            input4 = new AntdUI.Input();
            input3 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            input1 = new AntdUI.Input();
            label5 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(182, 351);
            button1.Name = "button1";
            button1.Size = new Size(85, 48);
            button1.TabIndex = 13;
            button1.Text = "编辑";
            // 
            // input4
            // 
            input4.Location = new Point(130, 225);
            input4.Multiline = true;
            input4.Name = "input4";
            input4.PlaceholderText = "请输入标签(一个标签占一行)";
            input4.Size = new Size(217, 97);
            input4.TabIndex = 9;
            // 
            // input3
            // 
            input3.Location = new Point(130, 175);
            input3.Name = "input3";
            input3.PlaceholderText = "0";
            input3.Size = new Size(217, 44);
            input3.TabIndex = 10;
            // 
            // input2
            // 
            input2.Location = new Point(130, 125);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入作者名称";
            input2.Size = new Size(217, 44);
            input2.TabIndex = 11;
            // 
            // input1
            // 
            input1.Location = new Point(130, 75);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入图书名称";
            input1.Size = new Size(217, 44);
            input1.TabIndex = 12;
            // 
            // label5
            // 
            label5.Location = new Point(66, 246);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 5;
            label5.Text = "标签：";
            // 
            // label4
            // 
            label4.Location = new Point(66, 186);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 6;
            label4.Text = "价格：";
            // 
            // label3
            // 
            label3.Location = new Point(66, 134);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 7;
            label3.Text = "作者：";
            // 
            // label2
            // 
            label2.Location = new Point(66, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 8;
            label2.Text = "图书名称：";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(182, 26);
            label1.Name = "label1";
            label1.Size = new Size(97, 43);
            label1.TabIndex = 4;
            label1.Text = "图书编辑";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(button1);
            Controls.Add(input4);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Input input4;
        private AntdUI.Input input3;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
    }
}