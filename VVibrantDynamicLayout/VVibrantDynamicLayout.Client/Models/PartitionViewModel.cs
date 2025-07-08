using System.Text.Json.Serialization;
using VVibrantDynamicLayout.Client.Enums;

namespace VVibrantDynamicLayout.Client.Models;

public class PartitionViewModel
{
    public string Id { get; set; } = string.Empty;
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public PartitionType Type  { get; set; }
    public List<ComponentViewModel> Components { get; set; } = default!;
}
