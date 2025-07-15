
namespace VVibrantDynamicLayout.Client.Configuration;

public class LayoutComponent
{
    public string Id { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Width { get; set; } = string.Empty;
    public string Alignment { get; set; } = string.Empty;
    public bool IsPartition { get; set; }
    public List<LayoutComponent> Components { get; set; } = default!;
}
