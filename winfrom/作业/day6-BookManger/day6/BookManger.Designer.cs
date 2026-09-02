namespace day6
{
    partial class BookManger
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
            addBtn = new AntdUI.Button();
            eitBtn = new AntdUI.Button();
            showBtn = new AntdUI.Button();
            panel1 = new AntdUI.Panel();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(59, 51);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(135, 56);
            addBtn.TabIndex = 0;
            addBtn.Text = "新增图书";
            // 
            // eitBtn
            // 
            eitBtn.Location = new Point(59, 144);
            eitBtn.Name = "eitBtn";
            eitBtn.Size = new Size(135, 56);
            eitBtn.TabIndex = 0;
            eitBtn.Text = "编辑图书";
            // 
            // showBtn
            // 
            showBtn.Location = new Point(59, 242);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(135, 56);
            showBtn.TabIndex = 0;
            showBtn.Text = "展示图书";
            // 
            // panel1
            // 
            panel1.Back = SystemColors.Control;
            panel1.Location = new Point(235, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 301);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // BookManger
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(showBtn);
            Controls.Add(eitBtn);
            Controls.Add(addBtn);
            Name = "BookManger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookManger";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button addBtn;
        private AntdUI.Button eitBtn;
        private AntdUI.Button showBtn;
        private AntdUI.Panel panel1;
    }
}