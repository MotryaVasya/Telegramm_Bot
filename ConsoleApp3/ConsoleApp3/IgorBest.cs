using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class IgorBest
    {
        public static async Task<string> GetS()
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://d12.drivemusic.me/dl/HphW6uCD_jLe5gWRJN9SJA/1730224299/download_music/2020/06/julija-chicherina-tu-lu-la.mp3", "C:\\Users\\STUDENT\\вася");
            HttpClient httpClient = new HttpClient();
            string r = await httpClient.GetStringAsync("https://www.drivemusic.club/song/235626-julija-chicherina-tu-lu-la.html");
            return r;
        }

        public async void DoSomethingAsync()
        {
            Console.Write("x=");
            double x = await DoSomething(200);
            Console.WriteLine(x);

            Console.Write("y=");
            double y = await DoSomething(100);
            Console.WriteLine(y);
        }
        public Task<double> DoSomething(int n)
        {
            return Task.Run(() =>
            {
                double s = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            s += (Math.Sqrt(Math.E * i) * Math.PI) / (k + 1);
                        }
                    }
                }
                return s;
            });
        }
    }
}
