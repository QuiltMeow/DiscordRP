using DiscordRPC;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DiscordRP
{
    public class RPConfig
    {
        public const string CONFIG_FILE_NAME = "config.ini";

        private readonly INIFile configFile;

        public string clientId
        {
            get;
            set;
        }

        public RichPresence config
        {
            get;
            private set;
        }

        public Option option
        {
            get;
            private set;
        }

        public RPConfig()
        {
            configFile = new INIFile(CONFIG_FILE_NAME);

            config = createEmptyRP();
            option = new Option();

            loadConfig();
            loadOption();
        }

        public void loadConfig()
        {
            // 小棉被別那麼皮好嘛 ...
            if (configFile.isDirectory())
            {
                Directory.Delete(configFile.fileName, true);
            }

            if (!configFile.exist())
            {
                // MessageBox.Show("找不到設定檔案 載入預設設定值");
                applyDefault();
                return;
            }

            try
            {
                clientId = configFile.read("Identifier", "ClientId");

                config.Details = configFile.read("Status", "Detail");
                config.State = configFile.read("Status", "State");
                config.Timestamps.Start = DateHelper.getDateTimeFromMilliSecond(long.Parse(configFile.read("Status", "StartTimestamp")));
                config.Timestamps.End = DateHelper.getDateTimeFromMilliSecond(long.Parse(configFile.read("Status", "EndTimestamp")));

                config.Assets.LargeImageKey = configFile.read("Image", "LargeImageKey");
                config.Assets.LargeImageText = configFile.read("Image", "LargeImageText");

                config.Assets.SmallImageKey = configFile.read("Image", "SmallImageKey");
                config.Assets.SmallImageText = configFile.read("Image", "SmallImageText");
            }
            catch
            {
                handleErrorSetting();
                return;
            }

            if (!isLegal())
            {
                handleErrorSetting();
            }
        }

        public void loadOption()
        {
            option.automaticStart = configFile.read("Option", "AutomaticStart") == "1";
            option.startMinimum = configFile.read("Option", "StartMinimum") == "1";
        }

        private void handleErrorSetting()
        {
            applyDefault();
            MessageBox.Show("設定檔案損毀 使用預設設定值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool isLegal()
        {
            if (string.IsNullOrEmpty(clientId) ||
                (!string.IsNullOrEmpty(config.Details) && config.Details.Length > 128) ||
                (!string.IsNullOrEmpty(config.State) && config.State.Length > 128) ||
                (!string.IsNullOrEmpty(config.Assets.LargeImageKey) && config.Assets.LargeImageKey.Length > 32) ||
                (!string.IsNullOrEmpty(config.Assets.LargeImageText) && config.Assets.LargeImageText.Length > 128) ||
                (!string.IsNullOrEmpty(config.Assets.SmallImageKey) && config.Assets.SmallImageKey.Length > 32) ||
                (!string.IsNullOrEmpty(config.Assets.SmallImageText) && config.Assets.SmallImageText.Length > 128))
            {
                return false;
            }

            long start = DateHelper.getMilliSecondFromDateTime(config.Timestamps.Start.Value);
            long end = DateHelper.getMilliSecondFromDateTime(config.Timestamps.End.Value);
            if (end != 0 && start > end)
            {
                return false;
            }
            return true;
        }

        private void applyDefault()
        {
            loadDefault();
            saveConfig();
            saveOption();
        }

        private void loadDefault()
        {
            clientId = "605336589270253579";

            config.Details = "棉被家族";
            config.State = "棉被最可愛了唷";

            config.Timestamps.Start = DateHelper.getDateTimeFromMilliSecond(0);
            config.Timestamps.End = DateHelper.getDateTimeFromMilliSecond(0);

            config.Assets.LargeImageKey = "chino";
            config.Assets.LargeImageText = "喵嗚";

            config.Assets.SmallImageKey = "gear";
            config.Assets.SmallImageText = "喵喵";
        }

        public void saveConfig()
        {
            configFile.write("Identifier", "ClientId", clientId);

            configFile.write("Status", "Detail", config.Details);
            configFile.write("Status", "State", config.State);
            configFile.write("Status", "StartTimestamp", DateHelper.getMilliSecondFromDateTime(config.Timestamps.Start.Value).ToString());
            configFile.write("Status", "EndTimestamp", DateHelper.getMilliSecondFromDateTime(config.Timestamps.End.Value).ToString());

            configFile.write("Image", "LargeImageKey", config.Assets.LargeImageKey);
            configFile.write("Image", "LargeImageText", config.Assets.LargeImageText);

            configFile.write("Image", "SmallImageKey", config.Assets.SmallImageKey);
            configFile.write("Image", "SmallImageText", config.Assets.SmallImageText);
        }

        public void saveOption()
        {
            configFile.write("Option", "AutomaticStart", option.automaticStart ? "1" : "0");
            configFile.write("Option", "StartMinimum", option.startMinimum ? "1" : "0");
        }

        public string getStatus()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-> 客戶端 ID : ").AppendLine(clientId);

            sb.Append("-> 詳細資訊 : ").AppendLine(config.Details);
            sb.Append("-> 狀態 : ").AppendLine(config.State);

            sb.Append("-> 大圖示 : ").Append(config.Assets.LargeImageKey).Append(" 說明 : ").AppendLine(config.Assets.LargeImageText);
            sb.Append("-> 小圖示 : ").Append(config.Assets.SmallImageKey).Append(" 說明 : ").AppendLine(config.Assets.SmallImageText);

            sb.Append("-> 開始時間戳記 : ").AppendLine(DateHelper.getMilliSecondFromDateTime(config.Timestamps.Start.Value).ToString());
            sb.Append("-> 結束時間戳記 : ").Append(DateHelper.getMilliSecondFromDateTime(config.Timestamps.End.Value).ToString());
            return sb.ToString();
        }

        public static RichPresence createEmptyRP()
        {
            return new RichPresence()
            {
                Timestamps = new Timestamps(),
                Assets = new Assets()
            };
        }
    }
}