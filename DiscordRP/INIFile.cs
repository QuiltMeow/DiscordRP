using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace DiscordRP
{
    // INI 檔案處理類別 支援 UTF - 8 編碼
    public class INIFile
    {
        public string fileName
        {
            get;
            private set;
        }

        public INIFile()
        {
            string path = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string fileName = Path.GetFileNameWithoutExtension(path) + ".ini";

            string dir = AppDomain.CurrentDomain.BaseDirectory;
            this.fileName = Path.Combine(dir, fileName);
        }

        public INIFile(string fileName, bool relative = true)
        {
            if (relative)
            {
                string dir = AppDomain.CurrentDomain.BaseDirectory;
                this.fileName = Path.Combine(dir, fileName);
            }
            else
            {
                this.fileName = fileName;
            }
        }

        public bool exist()
        {
            return File.Exists(fileName);
        }

        public bool isDirectory()
        {
            if (!exist())
            {
                return false;
            }
            FileAttributes attr = File.GetAttributes(fileName);
            return attr.HasFlag(FileAttributes.Directory);
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(byte[] section, byte[] key, byte[] val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(byte[] section, byte[] key, byte[] def, byte[] retVal, int size, string filePath);

        public void write(string section, string key, string value)
        {
            writeINI(fileName, section, key, value);
        }

        public string read(string section, string key, string defaultValue = "", int bufferSize = 128)
        {
            return readINI(fileName, section, key, defaultValue, bufferSize);
        }

        public static void writeINI(string iniFile, string section, string key, string value)
        {
            WritePrivateProfileString(getByte(section), getByte(key), getByte(value), iniFile);
        }

        public static string readINI(string iniFile, string section, string key, string defaultValue = "", int bufferSize = 128)
        {
            byte[] buffer = new byte[bufferSize];
            int count = GetPrivateProfileString(getByte(section), getByte(key), getByte(defaultValue), buffer, bufferSize, iniFile);
            return Encoding.UTF8.GetString(buffer, 0, count);
        }

        private static byte[] getByte(string data)
        {
            return string.IsNullOrEmpty(data) ? new byte[0] : Encoding.UTF8.GetBytes(data);
        }
    }
}