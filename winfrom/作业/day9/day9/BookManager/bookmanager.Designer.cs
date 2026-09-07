namespace day9.BookManager
{
    partial class bookmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookmanager));
            button1 = new AntdUI.Button();
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(342, 349);
            button1.Name = "button1";
            button1.Size = new Size(133, 58);
            button1.TabIndex = 0;
            button1.Text = "新增图书";
            button1.Click += button1_Click;
            // 
            // table1
            // 
            table1.BackColor = Color.BurlyWood;
            table1.Gap = 12;
            table1.Location = new Point(90, 84);
            table1.Name = "table1";
            table1.Size = new Size(646, 250);
            table1.TabIndex = 1;
            table1.Text = "table1";
            // 
            // bookmanager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(table1);
            Controls.Add(button1);
            Name = "bookmanager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bookmanager";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Table table1;
    }
}