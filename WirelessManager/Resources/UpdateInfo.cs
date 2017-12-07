using System;
using System.Management;
using System.Windows.Forms;

namespace WirelessManager.Resources
{
    class UpdateInfo
    {
        private Timer Timer;

        public UpdateInfo()
        {
            Timer = new Timer
            {
                Interval = (10000)
            };
        }

        public void AddListerenToTimer(EventHandler handler)
        {
            Timer.Tick += handler;
        }

        public void Start()
        {
            Timer.Start();
        }
    }
}
