using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DiscordRP
{
    public class ConsoleColorHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct COORD
        {
            public short x;
            public short y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SMALL_RECT
        {
            public short left;
            public short top;
            public short right;
            public short bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct COLORREF
        {
            private uint colorDWORD;

            public COLORREF(Color color)
            {
                colorDWORD = color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
            }

            public COLORREF(uint red, uint green, uint blue)
            {
                colorDWORD = red + (green << 8) + (blue << 16);
            }

            public Color getColor()
            {
                return Color.FromArgb((int)(0x000000FFU & colorDWORD), (int)(0x0000FF00U & colorDWORD) >> 8, (int)(0x00FF0000U & colorDWORD) >> 16);
            }

            public void setColor(Color color)
            {
                colorDWORD = color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CONSOLE_SCREEN_BUFFER_INFO_EX
        {
            public int cbSize;
            public COORD dwSize;
            public COORD dwCursorPosition;
            public ushort wAttribute;
            public SMALL_RECT srWindow;
            public COORD dwMaximumWindowSize;
            public ushort wPopupAttribute;
            public bool bFullScreenSupported;
            public COLORREF black;
            public COLORREF darkBlue;
            public COLORREF darkGreen;
            public COLORREF darkCyan;
            public COLORREF darkRed;
            public COLORREF darkMagenta;
            public COLORREF darkYellow;
            public COLORREF gray;
            public COLORREF darkGray;
            public COLORREF blue;
            public COLORREF green;
            public COLORREF cyan;
            public COLORREF red;
            public COLORREF magenta;
            public COLORREF yellow;
            public COLORREF white;
        }

        static ConsoleColorHelper()
        {
            INVALID_HANDLE_VALUE = new IntPtr(-1);
        }

        private ConsoleColorHelper()
        {
        }

        public static readonly IntPtr INVALID_HANDLE_VALUE;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleScreenBufferInfoEx(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO_EX csbe);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleScreenBufferInfoEx(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO_EX csbe);

        public static int setColor(ConsoleColor consoleColor, Color targetColor)
        {
            return setColor(consoleColor, targetColor.R, targetColor.G, targetColor.B);
        }

        public static int setColor(ConsoleColor color, uint red, uint green, uint blue)
        {
            CONSOLE_SCREEN_BUFFER_INFO_EX csbe = new CONSOLE_SCREEN_BUFFER_INFO_EX();
            csbe.cbSize = Marshal.SizeOf(csbe);

            IntPtr hConsoleOutput = ConsoleHelper.GetStdHandle(ConsoleHelper.STD_OUTPUT_HANDLE);
            if (hConsoleOutput == INVALID_HANDLE_VALUE)
            {
                return Marshal.GetLastWin32Error();
            }

            bool result = GetConsoleScreenBufferInfoEx(hConsoleOutput, ref csbe);
            if (!result)
            {
                return Marshal.GetLastWin32Error();
            }

            switch (color)
            {
                case ConsoleColor.Black:
                    {
                        csbe.black = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.DarkBlue:
                    {
                        csbe.darkBlue = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.DarkGreen:
                    {
                        csbe.darkGreen = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.DarkCyan:
                    {
                        csbe.darkCyan = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.DarkRed:
                    {
                        csbe.darkRed = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.DarkMagenta:
                    {
                        csbe.darkMagenta = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.DarkYellow:
                    {
                        csbe.darkYellow = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.Gray:
                    {
                        csbe.gray = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.DarkGray:
                    {
                        csbe.darkGray = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.Blue:
                    {
                        csbe.blue = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.Green:
                    {
                        csbe.green = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.Cyan:
                    {
                        csbe.cyan = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.Red:
                    {
                        csbe.red = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.Magenta:
                    {
                        csbe.magenta = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.Yellow:
                    {
                        csbe.yellow = new COLORREF(red, green, blue);
                        break;
                    }
                case ConsoleColor.White:
                    {
                        csbe.white = new COLORREF(red, green, blue);
                        break;
                    }
            }
            ++csbe.srWindow.bottom;
            ++csbe.srWindow.right;

            result = SetConsoleScreenBufferInfoEx(hConsoleOutput, ref csbe);
            if (!result)
            {
                return Marshal.GetLastWin32Error();
            }
            return 0;
        }

        public static int setConsoleColor(Color foregroundColor, Color backgroundColor)
        {
            int result = setColor(ConsoleColor.Gray, foregroundColor);
            if (result != 0)
            {
                return result;
            }

            result = setColor(ConsoleColor.Black, backgroundColor);
            if (result != 0)
            {
                return result;
            }
            return 0;
        }
    }
}