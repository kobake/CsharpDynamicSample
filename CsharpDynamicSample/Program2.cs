using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyCsharpDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                using (var client = new HttpClient())
                {
                    // 桜島の 2018-11-30 ～ 2018-12-01 までのアクティビティ
                    var json = await client.GetStringAsync(
                        @"http://api.aitc.jp/jmardb-api/search?datetime=2018-11-30%2000:00:00&datetime=2018-12-01%2000:00:00&areaname=%E6%A1%9C%E5%B3%B6");
                    var obj = JsonConvert.DeserializeObject<dynamic>(json);
                    foreach (var data in obj.data)
                    {
                        var headline = data.headline[0];
                        Console.WriteLine(headline);
                    }
                }
            }).Wait();
        }
    }
}
