namespace WebServicesHomework.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Wishlist
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("isbn")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Isbn { get; set; }
    }
}