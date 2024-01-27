using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleBossTimer
{
    struct BossConfig
    {
        public string BossName;
        public int RespawnMinutes;

        public List<Timer> Timers;
        public List<Label> TimerLabels;
        public List<int> Timelefts;

        public void StartTimer(int chid)
        {
            if (!Timers[chid].Enabled)
            {
                Timers[chid].Start();
            }

            Timelefts[chid] = RespawnMinutes * 60;
        }

        public void TickTimer(int chid)
        {
            Timelefts[chid] -= 1;

            int minutes = Math.Abs(Timelefts[chid]) / 60;
            int seconds = Math.Abs(Timelefts[chid]) % 60;

            if (Timelefts[chid] > 0)
            {
                TimerLabels[chid].Text = $"{minutes:D}:{seconds:D2}";
            }
            else
            {
                TimerLabels[chid].Text = $"-{minutes:D}:{seconds:D2}";
            }
        }
    }

    public partial class MainForm : Form
    {
        List<BossConfig> configs = new List<BossConfig>();
        bool removeInfoTab = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateBossConfig_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtboxBossRespawnMinutes.Text, out int minutes) || minutes > 1440) return;
            if (!removeInfoTab)
            {
                tabControl.TabPages.RemoveAt(0);
                removeInfoTab = true;
            }

            GenerateNewBossConfig(txtboxBossName.Text, minutes);
        }

        private void GenerateNewBossConfig(string name, int minutes)
        {
            var config = new BossConfig
            {
                BossName = name,
                RespawnMinutes = minutes,
                Timers = new List<Timer>(20),
                TimerLabels = new List<Label>(20),
                Timelefts = new List<int>(20)
            };

            configs.Add(config);
            tabControl.TabPages.Add(GenerateNewTabPage(config));
            tabControl.SelectedIndex = configs.Count - 1;
        }

        private TabPage GenerateNewTabPage(BossConfig config)
        {
            var newBossPage = new TabPage(config.BossName);

            for (int chid = 0; chid < 20; chid++)
            {
                Button button = new Button
                {
                    Text = $"CH. {chid + 1}",
                    Size = new Size(75, 30),
                    Location = new Point(10 + (chid % 6) * 85, 10 + (chid / 6) * 60),
                    Tag = chid
                };

                Label label = new Label
                {
                    Text = "--",
                    Size = new Size(75, 10),
                    Location = new Point(15 + (chid % 6) * 85, 45 + (chid / 6) * 60)
                };

                Timer timer = new Timer
                {
                    Enabled = false,
                    Interval = 1000,
                    Tag = chid
                };

                button.Click += (sender, e) =>
                {
                    config.StartTimer((int)((Button)sender).Tag);
                };

                timer.Tick += (sender, e) =>
                {
                    config.TickTimer((int)((Timer)sender).Tag);
                }; ;

                config.Timers.Add(timer);
                config.TimerLabels.Add(label);
                config.Timelefts.Add(0);

                // Add button and label to the tabPage
                newBossPage.Controls.Add(button);
                newBossPage.Controls.Add(label);
            }

            return newBossPage;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
