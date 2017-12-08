using System;
using System.Collections.Generic;
using System.Diagnostics;
using SimpleWifi;
using WirelessManager.Bean;

namespace WirelessManager.Resources
{
    class NetworkManager
    {
        static public List<NetworkConnection> GetNetworkConnectionList()
        {
            List<NetworkConnection> answer = new List<NetworkConnection>();

            string[] bssids = GetBssids();

            try
            {
                Wifi wifi = new Wifi();

                foreach (var accessPoint in wifi.GetAccessPoints())
                {
                    answer.Add(new NetworkConnection(accessPoint, GetMacAddress(bssids, accessPoint), GetAuthType(bssids, accessPoint)));
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                answer = null;
            }

            return answer;
        }

        static private string[] GetBssids()
        {
            string[] bssids;

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    FileName = "cmd",
                    Arguments = @"/C ""netsh wlan show networks mode=bssid""",
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                }
            };
            process.Start();
            bssids = process.StandardOutput.ReadToEnd().Replace(" ", "").Replace("\r", "").Split('\n');
            process.WaitForExit();

            return bssids;
        }

        static private string GetMacAddress(string[] bssids, AccessPoint accessPoint)
        {
            for (int i = 0; i < bssids.Length; i++)
            {
                if ((bssids[i].Split(':')[0].Contains("SSID") && accessPoint.Name.Equals(bssids[i].Split(':')[1])))
                {
                    return bssids[i + 4].Remove(0, bssids[i + 4].IndexOf(":") + 1);
                }
            }
            return null;
        }

        static private string GetAuthType(string[] bssids, AccessPoint accessPoint)
        {
            for (int i = 0; i < bssids.Length; i++)
            {
                if ((bssids[i].Split(':')[0].Contains("SSID") && accessPoint.Name.Equals(bssids[i].Split(':')[1])))
                {
                    string str = bssids[i + 2].Remove(0, bssids[i + 2].IndexOf(":") + 1);
                    return bssids[i + 2].Remove(0, bssids[i + 2].IndexOf(":") + 1);
                }
            }
            return null;
        }

        static public bool Equals(List<NetworkConnection> a, List<NetworkConnection> b)
        {
            if (a == null || b == null || a.Count != b.Count)
                return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (!a[i].Equals(b[i]))
                    return false;
            }
            return true;
        }
    }
}
