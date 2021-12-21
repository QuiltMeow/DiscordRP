namespace DiscordRP
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.labelTitle = new System.Windows.Forms.Label();
            this.wbMedia = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.ForeColor = System.Drawing.Color.Purple;
            this.labelTitle.Location = new System.Drawing.Point(25, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(169, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Discord RP\r\nAuthor : 棉被 / 小棉被";
            // 
            // wbMedia
            // 
            this.wbMedia.IsWebBrowserContextMenuEnabled = false;
            this.wbMedia.Location = new System.Drawing.Point(-9, -12);
            this.wbMedia.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMedia.Name = "wbMedia";
            this.wbMedia.ScrollBarsEnabled = false;
            this.wbMedia.Size = new System.Drawing.Size(650, 375);
            this.wbMedia.TabIndex = 1;
            this.wbMedia.Url = new System.Uri("", System.UriKind.Relative);
            this.wbMedia.Visible = false;
            this.wbMedia.WebBrowserShortcutsEnabled = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiscordRP.Properties.Resources.BeastTamer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 361);
            this.Controls.Add(this.wbMedia);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "關於";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.About_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.WebBrowser wbMedia;
    }
}