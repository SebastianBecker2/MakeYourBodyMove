namespace MakeYourBodyMove
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProcessName = new System.Windows.Forms.TextBox();
            this.TxtMainWindowTitle = new System.Windows.Forms.TextBox();
            this.TrkCheckInterval = new System.Windows.Forms.TrackBar();
            this.TrkStaledTimeout = new System.Windows.Forms.TrackBar();
            this.TrkInactivityInterval = new System.Windows.Forms.TrackBar();
            this.TxtExplanation = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrkCheckInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkStaledTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkInactivityInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Window Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mouse Position Check Interval (milliseconds):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mouse Pointer Staled Timeout (minutes):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Inactivity Check Interval (minutes):";
            // 
            // TxtProcessName
            // 
            this.TxtProcessName.Location = new System.Drawing.Point(12, 25);
            this.TxtProcessName.Name = "TxtProcessName";
            this.TxtProcessName.Size = new System.Drawing.Size(248, 20);
            this.TxtProcessName.TabIndex = 5;
            // 
            // TxtMainWindowTitle
            // 
            this.TxtMainWindowTitle.Location = new System.Drawing.Point(12, 64);
            this.TxtMainWindowTitle.Name = "TxtMainWindowTitle";
            this.TxtMainWindowTitle.Size = new System.Drawing.Size(248, 20);
            this.TxtMainWindowTitle.TabIndex = 6;
            // 
            // TrkCheckInterval
            // 
            this.TrkCheckInterval.LargeChange = 50;
            this.TrkCheckInterval.Location = new System.Drawing.Point(12, 103);
            this.TrkCheckInterval.Maximum = 1000;
            this.TrkCheckInterval.Minimum = 1;
            this.TrkCheckInterval.Name = "TrkCheckInterval";
            this.TrkCheckInterval.Size = new System.Drawing.Size(248, 45);
            this.TrkCheckInterval.SmallChange = 10;
            this.TrkCheckInterval.TabIndex = 7;
            this.TrkCheckInterval.Value = 1;
            // 
            // TrkStaledTimeout
            // 
            this.TrkStaledTimeout.LargeChange = 2;
            this.TrkStaledTimeout.Location = new System.Drawing.Point(12, 167);
            this.TrkStaledTimeout.Minimum = 1;
            this.TrkStaledTimeout.Name = "TrkStaledTimeout";
            this.TrkStaledTimeout.Size = new System.Drawing.Size(248, 45);
            this.TrkStaledTimeout.TabIndex = 8;
            this.TrkStaledTimeout.Value = 1;
            // 
            // TrkInactivityInterval
            // 
            this.TrkInactivityInterval.LargeChange = 2;
            this.TrkInactivityInterval.Location = new System.Drawing.Point(12, 231);
            this.TrkInactivityInterval.Minimum = 1;
            this.TrkInactivityInterval.Name = "TrkInactivityInterval";
            this.TrkInactivityInterval.Size = new System.Drawing.Size(248, 45);
            this.TrkInactivityInterval.TabIndex = 9;
            this.TrkInactivityInterval.Value = 1;
            // 
            // TxtExplanation
            // 
            this.TxtExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtExplanation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtExplanation.Location = new System.Drawing.Point(267, 12);
            this.TxtExplanation.Multiline = true;
            this.TxtExplanation.Name = "TxtExplanation";
            this.TxtExplanation.ReadOnly = true;
            this.TxtExplanation.Size = new System.Drawing.Size(308, 259);
            this.TxtExplanation.TabIndex = 10;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(419, 277);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 11;
            this.BtnOk.Text = "Okay";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(500, 277);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(587, 312);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtExplanation);
            this.Controls.Add(this.TrkInactivityInterval);
            this.Controls.Add(this.TrkStaledTimeout);
            this.Controls.Add(this.TrkCheckInterval);
            this.Controls.Add(this.TxtMainWindowTitle);
            this.Controls.Add(this.TxtProcessName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Config";
            ((System.ComponentModel.ISupportInitialize)(this.TrkCheckInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkStaledTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkInactivityInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProcessName;
        private System.Windows.Forms.TextBox TxtMainWindowTitle;
        private System.Windows.Forms.TrackBar TrkCheckInterval;
        private System.Windows.Forms.TrackBar TrkStaledTimeout;
        private System.Windows.Forms.TrackBar TrkInactivityInterval;
        private System.Windows.Forms.TextBox TxtExplanation;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
    }
}