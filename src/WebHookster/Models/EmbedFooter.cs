using System;
using Newtonsoft.Json;

namespace WebHookster
{
    /// <summary>
    /// Represents a footer in an embed.
    /// </summary>
    public sealed class EmbedFooter
    {
        /// <summary>
        /// Gets the footer's text.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Gets the url of the footer's icon.
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri IconUrl { get;  set; }

        /// <summary>
        /// Gets the proxied url of the footer's icon.
        /// </summary>
        [JsonProperty("proxy_icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ProxyIconUrl { get; internal set; }

        public EmbedFooter() { }
    }
}