using DiscordRPC;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscordRP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updateSettingUI();
            updateOptionUI();
            txtClientID.SelectionStart = txtClientID.Text.Length; // Remove Highlight
        }

        private void btnGetNowTimestamp_Click(object sender, EventArgs e)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan span = DateTime.UtcNow - origin;

            long now = (long)span.TotalMilliseconds;
            Clipboard.SetText(now.ToString());
            MessageBox.Show("目前時間戳 : " + now + " 已複製到剪貼簿", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // discord_rpc.h 官方 SDK 提到的限制
            if (string.IsNullOrEmpty(txtClientID.Text))
            {
                MessageBox.Show("請輸入客戶端 ID", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Encoding.UTF8.GetBytes(txtDetail.Text).Length > 128)
            {
                MessageBox.Show("詳細資訊過長 (128 字元)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Encoding.UTF8.GetBytes(txtState.Text).Length > 128)
            {
                MessageBox.Show("狀態參數過長 (128 字元)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Encoding.UTF8.GetBytes(txtLargeImage.Text).Length > 32)
            {
                MessageBox.Show("大圖示名稱過長 (32 字元)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Encoding.UTF8.GetBytes(txtLargeImageText.Text).Length > 128)
            {
                MessageBox.Show("大圖示文字過長 (128 字元)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Encoding.UTF8.GetBytes(txtSmallImage.Text).Length > 32)
            {
                MessageBox.Show("小圖示名稱過長 (32 字元)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Encoding.UTF8.GetBytes(txtSmallImageText.Text).Length > 128)
            {
                MessageBox.Show("小圖示文字過長 (128 字元)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numEndTimestamp.Value != 0 && numStartTimestamp.Value > numEndTimestamp.Value)
            {
                MessageBox.Show("開始時間戳記不得大於結束時間戳記", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RichPresence config = Program.client.config.config;

            Program.client.config.clientId = txtClientID.Text;
            config.Details = txtDetail.Text;
            config.State = txtState.Text;

            config.Timestamps.Start = DateHelper.getDateTimeFromMilliSecond(Convert.ToInt64(numStartTimestamp.Value));
            config.Timestamps.End = DateHelper.getDateTimeFromMilliSecond(Convert.ToInt64(numEndTimestamp.Value));

            config.Assets.LargeImageKey = txtLargeImage.Text;
            config.Assets.LargeImageText = txtLargeImageText.Text;

            config.Assets.SmallImageKey = txtSmallImage.Text;
            config.Assets.SmallImageText = txtSmallImageText.Text;

            Program.client.config.saveConfig();
            appendOutput("[資訊] 設定檔案已儲存");

            Program.client.updateRP();
            updateSettingUI();
        }

        private void start()
        {
            Program.client.start();
            if (Program.client.config.option.startMinimum)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Program.client.restart();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Program.client.disconnect(0);
        }

        public void appendOutput(string message)
        {
            Invoke((MethodInvoker)delegate ()
            {
                txtOutput.AppendText(message + "\r\n");
            });
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            Program.client.invoke();
        }

        private static void forceUpdateNumericUpDownValue(NumericUpDown control, decimal value)
        {
            decimal pre = value + 1;
            if (pre > control.Maximum)
            {
                pre = value - 1;
            }
            control.Value = pre;
            control.Value = value;
        }

        private void updateSettingUI()
        {
            RichPresence config = Program.client.config.config;

            txtClientID.Text = Program.client.config.clientId;
            txtDetail.Text = config.Details;
            txtState.Text = config.State;

            forceUpdateNumericUpDownValue(numStartTimestamp, DateHelper.getMilliSecondFromDateTime(config.Timestamps.Start.Value));
            forceUpdateNumericUpDownValue(numEndTimestamp, DateHelper.getMilliSecondFromDateTime(config.Timestamps.End.Value));

            txtLargeImage.Text = config.Assets.LargeImageKey;
            txtLargeImageText.Text = config.Assets.LargeImageText;

            txtSmallImage.Text = config.Assets.SmallImageKey;
            txtSmallImageText.Text = config.Assets.SmallImageText;
        }

        private void updateOptionUI()
        {
            Option option = Program.client.config.option;

            tsmiAutomaticStart.Checked = option.automaticStart;
            tsmiStartMinimum.Checked = option.startMinimum;
        }

        public void toggleUIState(bool launch)
        {
            btnStart.Enabled = !launch;
            btnRestart.Enabled = launch;
            btnShutdown.Enabled = launch;
            updateSettingUI();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.client.disconnect(0);
        }

        private void tsmiOpenCMD_Click(object sender, EventArgs e)
        {
            Program.console.toggleConsole();
            tsmiOpenCMD.Checked = Program.console.allocate;
        }

        private void tsmiShowOutput_Click(object sender, EventArgs e)
        {
            Size = tsmiShowOutput.Checked ? new Size(510, 625) : new Size(960, 625);
            tsmiShowOutput.Checked = !tsmiShowOutput.Checked;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Program.about.Show();
        }

        private void niMin_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            niMin.Visible = false;
        }

        private void tsmiDevelopPlatform_Click(object sender, EventArgs e)
        {
            Process.Start("https://discordapp.com/developers/applications");
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                niMin.Visible = true;

                niMin.BalloonTipIcon = ToolTipIcon.Info;
                niMin.BalloonTipText = "Discord RP 仍在執行中";
                niMin.ShowBalloonTip(3000);
            }
        }

        private void saveOption()
        {
            Program.client.config.saveOption();
            updateOptionUI();
        }

        private void tsmiAutomaticStart_Click(object sender, EventArgs e)
        {
            Program.client.config.option.automaticStart = !Program.client.config.option.automaticStart;
            saveOption();
        }

        private void tsmiStartMinimum_Click(object sender, EventArgs e)
        {
            Program.client.config.option.startMinimum = !Program.client.config.option.startMinimum;
            saveOption();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.client.config.option.automaticStart)
            {
                start();
            }
        }
    }
}