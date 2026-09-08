using System;
using System.Collections.Generic;
using System.Text;

namespace day13
{
    internal class label
    {
        public Label lab { set; get; }
        public System.Windows.Forms.Timer labtimer = new();
        public label(Label lab, System.Windows.Forms.Timer labtimer)
        {
            this.lab = lab;
            this.labtimer = labtimer;
        }
    }
}
