using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimpleRadio.Items
{
    /// <summary>
    /// Information about the radio.
    /// </summary>
    public class Radio
    {
        /// <summary>
        /// The name for the radio.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The radio frequency.
        /// </summary>
        [JsonProperty("frequency")]
        public float Frequency { get; set; }
        /// <summary>
        /// The type of radio
        /// </summary>
        [JsonProperty("type")]
        public RadioType Type { get; set; }
        /// <summary>
        /// The location of the Radio. This can be a path or URL/URI.
        /// </summary>
        [JsonProperty("loc")]
        public string Location { get; set; }
        /// <summary>
        /// An optional ID for playing the radio.
        /// This can be the vanilla radio ID, an index of an array, etc.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }
        /// <summary>
        /// List of songs used by the radio.
        /// </summary>
        [JsonProperty("songs")]
        public List<Song> Songs { get; set; }
    }
}
