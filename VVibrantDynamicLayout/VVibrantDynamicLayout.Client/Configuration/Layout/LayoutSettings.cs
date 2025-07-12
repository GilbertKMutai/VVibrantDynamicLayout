namespace VVibrantDynamicLayout.Client.Configuration;

public class LayoutSettings
{
    public string Gutter { get; set; } = string.Empty;
    public string PartitionSpacing { get; set; } = string.Empty;
    public List<LayoutComponent> Partitions { get; set; } = null!;
}
