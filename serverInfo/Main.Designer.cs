namespace serverInfo
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.serverMembers = new System.Windows.Forms.ListBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.online = new System.Windows.Forms.Label();
            this.logins = new System.Windows.Forms.Label();
            this.lastSeen = new System.Windows.Forms.Label();
            this.totalTimeOnline = new System.Windows.Forms.Label();
            this.timeOnline = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loggedIn = new System.Windows.Forms.Label();
            this.OnlineStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.serverName = new System.Windows.Forms.Label();
            this.lineChart = new serverInfo.LineChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverMembers
            // 
            this.serverMembers.BackColor = System.Drawing.Color.Black;
            this.serverMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverMembers.ForeColor = System.Drawing.Color.Gray;
            this.serverMembers.FormattingEnabled = true;
            this.serverMembers.ItemHeight = 17;
            this.serverMembers.Location = new System.Drawing.Point(7, 213);
            this.serverMembers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serverMembers.Name = "serverMembers";
            this.serverMembers.Size = new System.Drawing.Size(199, 121);
            this.serverMembers.TabIndex = 1;
            this.serverMembers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.onlineList_DrawItem);
            this.serverMembers.SelectedIndexChanged += new System.EventHandler(this.onlineList_SelectedIndexChanged);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 300000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(7, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.online);
            this.panel1.Controls.Add(this.logins);
            this.panel1.Controls.Add(this.lastSeen);
            this.panel1.Controls.Add(this.totalTimeOnline);
            this.panel1.Controls.Add(this.timeOnline);
            this.panel1.Location = new System.Drawing.Point(213, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 121);
            this.panel1.TabIndex = 13;
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.online.Location = new System.Drawing.Point(4, 4);
            this.online.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(61, 21);
            this.online.TabIndex = 17;
            this.online.Text = "Online:";
            // 
            // logins
            // 
            this.logins.AutoSize = true;
            this.logins.Location = new System.Drawing.Point(4, 97);
            this.logins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logins.Name = "logins";
            this.logins.Size = new System.Drawing.Size(49, 17);
            this.logins.TabIndex = 16;
            this.logins.Text = "Logins:";
            // 
            // lastSeen
            // 
            this.lastSeen.AutoSize = true;
            this.lastSeen.Location = new System.Drawing.Point(4, 75);
            this.lastSeen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastSeen.Name = "lastSeen";
            this.lastSeen.Size = new System.Drawing.Size(65, 17);
            this.lastSeen.TabIndex = 15;
            this.lastSeen.Text = "Last seen:";
            // 
            // totalTimeOnline
            // 
            this.totalTimeOnline.AutoSize = true;
            this.totalTimeOnline.Location = new System.Drawing.Point(4, 52);
            this.totalTimeOnline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTimeOnline.Name = "totalTimeOnline";
            this.totalTimeOnline.Size = new System.Drawing.Size(69, 17);
            this.totalTimeOnline.TabIndex = 14;
            this.totalTimeOnline.Text = "Total time:";
            // 
            // timeOnline
            // 
            this.timeOnline.AutoSize = true;
            this.timeOnline.Location = new System.Drawing.Point(4, 30);
            this.timeOnline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeOnline.Name = "timeOnline";
            this.timeOnline.Size = new System.Drawing.Size(78, 17);
            this.timeOnline.TabIndex = 13;
            this.timeOnline.Text = "Time online:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.loggedIn);
            this.panel2.Controls.Add(this.OnlineStatus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 35);
            this.panel2.TabIndex = 14;
            // 
            // loggedIn
            // 
            this.loggedIn.AutoSize = true;
            this.loggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedIn.Location = new System.Drawing.Point(172, 3);
            this.loggedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedIn.Name = "loggedIn";
            this.loggedIn.Size = new System.Drawing.Size(130, 25);
            this.loggedIn.TabIndex = 8;
            this.loggedIn.Text = "Logged on:";
            // 
            // OnlineStatus
            // 
            this.OnlineStatus.AutoSize = true;
            this.OnlineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OnlineStatus.Location = new System.Drawing.Point(84, 3);
            this.OnlineStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OnlineStatus.Name = "OnlineStatus";
            this.OnlineStatus.Size = new System.Drawing.Size(80, 25);
            this.OnlineStatus.TabIndex = 6;
            this.OnlineStatus.Text = "Online";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.serverName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 57);
            this.panel3.TabIndex = 15;
            // 
            // serverName
            // 
            this.serverName.AutoSize = true;
            this.serverName.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverName.Location = new System.Drawing.Point(3, 0);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(346, 47);
            this.serverName.TabIndex = 0;
            this.serverName.Text = "burpcraft.com:25566";
            // 
            // lineChart
            // 
            this.lineChart.BackColor = System.Drawing.Color.Black;
            this.lineChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineChart.Location = new System.Drawing.Point(7, 64);
            this.lineChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(480, 143);
            this.lineChart.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(495, 409);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.serverMembers);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Server status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox serverMembers;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button button1;
        private LineChart lineChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label online;
        private System.Windows.Forms.Label logins;
        private System.Windows.Forms.Label lastSeen;
        private System.Windows.Forms.Label totalTimeOnline;
        private System.Windows.Forms.Label timeOnline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loggedIn;
        private System.Windows.Forms.Label OnlineStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label serverName;
    }
}

