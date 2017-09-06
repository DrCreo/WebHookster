using System;
using Newtonsoft.Json;

namespace WebHookster
{
    /// <summary>
    /// Represents an image in an embed.
    /// </summary>
    public class EmbedImage
    {
        /// <summary>
        /// Gets the source url of the image.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get;  set; }

        /// <summary>
        /// Gets a proxied url of the image.
        /// </summary>
        [JsonProperty("proxy_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ProxyUrl { get;  set; }

        /// <summary>
        /// Gets the height of the image.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get;  set; }

        /// <summary>
        /// Gets the width of the image.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get;  set; }

        public EmbedImage() { }
    }
}