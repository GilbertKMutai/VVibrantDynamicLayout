
namespace VVibrantDynamicLayout.Client.Configuration;

public class LayoutComponent
{
    public string Id { get; set; } = string.Empty;
    //[JsonConverter(typeof(JsonStringEnumConverter))]
    public string Type { get; set; }
    public string Width { get; set; } = string.Empty;
    public string Alignment { get; set; } = string.Empty;
    public List<LayoutComponent> Components { get; set; } = default!;
}
