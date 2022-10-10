using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sysfuck
{
    public partial class fuckedlol : Form
    {
        public fuckedlol()
        {
            InitializeComponent();
        }

        private void fuckedlol_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
