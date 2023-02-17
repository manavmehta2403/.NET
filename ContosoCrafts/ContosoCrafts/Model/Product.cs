using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.Model
{
    // Product myDeserializedClass = JsonConvert.DeserializeObject<List<Product>>(myJsonResponse);
    public class Product
    {
        [JsonPropertyName("Id")]
        public string? Id { get; set; }

        [JsonPropertyName("Maker")]
        public string? Maker { get; set; }

        [JsonPropertyName("img")]
        public string? Img { get; set; }

        [JsonPropertyName("Url")]
        public string? Url { get; set; }

        [JsonPropertyName("Title")]
        public string? Title { get; set; }

        [JsonPropertyName("Description")]
        public string? Description { get; set; }

        [JsonPropertyName("Ratings")]
        public List<int?>? Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
