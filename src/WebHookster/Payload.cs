using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebHookster
{
    public class Payload
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }

        [JsonProperty("embeds")]
        public List<Embed> Embed { get; set; }
    }
}