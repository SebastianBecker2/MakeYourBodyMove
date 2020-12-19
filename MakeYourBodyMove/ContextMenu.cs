using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MakeYourBodyMove
{
    internal class ContextMenu : ContextMenuStrip
    {
        private ToolStripMenuItem Start { get; set; }
        private ToolStripMenuItem Stop { get; set; }
        private ToolStripMenuItem Config { get; set; }
        private ToolStripMenuItem Exit { get; set; }
        private ProcessIcon App { get; set; }

        public ContextMenu(ProcessIcon app)
            : base()
        {
            App = app;

            Start = new ToolStripMenuItem();
            Start.Text = "Start";
            Start.Click += Start_Clicked;
            Items.Add(Start);

            Stop = new ToolStripMenuItem();
            Stop.Text = "Stop";
            Stop.Click += Stop_Click;
            Items.Add(Stop);

            Items.Add(new ToolStripSeparator());

            Config = new ToolStripMenuItem();
            Config.Text = "Config";
            Config.Click += Config_Click;
            Items.Add(Config);

            Items.Add(new ToolStripSeparator());

            Exit = new ToolStripMenuItem();
            Exit.Text = "Close";
            Exit.Click += Exit_Click;
            Items.Add(Exit);
        }

        protected void Start_Clicked(object sender, EventArgs e)
        {
            App.Running = ActivationState.Activated;
        }

        protected void Stop_Click(object sender, EventArgs e)
        {
            App.Running = ActivationState.Deactivated;
        }

        protected void Config_Click(object sender, EventArgs e)
        {
            using (var dlg = new Config())
            {
                dlg.ShowDialog();
            }
        }

        protected void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}