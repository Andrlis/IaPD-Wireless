using System;
using SimpleWifi;
using SimpleWifi.Win32.Interop;

namespace WirelessManager.Bean
{
    class NetworkConnection
    {
        private AccessPoint accessPoint;
        private string macAddress;

        public NetworkConnection() { }

        public NetworkConnection(AccessPoint accessPoint, string macAddress)
        {
            this.accessPoint = accessPoint;
            this.macAddress = macAddress;
        }

        public string MacAddress
        {
            get { return macAddress; }
            set { this.macAddress = value; }
        }

        public string NetworkName
        {
            get { return accessPoint?.Name; }
        }

        public int SignalStrength
        {
            get { return (int)accessPoint.SignalStrength; }
        }

        public bool IsConnected
        {
            get { return accessPoint.IsConnected; }
        }

        public string AuthenticationType
        {
            get
            {

                var network = new WlanAvailableNetwork();
                return network.dot11DefaultAuthAlgorithm.ToString();

                //var cipherAlgorithm = accessPoint.ToString().Split()[10];
                //var authAlgorithm = accessPoint.ToString().Split()[6];

                //switch(cipherAlgorithm)
                //{
                //    case "None":
                //        return "Open";
                //    case "Wep":
                //        return "Wep";
                //    case "CCMP":
                //    case "TKIP":
                //        return (authAlgorithm.Equals("RSNA") ? "WPA2-Enterprise-PEAP-MSCHAPv2" : "WPA2-PSK");
                //    default:
                //        return "Unknown";
                //}
            }
        }

        public bool Equals(NetworkConnection connection)
        {
            return this.NetworkName.Equals(connection.NetworkName) && (this.IsConnected == connection.IsConnected);
        }

        public void ConnectAsync(AuthRequest authRequest, Action<bool> onConnectComplete)
        {
            accessPoint.ConnectAsync(authRequest, true, onConnectComplete);
        }

        public void Connect(string password, Action<bool> onConnectionComplite)
        {
            var authRequest = new AuthRequest(accessPoint)
            {
                Password = password
            };
            ConnectAsync(authRequest, onConnectionComplite);
        }

        public static void Disconnect()
        {
            new Wifi().Disconnect();
        }
    }
}
