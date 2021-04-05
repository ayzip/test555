using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdasdasdasd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            String sourcecode = webclient.DownloadString("https://pastebin.com/raw/UqsyYb4t");

            if (!webclient.DownloadString("https://pastebin.com/raw/UqsyYb4t").Contains("1.1"))
            {
                MessageBox.Show("A new Update is available", "Update available");
                //Hier den Download noch reinsetzten :D
                Application.Exit();
            }
        }
    }
}

