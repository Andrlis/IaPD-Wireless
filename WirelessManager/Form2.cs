using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WirelessManager
{
    public partial class Form2 : Form
    {
        private string password;

        public Form2(string networkName)
        {
            InitializeComponent();
            this.networkName.Text = networkName;
        }

        public string Password
        {
            get { this.Close(); return password; }
        }

        public void Method()
        {
            Thread.Sleep(1000000);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if(!pwdTextBox.Text.Equals(""))
            {
                password = pwdTextBox.Text;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Enter password.");
            }
        }
    }
}
