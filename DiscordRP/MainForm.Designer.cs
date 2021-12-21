namespace DiscordRP
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnGetNowTimestamp = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.numEndTimestamp = new System.Windows.Forms.NumericUpDown();
            this.numStartTimestamp = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSmallImageText = new System.Windows.Forms.TextBox();
            this.labelSmallImageText = new System.Windows.Forms.Label();
            this.txtSmallImage = new System.Windows.Forms.TextBox();
            this.labelSmallImage = new System.Windows.Forms.Label();
            this.txtLargeImageText = new System.Windows.Forms.TextBox();
            this.labelLargeImageText = new System.Windows.Forms.Label();
            this.txtLargeImage = new System.Windows.Forms.TextBox();
            this.labelLargeImage = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelTimestamp = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelIdentifier = new System.Windows.Forms.Label();
            this.labelEndTimestamp = new System.Windows.Forms.Label();
            this.labelStartTimestamp = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelClientID = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.niMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDevelopPlatform = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutomaticStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStartMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numEndTimestamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartTimestamp)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(510, 100);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(410, 468);
            this.txtOutput.TabIndex = 30;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOutput.Location = new System.Drawing.Point(500, 70);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 19);
            this.labelOutput.TabIndex = 29;
            this.labelOutput.Text = "輸出";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(130, 105);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(200, 22);
            this.txtClientID.TabIndex = 4;
            // 
            // btnGetNowTimestamp
            // 
            this.btnGetNowTimestamp.Location = new System.Drawing.Point(355, 277);
            this.btnGetNowTimestamp.Name = "btnGetNowTimestamp";
            this.btnGetNowTimestamp.Size = new System.Drawing.Size(110, 23);
            this.btnGetNowTimestamp.TabIndex = 13;
            this.btnGetNowTimestamp.Text = "取得目前時間戳";
            this.btnGetNowTimestamp.UseVisualStyleBackColor = true;
            this.btnGetNowTimestamp.Click += new System.EventHandler(this.btnGetNowTimestamp_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(29, 510);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(436, 23);
            this.btnApply.TabIndex = 25;
            this.btnApply.Text = "套用設定";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Enabled = false;
            this.btnShutdown.Location = new System.Drawing.Point(390, 545);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnShutdown.TabIndex = 28;
            this.btnShutdown.Text = "關閉";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(205, 545);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 27;
            this.btnRestart.Text = "重新啟動";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // numEndTimestamp
            // 
            this.numEndTimestamp.Location = new System.Drawing.Point(130, 308);
            this.numEndTimestamp.Maximum = new decimal(new int[] {
            -769664001,
            58999,
            0,
            0});
            this.numEndTimestamp.Name = "numEndTimestamp";
            this.numEndTimestamp.Size = new System.Drawing.Size(200, 22);
            this.numEndTimestamp.TabIndex = 15;
            // 
            // numStartTimestamp
            // 
            this.numStartTimestamp.Location = new System.Drawing.Point(130, 280);
            this.numStartTimestamp.Maximum = new decimal(new int[] {
            -769664001,
            58999,
            0,
            0});
            this.numStartTimestamp.Name = "numStartTimestamp";
            this.numStartTimestamp.Size = new System.Drawing.Size(200, 22);
            this.numStartTimestamp.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(29, 545);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "啟動";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtSmallImageText
            // 
            this.txtSmallImageText.Location = new System.Drawing.Point(130, 465);
            this.txtSmallImageText.Name = "txtSmallImageText";
            this.txtSmallImageText.Size = new System.Drawing.Size(200, 22);
            this.txtSmallImageText.TabIndex = 24;
            // 
            // labelSmallImageText
            // 
            this.labelSmallImageText.AutoSize = true;
            this.labelSmallImageText.Location = new System.Drawing.Point(35, 468);
            this.labelSmallImageText.Name = "labelSmallImageText";
            this.labelSmallImageText.Size = new System.Drawing.Size(65, 12);
            this.labelSmallImageText.TabIndex = 23;
            this.labelSmallImageText.Text = "小圖示說明";
            // 
            // txtSmallImage
            // 
            this.txtSmallImage.Location = new System.Drawing.Point(130, 437);
            this.txtSmallImage.Name = "txtSmallImage";
            this.txtSmallImage.Size = new System.Drawing.Size(200, 22);
            this.txtSmallImage.TabIndex = 22;
            // 
            // labelSmallImage
            // 
            this.labelSmallImage.AutoSize = true;
            this.labelSmallImage.Location = new System.Drawing.Point(35, 440);
            this.labelSmallImage.Name = "labelSmallImage";
            this.labelSmallImage.Size = new System.Drawing.Size(65, 12);
            this.labelSmallImage.TabIndex = 21;
            this.labelSmallImage.Text = "小圖示名稱";
            // 
            // txtLargeImageText
            // 
            this.txtLargeImageText.Location = new System.Drawing.Point(130, 409);
            this.txtLargeImageText.Name = "txtLargeImageText";
            this.txtLargeImageText.Size = new System.Drawing.Size(200, 22);
            this.txtLargeImageText.TabIndex = 20;
            // 
            // labelLargeImageText
            // 
            this.labelLargeImageText.AutoSize = true;
            this.labelLargeImageText.Location = new System.Drawing.Point(35, 412);
            this.labelLargeImageText.Name = "labelLargeImageText";
            this.labelLargeImageText.Size = new System.Drawing.Size(65, 12);
            this.labelLargeImageText.TabIndex = 19;
            this.labelLargeImageText.Text = "大圖示說明";
            // 
            // txtLargeImage
            // 
            this.txtLargeImage.Location = new System.Drawing.Point(130, 381);
            this.txtLargeImage.Name = "txtLargeImage";
            this.txtLargeImage.Size = new System.Drawing.Size(200, 22);
            this.txtLargeImage.TabIndex = 18;
            // 
            // labelLargeImage
            // 
            this.labelLargeImage.AutoSize = true;
            this.labelLargeImage.Location = new System.Drawing.Point(35, 384);
            this.labelLargeImage.Name = "labelLargeImage";
            this.labelLargeImage.Size = new System.Drawing.Size(65, 12);
            this.labelLargeImage.TabIndex = 17;
            this.labelLargeImage.Text = "大圖示名稱";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelImage.Location = new System.Drawing.Point(25, 346);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(39, 19);
            this.labelImage.TabIndex = 16;
            this.labelImage.Text = "圖示";
            // 
            // labelTimestamp
            // 
            this.labelTimestamp.AutoSize = true;
            this.labelTimestamp.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTimestamp.Location = new System.Drawing.Point(25, 245);
            this.labelTimestamp.Name = "labelTimestamp";
            this.labelTimestamp.Size = new System.Drawing.Size(39, 19);
            this.labelTimestamp.TabIndex = 10;
            this.labelTimestamp.Text = "時間";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMessage.Location = new System.Drawing.Point(25, 145);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(39, 19);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "訊息";
            // 
            // labelIdentifier
            // 
            this.labelIdentifier.AutoSize = true;
            this.labelIdentifier.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelIdentifier.Location = new System.Drawing.Point(25, 70);
            this.labelIdentifier.Name = "labelIdentifier";
            this.labelIdentifier.Size = new System.Drawing.Size(39, 19);
            this.labelIdentifier.TabIndex = 2;
            this.labelIdentifier.Text = "識別";
            // 
            // labelEndTimestamp
            // 
            this.labelEndTimestamp.AutoSize = true;
            this.labelEndTimestamp.Location = new System.Drawing.Point(35, 310);
            this.labelEndTimestamp.Name = "labelEndTimestamp";
            this.labelEndTimestamp.Size = new System.Drawing.Size(77, 12);
            this.labelEndTimestamp.TabIndex = 14;
            this.labelEndTimestamp.Text = "結束時間戳記";
            // 
            // labelStartTimestamp
            // 
            this.labelStartTimestamp.AutoSize = true;
            this.labelStartTimestamp.Location = new System.Drawing.Point(35, 282);
            this.labelStartTimestamp.Name = "labelStartTimestamp";
            this.labelStartTimestamp.Size = new System.Drawing.Size(77, 12);
            this.labelStartTimestamp.TabIndex = 11;
            this.labelStartTimestamp.Text = "開始時間戳記";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(12, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(166, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Discord 自訂遊戲狀態";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(130, 180);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(200, 22);
            this.txtDetail.TabIndex = 7;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(130, 208);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(200, 22);
            this.txtState.TabIndex = 9;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(35, 183);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(53, 12);
            this.labelDetail.TabIndex = 6;
            this.labelDetail.Text = "詳細資訊";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(35, 211);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(29, 12);
            this.labelState.TabIndex = 8;
            this.labelState.Text = "狀態";
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(35, 108);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(56, 12);
            this.labelClientID.TabIndex = 3;
            this.labelClientID.Text = "客戶端 ID";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // niMin
            // 
            this.niMin.BalloonTipTitle = "Discord RP";
            this.niMin.Icon = ((System.Drawing.Icon)(resources.GetObject("niMin.Icon")));
            this.niMin.Text = "Discord RP";
            this.niMin.DoubleClick += new System.EventHandler(this.niMin_DoubleClick);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiOption,
            this.tsmiHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(940, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "主選單";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenCMD,
            this.tsmiShowOutput,
            this.tsmiDevelopPlatform,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(43, 20);
            this.tsmiFile.Text = "檔案";
            // 
            // tsmiOpenCMD
            // 
            this.tsmiOpenCMD.Name = "tsmiOpenCMD";
            this.tsmiOpenCMD.Size = new System.Drawing.Size(134, 22);
            this.tsmiOpenCMD.Text = "開啟主控台";
            this.tsmiOpenCMD.Click += new System.EventHandler(this.tsmiOpenCMD_Click);
            // 
            // tsmiShowOutput
            // 
            this.tsmiShowOutput.Checked = true;
            this.tsmiShowOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowOutput.Name = "tsmiShowOutput";
            this.tsmiShowOutput.Size = new System.Drawing.Size(134, 22);
            this.tsmiShowOutput.Text = "顯示輸出";
            this.tsmiShowOutput.Click += new System.EventHandler(this.tsmiShowOutput_Click);
            // 
            // tsmiDevelopPlatform
            // 
            this.tsmiDevelopPlatform.Name = "tsmiDevelopPlatform";
            this.tsmiDevelopPlatform.Size = new System.Drawing.Size(134, 22);
            this.tsmiDevelopPlatform.Text = "開發者平台";
            this.tsmiDevelopPlatform.Click += new System.EventHandler(this.tsmiDevelopPlatform_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(134, 22);
            this.tsmiExit.Text = "離開";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiOption
            // 
            this.tsmiOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutomaticStart,
            this.tsmiStartMinimum});
            this.tsmiOption.Name = "tsmiOption";
            this.tsmiOption.Size = new System.Drawing.Size(43, 20);
            this.tsmiOption.Text = "選項";
            // 
            // tsmiAutomaticStart
            // 
            this.tsmiAutomaticStart.Name = "tsmiAutomaticStart";
            this.tsmiAutomaticStart.Size = new System.Drawing.Size(158, 22);
            this.tsmiAutomaticStart.Text = "開啟後自動啟動";
            this.tsmiAutomaticStart.Click += new System.EventHandler(this.tsmiAutomaticStart_Click);
            // 
            // tsmiStartMinimum
            // 
            this.tsmiStartMinimum.Name = "tsmiStartMinimum";
            this.tsmiStartMinimum.Size = new System.Drawing.Size(158, 22);
            this.tsmiStartMinimum.Text = "啟動後最小化";
            this.tsmiStartMinimum.Click += new System.EventHandler(this.tsmiStartMinimum_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(43, 20);
            this.tsmiHelp.Text = "說明";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(98, 22);
            this.tsmiAbout.Text = "關於";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 582);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnGetNowTimestamp);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.numEndTimestamp);
            this.Controls.Add(this.numStartTimestamp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSmallImageText);
            this.Controls.Add(this.labelSmallImageText);
            this.Controls.Add(this.txtSmallImage);
            this.Controls.Add(this.labelSmallImage);
            this.Controls.Add(this.txtLargeImageText);
            this.Controls.Add(this.labelLargeImageText);
            this.Controls.Add(this.txtLargeImage);
            this.Controls.Add(this.labelLargeImage);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelTimestamp);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelIdentifier);
            this.Controls.Add(this.labelEndTimestamp);
            this.Controls.Add(this.labelStartTimestamp);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelClientID);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Discord RP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numEndTimestamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartTimestamp)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnGetNowTimestamp;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.NumericUpDown numEndTimestamp;
        private System.Windows.Forms.NumericUpDown numStartTimestamp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSmallImageText;
        private System.Windows.Forms.Label labelSmallImageText;
        private System.Windows.Forms.TextBox txtSmallImage;
        private System.Windows.Forms.Label labelSmallImage;
        private System.Windows.Forms.TextBox txtLargeImageText;
        private System.Windows.Forms.Label labelLargeImageText;
        private System.Windows.Forms.TextBox txtLargeImage;
        private System.Windows.Forms.Label labelLargeImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelTimestamp;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelIdentifier;
        private System.Windows.Forms.Label labelEndTimestamp;
        private System.Windows.Forms.Label labelStartTimestamp;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.NotifyIcon niMin;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenCMD;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowOutput;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDevelopPlatform;
        private System.Windows.Forms.ToolStripMenuItem tsmiOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutomaticStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiStartMinimum;
    }
}

