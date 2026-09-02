namespace day08
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
            dataGridView1 = new DataGridView();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            button4 = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(752, 372);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(29, 404);
            button1.Name = "button1";
            button1.Size = new Size(118, 41);
            button1.TabIndex = 1;
            button1.Text = "新增图书";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 404);
            button2.Name = "button2";
            button2.Size = new Size(118, 41);
            button2.TabIndex = 1;
            button2.Text = "编辑图书";
            // 
            // button3
            // 
            button3.Location = new Point(453, 404);
            button3.Name = "button3";
            button3.Size = new Size(118, 41);
            button3.TabIndex = 1;
            button3.Text = "删除图书";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(663, 404);
            button4.Name = "button4";
            button4.Size = new Size(118, 41);
            button4.TabIndex = 1;
            button4.Text = "查询图书";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 471);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Button button4;
    }
}
