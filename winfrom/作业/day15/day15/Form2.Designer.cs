namespace day15
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 437);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(391, 395);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 5;
            label6.Text = "平均温度：";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(183, 395);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 5;
            label5.Text = "最低温度：";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(14, 395);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 5;
            label4.Text = "最高温度：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(325, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(249, 52);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 3;
            label3.Text = "结束时间";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(46, 52);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 3;
            label2.Text = "开始时间";
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(587, 41);
            button2.Name = "button2";
            button2.Size = new Size(95, 39);
            button2.TabIndex = 2;
            button2.Text = "导出";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(474, 41);
            button1.Name = "button1";
            button1.Size = new Size(95, 39);
            button1.TabIndex = 2;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(682, 284);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("宋体", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(274, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 0;
            label1.Text = "历史温度数据查询";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(734, 461);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
    }
}