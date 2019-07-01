using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM.WinUI
{
    public static class Global
    {
        public static System.Drawing.Image DefaultAvatar;
        public static string YouTubeRegex = @"^(https?\:\/\/)?(www\.)?(youtube\.com|youtu\.?be)\/.+$";
        public static string ErrorIcon = $"{new System.IO.DirectoryInfo(System.Environment.CurrentDirectory).Parent.Parent.FullName}/Icons/error.ico";
        public static string DefAvatar = $"{new System.IO.DirectoryInfo(System.Environment.CurrentDirectory).Parent.Parent.FullName}/Avatars/Default.png";
    }
}
