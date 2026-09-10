namespace day15
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
            panel1 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            button5 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 437);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(356, 232);
            panel6.Name = "panel6";
            panel6.Size = new Size(336, 188);
            panel6.TabIndex = 5;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.ImageAlign = ContentAlignment.TopLeft;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(334, 30);
            label6.TabIndex = 5;
            label6.Text = "日志输出区";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(331, 189);
            dataGridView1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label1);
            panel5.Location = new Point(267, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(185, 38);
            panel5.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 19);
            label1.TabIndex = 0;
            label1.Text = "温控设备监控主界面";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button5);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(512, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 160);
            panel4.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.LimeGreen;
            button5.Location = new Point(93, 116);
            button5.Name = "button5";
            button5.Size = new Size(82, 31);
            button5.TabIndex = 6;
            button5.Text = "设定温度";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 87);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "请输入设定温度";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.ImageAlign = ContentAlignment.TopLeft;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 30);
            label5.TabIndex = 4;
            label5.Text = "设备控制区";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.LimeGreen;
            button4.Location = new Point(93, 45);
            button4.Name = "button4";
            button4.Size = new Size(82, 31);
            button4.TabIndex = 1;
            button4.Text = "停止";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Location = new Point(3, 45);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 1;
            button3.Text = "启动";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(205, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 160);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(299, 30);
            label4.TabIndex = 4;
            label4.Text = "监控画面区";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(19, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 160);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 3;
            label3.Text = "连接控制区";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(17, 106);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(143, 24);
            label2.TabIndex = 2;
            label2.Text = "当前状态：未连接";
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(93, 45);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 1;
            button2.Text = "断开PLC";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(3, 45);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 1;
            button1.Text = "连接PLC";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(655, 461);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(734, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Label label1;
        private Button button4;
        private Button button3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Panel panel6;
        private Label label6;
        private Button button5;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
