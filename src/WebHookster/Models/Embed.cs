using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebHookster
{
    /// <summary>
    /// Represents a  embed.
    /// </summary>
    public sealed class Embed
    {
        internal Embed()
        {
            this._color_lazy = new Lazy<Color>(() => new Color(this._color));
        }

        /// <summary>
        /// Gets the embed's title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; internal set; }

        /// <summary>
        /// Gets the embed's type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; internal set; }

        /// <summary>
        /// Gets the embed's description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; internal set; }

        /// <summary>
        /// Gets the embed's url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; internal set; }

        /// <summary>
        /// Gets the embed's timestamp.
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; internal set; }

        /// <summary>
        /// Gets the embed's color.
        /// </summary>
        [JsonIgnore]
        public Color Color => this._color_lazy.Value;
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        internal int _color;
        [JsonIgnore]
        private Lazy<Color> _color_lazy;

        /// <summary>
        /// Gets the embed's footer.
        /// </summary>
        [JsonProperty("footer", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedFooter Footer { get;  set; }

        /// <summary>
        /// Gets the embed's image.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedImage Image { get;  set; }

        /// <summary>
        /// Gets the embed's thumbnail.
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedThumbnail Thumbnail { get; internal set; }

        /// <summary>
        /// Gets the embed's video.
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedVideo Video { get; internal set; }

        /// <summary>
        /// Gets the embed's provider.
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedProvider Provider { get; internal set; }

        /// <summary>
        /// Gets the embed's author.
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedAuthor Author { get; internal set; }

        /// <summary>
        /// Gets the embed's fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<EmbedField> Fields { get; internal set; }
    }
}