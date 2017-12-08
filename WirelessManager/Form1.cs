using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WirelessManager.Bean;
using WirelessManager.Resources;

namespace WirelessManager
{
    public partial class Form1 : Form
    {
        private UpdateInfo refresher;
        private List<NetworkConnection> connections;
        private Form2 form2;
        private NetworkConnection connection;

        public Form1()
        {
            refresher = new UpdateInfo();
            InitializeComponent();
            InitilizeInformation();
            ShowNetworkList();


            refresher.AddListerenToTimer(Refresh);
            refresher.Start();
        }

        private void InitilizeInformation()
        {
            name.Text = "";
            macAddress.Text = "";
            quality.Text = "";
            authType.Text = "";
        }

        private void Refresh(object sender, EventArgs e)
        {
            ShowNetworkList();
        }

        private void SetInformation(NetworkConnection connection)
        {
            if (connection.IsConnected)
            {
                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
            }
            else
            {
                connectButton.Enabled = true;
                disconnectButton.Enabled = false;
            }

            name.Text = connection.NetworkName;
            macAddress.Text = connection.MacAddress;
            quality.Text = connection.SignalStrength.ToString() + "%";
            authType.Text = connection.AuthenticationType;
        }

        private void ShowNetworkList()
        {
            if (!InvokeRequired)
            {
                List<NetworkConnection> list = NetworkManager.GetNetworkConnectionList();
                if (Equals(connections, list))
                {
                    return;
                }

                listView1.Clear();

                connections = list;
                foreach (var connection in list)
                {
                    listView1.Items.Add(connection.NetworkName);
                }
            }
            else
            {
                Invoke(new Action(ShowNetworkList));
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection = connections[listView1.SelectedIndices[0]];
                SetInformation(connection);
            }
            catch
            {
                ShowNetworkList();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            form2 = new Form2(connection.NetworkName);
            form2.Show();
            form2.VisibleChanged += PassworldEntering;
        }

        private void PassworldEntering(object sender, EventArgs e)
        {
            string password = form2.Password;

            form2 = null;

            connection.Connect(password, CheckConnectionSuccess);
        }

        private void CheckConnectionSuccess(bool success)
        {
            if (success)
            {
                MessageBox.Show("Connect");
                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Try again");

            }
            //MessageBox.Show(success ? "Connect" : "Try again");
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            NetworkConnection.Disconnect();
            SetInformation(connection);
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
