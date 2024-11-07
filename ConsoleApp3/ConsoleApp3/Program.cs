using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static async Task<string> GetS()
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://d12.drivemusic.me/dl/HphW6uCD_jLe5gWRJN9SJA/1730224299/download_music/2020/06/julija-chicherina-tu-lu-la.mp3", "C:\\Users\\TEACHER\\вася");
            HttpClient httpClient = new HttpClient();
            string r = await httpClient.GetStringAsync("https://www.drivemusic.club/song/235626-julija-chicherina-tu-lu-la.html");
            return r;
        }
        static void Main(string[] args)
        {
            IgorBest igorBest = new IgorBest();
            Task<string> t = GetS();
            Console.WriteLine(IgorBest.GetS());
            Console.ReadLine();
        }
    }
}
