using System;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebHookster
{
    public class WebhookClient
    {
        private readonly Uri _uri;
        private readonly Encoding _encoding = new UTF8Encoding();

        public WebhookClient(string url)
        {
            _uri = new Uri(url);
        }

        public async void PostMessageAsync(string content, string username = null, string avatarUrl = null, Embed embed = null)
        {
            var embeds = new List<Embed>();
            embeds.Add(embed);
            Payload payload = new Payload()
            {
                Username = username,
                Content = content,
                AvatarURL = avatarUrl,
                Embed = embeds
            };

            await PostMessageAsync(payload);
        }

        public async void PostMessageAsync(string content, Embed embed = null)
        {
            var embeds = new List<Embed>();
            embeds.Add(embed);
            Payload payload = new Payload()
            {
                Content = content,
                Embed = embeds
            };

            await PostMessageAsync(payload);
        }

        public async void PostMessageAsync(string content)
        {
            Payload payload = new Payload()
            {
                Content = content,
            };

            await PostMessageAsync(payload);
        }

        public async void PostMessageAsync(Embed embed)
        {
            var embeds = new List<Embed>();
            embeds.Add(embed);
            Payload payload = new Payload()
            {
                Embed = embeds
            };

            await PostMessageAsync(payload);
        }

        public async Task PostMessageAsync(Payload payload)
        {
            string payloadJson = JsonConvert.SerializeObject(payload);

            await WHHttpClient.PostAsync(payloadJson, _uri);
        }
    }
}
