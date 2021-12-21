using DiscordRPC;
using DiscordRPC.Message;

namespace DiscordRP
{
    public class Client
    {
        public const int DISCORD_PIPE = -1; // Automatic

        private static readonly DiscordRPC.Logging.LogLevel logLevel;

        private DiscordRpcClient rpc;

        public bool isRunning
        {
            get;
            private set;
        }

        public RPConfig config
        {
            get;
            private set;
        }

        static Client()
        {
            logLevel = DiscordRPC.Logging.LogLevel.Trace; // Debug
        }

        public Client()
        {
            config = new RPConfig();
        }

        public void start()
        {
            isRunning = true;
            rpc = new DiscordRpcClient(config.clientId, DISCORD_PIPE, new DiscordRPC.Logging.ConsoleLogger(logLevel, true), false);

            rpc.OnReady += onReady;
            rpc.OnClose += onClose;
            rpc.OnError += onError;
            rpc.OnConnectionEstablished += onConnectionEstablished;
            rpc.OnConnectionFailed += onConnectionFailed;
            rpc.OnPresenceUpdate += onPresenceUpdate;

            rpc.Initialize();
            updateRP();
            Program.form.toggleUIState(true);
        }

        public void updateRP()
        {
            if (isRunning && rpc != null)
            {
                RichPresence rp = RPConfig.createEmptyRP();
                rp.Details = config.config.Details;
                rp.State = config.config.State;
                rp.Assets = config.config.Assets;

                if (DateHelper.getMilliSecondFromDateTime(config.config.Timestamps.Start.Value) != 0)
                {
                    rp.Timestamps.Start = config.config.Timestamps.Start.Value;
                }
                if (DateHelper.getMilliSecondFromDateTime(config.config.Timestamps.End.Value) != 0)
                {
                    rp.Timestamps.End = config.config.Timestamps.End.Value;
                }

                rpc.SetPresence(rp);
            }
        }

        public void disconnect(int signal)
        {
            if (isRunning && rpc != null)
            {
                Program.form.appendOutput("[操作] 正在關閉 RPC 客戶端 訊號 : " + signal);
                rpc.Dispose();
                isRunning = false;
                Program.form.toggleUIState(false);
            }
        }

        public void restart()
        {
            disconnect(0);
            start();
        }

        public void invoke()
        {
            if (isRunning && rpc != null)
            {
                rpc.Invoke();
            }
        }

        private void onReady(object sender, ReadyMessage args)
        {
            Program.form.appendOutput("[事件] Discord 準備完成 RPC 版本 : " + args.Version);
            Program.form.appendOutput("[資訊] 正在顯示目標帳號 " + args.User.Username + "#" + args.User.Discriminator + " 之自訂狀態");
        }

        private void onClose(object sender, CloseMessage args)
        {
            Program.form.appendOutput("[事件] Discord 中斷連線 (" + args.Code + ") : " + args.Reason);
        }

        private void onError(object sender, ErrorMessage args)
        {
            Program.form.appendOutput("[事件] Discord 發生錯誤 (" + args.Code + ") : " + args.Message);
            disconnect(1);
        }

        private void onConnectionEstablished(object sender, ConnectionEstablishedMessage args)
        {
            Program.form.appendOutput("[事件] 管線連線已建立 有效管線 #" + args.ConnectedPipe);
        }

        private void onConnectionFailed(object sender, ConnectionFailedMessage args)
        {
            Program.form.appendOutput("[事件] 管線連線失敗 無法連線至管線 #" + args.FailedPipe);
            disconnect(1);
        }

        private void onPresenceUpdate(object sender, PresenceMessage args)
        {
            Program.form.appendOutput("\r\n[自訂狀態更新]");
            Program.form.appendOutput(config.getStatus() + "\r\n");
        }
    }
}