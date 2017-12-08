using System;
using SimpleWifi;
using SimpleWifi.Win32.Interop;

namespace WirelessManager.Bean
{
    class NetworkConnection
    {
        private AccessPoint accessPoint;
        private string macAddress;
        private string authenticationType;

        public NetworkConnection() { }

        public NetworkConnection(AccessPoint accessPoint, string macAddress)
        {
            this.accessPoint = accessPoint;
            this.macAddress = macAddress;
        }

        public NetworkConnection(AccessPoint accessPoint, string macAddress, string authenticationType)
        {
            this.accessPoint = accessPoint;
            this.macAddress = macAddress;
            this.authenticationType = authenticationType;
        }

        public string MacAddress
        {
            get { return macAddress; }
            set { this.macAddress = value; }
        }

        public string AuthenticationType
        {
            get { return authenticationType; }
            set { this.authenticationType = value; }
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
