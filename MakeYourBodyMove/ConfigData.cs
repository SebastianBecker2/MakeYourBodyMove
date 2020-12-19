using MakeYourBodyMove.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeYourBodyMove
{
    public static class ConfigData
    {
        public static string ProcessName
        {
            get => Settings.Default.ProcessName;
            set
            {
                Settings.Default.ProcessName = value;
                Settings.Default.Save();
            }
        }

        public static string MainWindowTitle
        {
            get => Settings.Default.MainWindowTitle; set
            {
                Settings.Default.MainWindowTitle = value;
                Settings.Default.Save();
            }
        }

        public static int CheckInterval
        {
            get => Settings.Default.CheckInterval;
            set
            {
                Settings.Default.CheckInterval = value;
                Settings.Default.Save();
            }
        }

        public static int StaledTimeout
        {
            get => Settings.Default.StaledTimeout;
            set
            {
                Settings.Default.StaledTimeout = value;
                Settings.Default.Save();
            }
        }

        public static int InactivityTimeout
        {
            get => Settings.Default.InactivityTimeout;
            set
            {
                Settings.Default.InactivityTimeout = value;
                Settings.Default.Save();
            }
        }
    }
}
