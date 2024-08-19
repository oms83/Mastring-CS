using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Strings
{
    public class Encoding_Unicode
    {
        public static async Task run()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = $"{path}\\utf8NewsContent.txt";

            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri("https://www.aljazeera.net/news/");

                using (HttpResponseMessage response = new HttpResponseMessage())
                {
                    var byteArray = await client.GetByteArrayAsync(uri);
                    string result = Encoding.UTF8.GetString(byteArray);
                    File.WriteAllText(filePath, result);
                }

            }
        }
    }
}
