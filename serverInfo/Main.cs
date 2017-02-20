using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace serverInfo
{
    public partial class Main : Form
    {
        public List<Member> loginStats = null;
        private Boolean serverOnline = false;

        public Main()
        {
            InitializeComponent();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            String jsonText = "";
            try
            {
                jsonText = new System.Net.WebClient().DownloadString("http://burpcraft.com:8080/api/players/list");
                if (jsonText == "") return;

                Member[] online = JsonConvert.DeserializeObject<Member[]>(jsonText);

                var sorted = from Member member in online
                             orderby !member.IsOnline, member.Name
                             select member;

                loginStats = sorted.ToList<Member>();

                String curentMember = "";
                if (serverMembers.Items.Count != 0 && serverMembers.SelectedItem != null)
                    curentMember = serverMembers.SelectedItem.ToString();

                serverMembers.Items.Clear();
                foreach (Member member in loginStats)
                    serverMembers.Items.Add(member.Name);

                if (curentMember != "")
                {
                    serverMembers.SelectedIndex = serverMembers.Items.IndexOf(curentMember);
                }
                else
                {
                    serverMembers.SelectedIndex = 0;
                }

                var onlineMembers = from Member m in online where m.IsOnline select m;
                string names = "";

                foreach (Member m in onlineMembers)
                {
                    names += m.Name + "\n";
                }

                int i = onlineMembers != null ? onlineMembers.Count() : 0;
                loggedIn.Text = String.Format("Logged on: {0}", i);
                lineChart.AppendData((sbyte)i, names.TrimEnd('\n'));
                lineChart.Refresh();
                serverOnline = true;
            }
            catch (Exception)  
            {
                serverOnline = false;
            }
            OnlineStatus.ForeColor = serverOnline ? Color.DarkOliveGreen : Color.OrangeRed;
            OnlineStatus.Text = serverOnline ? "Online" : "Offline";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshTimer.Start();
            refreshTimer_Tick(null, null);
        }

        private void onlineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Member m = loginStats[serverMembers.SelectedIndex];

            if (m != null)
            {
                online.Text = m.IsOnline ? "Online" : "Offline";
                if (m.OnlineTime.IndexOf(".") == -1)
                {
                    timeOnline.Text = "Time Online: " + m.OnlineTime;
                }
                else
                {
                    timeOnline.Text = "Time Online: " + m.OnlineTime.Substring(1, m.OnlineTime.IndexOf(".") - 1);
                }
                int hours = (int)Math.Floor(m.TotalHoursOnServer);
                int minutes = (int)Math.Floor((m.TotalHoursOnServer - hours) * 60);
                int seconds = (int)Math.Floor((m.TotalHoursOnServer - hours - (double)minutes / 60) * 3600);
                totalTimeOnline.Text = String.Format("Total Time: {0}:{1,2:00}:{2,2:00}", hours, minutes, seconds);
                lastSeen.Text = "Last Seen: " + (m.LastSeen == "" ? "Never" : m.LastSeen);
                logins.Text = "Login Count: " + m.LoginCount.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshTimer_Tick(null, null);
        }

        private void onlineList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            if (e.Index < (sender as ListBox).Items.Count)
            {
                g.DrawString((sender as ListBox).Items[e.Index].ToString(), e.Font, new SolidBrush(loginStats[e.Index].IsOnline ? Color.DarkOliveGreen : this.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y - 2));
            }

            e.DrawFocusRectangle();
        }
    }
}
