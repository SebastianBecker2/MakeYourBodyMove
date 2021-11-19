using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MakeYourBodyMove
{
    internal class ProcessIcon : IDisposable
    {
        private string ProcessName { get => ConfigData.ProcessName; }
        private string MainWindowTitle { get => ConfigData.MainWindowTitle; }
        private int CheckInterval { get => ConfigData.CheckInterval; }
        private int StaledTimeout { get => ConfigData.StaledTimeout * 60 * 1000; }
        private int InactivityTimeout { get => ConfigData.InactivityTimeout * 60 * 1000; }


        protected NotifyIcon NotifyIcon { get; set; }
        private HandyTimer.Timer RefreshTimer { get; set; }

        private Win32.POINT PreviousCursorPostion;
        private DateTime PreviousDateTime;

        private ActivationState CurrentState = ActivationState.Deactivated;
        public ActivationState Running
        {
            get { return CurrentState; }
            set
            {
                if (value == ActivationState.Activated)
                {
                    NotifyIcon.Icon = Properties.Resources.activated;
                    RefreshTimer.StartSingle(0);
                    CurrentState = ActivationState.Activated;
                }
                else if (value == ActivationState.Inactivated)
                {
                    NotifyIcon.Icon = Properties.Resources.inactivated;
                    RefreshTimer.StartSingle(0);
                }
                else
                {
                    NotifyIcon.Icon = Properties.Resources.deactivated;
                    RefreshTimer.Stop();
                    CurrentState = ActivationState.Deactivated;
                }
            }
        }

        public ProcessIcon()
        {
            NotifyIcon = new NotifyIcon();
            NotifyIcon.Visible = true;
            NotifyIcon.Icon = Properties.Resources.activated;
            NotifyIcon.ContextMenuStrip = new ContextMenu(this);
            NotifyIcon.DoubleClick += NotifyIcon_DoubleClick;

            RefreshTimer = new HandyTimer.Timer(RefreshStatus);
            CurrentState = ActivationState.Activated;
            RefreshTimer.StartSingle(0);
        }

        private bool HasProcessWithTitle(string process_name, string window_title)
        {
            if (string.IsNullOrWhiteSpace(process_name))
            {
                return true;
            }
            var processes = Process.GetProcessesByName(process_name);
            return processes.Any(p => p.MainWindowTitle.StartsWith(window_title));
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            using (var dlg = new Config())
            {
                dlg.ShowDialog();
            }
        }

        protected void RefreshStatus(object state)
        {
            if (CurrentState == ActivationState.Deactivated)
            {
                NotifyIcon.Icon = Properties.Resources.deactivated;
                return;
            }

            if (CurrentState == ActivationState.Activated)
            {
                try
                {
                    // Just to be safe. But probably not necessary nor performant
                    NotifyIcon.Icon = Properties.Resources.activated;

                    if (PreviousDateTime.AddMilliseconds(InactivityTimeout) < DateTime.Now)
                    {
                        if (!HasProcessWithTitle(ProcessName, MainWindowTitle))
                        {
                            CurrentState = ActivationState.Inactivated;
                            return;
                        }
                    }

                    Win32.POINT p;
                    Win32.GetCursorPos(out p);
                    //Debug.Print("CursorPos: " + p.x.ToString() + ":" + p.y.ToString());
                    if (PreviousCursorPostion != p)
                    {
                        PreviousCursorPostion = p;
                        PreviousDateTime = DateTime.Now;
                        return;
                    }

                    if (PreviousDateTime.AddMilliseconds(StaledTimeout) < DateTime.Now)
                    {
                        Win32.SetCursorPos(p.x + 50, p.y + 50);
                        Thread.Sleep(50);
                        Win32.SetCursorPos(p.x - 50, p.y - 50);
                        Thread.Sleep(50);
                        Win32.SetCursorPos(p.x, p.y);
                        PreviousDateTime = DateTime.Now;
                        //Debug.Print("Moving body");
                    }
                }
                finally
                {
                    RefreshTimer.StartSingle(CheckInterval);
                }
                return;
            }

            if (CurrentState == ActivationState.Inactivated)
            {
                // Just to be safe. But probably not necessary nor performant
                NotifyIcon.Icon = Properties.Resources.inactivated;

                if (HasProcessWithTitle(ProcessName, MainWindowTitle))
                {
                    CurrentState = ActivationState.Activated;
                    RefreshStatus(null);
                    return;
                }
                RefreshTimer.StartSingle(InactivityTimeout);
            }
        }

        #region Implementing IDisposable

        // Flag: Has Dispose already been called?
        private bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                NotifyIcon.Dispose();
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        #endregion
    }
}