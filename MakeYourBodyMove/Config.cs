using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeYourBodyMove
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            TxtProcessName.Text = ConfigData.ProcessName;
            TxtMainWindowTitle.Text = ConfigData.MainWindowTitle;
            TrkCheckInterval.Value = ConfigData.CheckInterval;
            TrkStaledTimeout.Value = ConfigData.StaledTimeout;
            TrkInactivityInterval.Value = ConfigData.InactivityTimeout;

            TxtProcessName.TextChanged += (s, arg) => UpdateExplanation();
            TxtMainWindowTitle.TextChanged += (s, arg) => UpdateExplanation();
            TrkCheckInterval.ValueChanged += (s, arg) => UpdateExplanation();
            TrkStaledTimeout.ValueChanged += (s, arg) => UpdateExplanation();
            TrkInactivityInterval.ValueChanged += (s, arg) => UpdateExplanation();

            UpdateExplanation();

            base.OnLoad(e);
        }

        private void UpdateExplanation()
        {
            TxtExplanation.Text =
                $"Check every {TrkCheckInterval.Value} milliseconds if the mouse pointer has been moved.{Environment.NewLine}" +
                $"If the mouse pointer has not been moved for the last {TrkStaledTimeout.Value} minutes, it moves the mouse pointer a little.{Environment.NewLine}";
            if (!string.IsNullOrWhiteSpace(TxtProcessName.Text))
            {
                TxtExplanation.Text += 
                    $"Checks every {TrkInactivityInterval.Value} minutes if a process with the name [{TxtProcessName.Text}]";
                if (!string.IsNullOrWhiteSpace(TxtMainWindowTitle.Text))
                {
                    TxtExplanation.Text += 
                        $" and a main window title that starts with [{TxtMainWindowTitle.Text}]";
                }
                TxtExplanation.Text += 
                    $" exists.{ Environment.NewLine}" +
                    $"If not, it stops checking the mouse pointer position. See yellow dot in tray icon.{Environment.NewLine}" +
                    $"If the process exists, it continues checking the mouse pointer position. See green dot in tray icon.";
            }

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ConfigData.ProcessName = TxtProcessName.Text;
            ConfigData.MainWindowTitle = TxtMainWindowTitle.Text;
            ConfigData.CheckInterval = TrkCheckInterval.Value;
            ConfigData.StaledTimeout = TrkStaledTimeout.Value;
            ConfigData.InactivityTimeout = TrkInactivityInterval.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
