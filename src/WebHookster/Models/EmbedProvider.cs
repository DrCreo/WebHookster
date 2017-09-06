using System;
using Newtonsoft.Json;

namespace WebHookster
{
    /// <summary>
    /// Represents an embed provider.
    /// </summary>
    public sealed class EmbedProvider
    {
        /// <summary>
        /// Gets the name of the provider.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get;  set; }

        /// <summary>
        /// Gets the url of the provider.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get;  set; }

        internal EmbedProvider() { }
    }
}