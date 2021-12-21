using Microsoft.Win32.SafeHandles;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace DiscordRP
{
    public class ConsoleHelper
    {
        public const int STD_OUTPUT_HANDLE = -11;
        public const string CMD_ENCODE = "Big5"; // Windows 主控台視窗使用的爛爛編碼

        public const uint SC_CLOSE = 0xF060;
        public const uint MF_ENABLED = 0x00000000;
        public const uint MF_GRAYED = 0x00000001;
        public const uint MF_DISABLED = 0x00000002;
        public const uint MF_BYCOMMAND = 0x00000000;

        private readonly string title;

        private SafeFileHandle sfh;
        private FileStream fs;
        private StreamWriter stdOut;

        private static ConsoleHelper _instance;

        public static ConsoleHelper getInstance(string title)
        {
            if (_instance == null)
            {
                _instance = new ConsoleHelper(title);
            }
            return _instance;
        }

        public bool allocate
        {
            get;
            private set;
        }

        private ConsoleHelper(string title)
        {
            this.title = title;
        }

        // 系統 API 呼叫堆
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool FreeConsole();

        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleTitle(string lpConsoleTitle);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern bool DeleteMenu(IntPtr hMenu, uint nPosition, uint wFlag);

        public void setupConsole()
        {
            if (allocate)
            {
                return;
            }

            AllocConsole();
            IntPtr consoleHandle = GetConsoleWindow();
            IntPtr menuHandle = GetSystemMenu(consoleHandle, false);
            DeleteMenu(menuHandle, SC_CLOSE, MF_BYCOMMAND);

            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            sfh = new SafeFileHandle(stdHandle, true);
            fs = new FileStream(sfh, FileAccess.Write);
            Encoding encoding = Encoding.GetEncoding(CMD_ENCODE);
            stdOut = new StreamWriter(fs, encoding)
            {
                AutoFlush = true
            };
            Console.SetOut(stdOut);

            SetConsoleTitle(title);
            ConsoleColorHelper.setConsoleColor(Color.White, Color.DarkCyan);

            Console.WriteLine("主控台初始化完成");
            allocate = true;
        }

        public void removeConsole()
        {
            if (!allocate)
            {
                return;
            }

            stdOut.Close();
            fs.Close();
            sfh.Close();
            FreeConsole();
            allocate = false;
        }

        public void toggleConsole()
        {
            if (!allocate)
            {
                setupConsole();
            }
            else
            {
                removeConsole();
            }
        }
    }
}