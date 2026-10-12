using System.Text.Json.Serialization;

namespace PostServiceAppMax.Models
{
    public class PostalItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("deliveryType")]
        public int DeliveryType { get; set; } // 0 - стандарт, 1 - кур'єр

        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        [JsonPropertyName("width")]
        public decimal Width { get; set; }

        [JsonPropertyName("height")]
        public decimal Height { get; set; }

        [JsonPropertyName("depth")]
        public decimal Depth { get; set; }

        [JsonPropertyName("value")]
        public decimal Value { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonIgnore]
        public string DeliveryTypeTitle => DeliveryType == 1 ? "Кур'єрська" : "У відділення";

        [JsonIgnore]
        public string SizeInfo => $"{Depth}x{Width}x{Height} см";
    }
}
