using Newtonsoft.Json.Linq;
using System;
using System.IO;
using WebHookster;

namespace WebHook.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WebhookClient _client = new WebhookClient("Inset WebHook url");

            var jObject =JObject.Parse(File.ReadAllText("Json.json"));
            try
            {
                var em = new EmbedBuilder()
                {
                    Title = "Did you know...",
                    ImageUrl = "https://img.buzzfeed.com/buzzfeed-static/static/2014-03/enhanced/webdr02/26/18/original-5460-1395871268-26.jpg?downsize=715:*&output-format=auto&output-quality=auto",
                    Description = "There are cats who have survived falls from over 32 stories (320 meters) onto concrete.\nQuite interesting indeed don't you agree?",
                    Color = new Color(242, 186, 225),
                };

            _client.PostMessageAsync("Hello World.");
            }
            catch(Exception exc)
            {
                Console.WriteLine($"{exc.Message}\n\n{exc.StackTrace}");
            }
            Console.ReadLine();
        }
    }
}