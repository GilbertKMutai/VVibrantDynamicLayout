using System.Text.Json.Serialization;
using VVibrantDynamicLayout.Client.Enums;

namespace VVibrantDynamicLayout.Client.Models;

public class ComponentViewModel
{
    public string Id { get; set; } = string.Empty;
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ComponentType Type { get; set; }
    public List<ChildComponentViewModel> Components { get; set; } = default!;
}
