using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo3
{
    public partial class LocationMove : Form
    {
        public LocationMove()
        {
            InitializeComponent();
            this.MouseMove += form_MouseMove;
        }
        public void form_MouseMove(object sender,EventArgs e)
        {
            MouseEventArgs me=(MouseEventArgs)e;
            label1.Text = me.X.ToString();
            label2.Text = me.Y.ToString();
        }
    }
}
