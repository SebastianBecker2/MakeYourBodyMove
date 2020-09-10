using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MakeYourBodyMove
{
    internal class ProcessIcon : IDisposable
    {
        private readonly static int RefreshTimerInterval = 100;
        private readonly static int InactiveTimeout = 180000;

        protected NotifyIcon NotifyIcon { get; set; }
        private HandyTimer.Timer RefreshTimer { get; set; }

        protected CultureInfo ControlCulture;

        private Win32.POINT PreviousCursorPostion;
        private DateTime PreviousDateTime;

        private bool running = false;
        public bool Running
        {
            get { return running; }
            set
            {
                if (value)
                {
                    NotifyIcon.Icon = Properties.Resources.activated;
                    RefreshTimer.StartSingle(0);
                }
                else
                {
                    NotifyIcon.Icon = Properties.Resources.deactivated;
                    RefreshTimer.Stop();
                }
                running = value;
            }
        }

        public ProcessIcon()
        {
            ControlCulture = Thread.CurrentThread.CurrentUICulture;

            NotifyIcon = new NotifyIcon();
            NotifyIcon.Visible = true;
            NotifyIcon.Icon = Properties.Resources.activated;
            NotifyIcon.ContextMenuStrip = new ContextMenu(this);
            //NotifyIcon.DoubleClick += NotifyIcon_DoubleClick;

            RefreshTimer = new HandyTimer.Timer(RefreshStatus);
            Running = true;
            RefreshTimer.StartSingle(0);
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            //using (var dlg = new Configuration())
            //{
            //    dlg.ShowDialog();
            //}
        }

        protected void RefreshStatus(object state)
        {
            if (!Running)
            {
                NotifyIcon.Icon = Properties.Resources.deactivated;
                return;
            }

            try
            {
                // Just to be safe. But probably not necessary nor performant
                NotifyIcon.Icon = Properties.Resources.activated;

                Win32.POINT p;
                Win32.GetCursorPos(out p);

                Debug.Print("CursorPos: " + p.x.ToString() + ":" + p.y.ToString());

                if (PreviousCursorPostion != p)
                {
                    PreviousCursorPostion = p;
                    PreviousDateTime = DateTime.Now;
                    return;
                }

                if (PreviousDateTime.AddMilliseconds(InactiveTimeout) < DateTime.Now)
                {
                    Win32.SetCursorPos(p.x + 50, p.y + 50);
                    Thread.Sleep(50);
                    Win32.SetCursorPos(p.x - 50, p.y - 50);
                    Thread.Sleep(50);
                    Win32.SetCursorPos(p.x, p.y);
                    PreviousDateTime = DateTime.Now;
                    Debug.Print("Moving body");
                }
            }
            finally
            {
                RefreshTimer.StartSingle(RefreshTimerInterval);
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