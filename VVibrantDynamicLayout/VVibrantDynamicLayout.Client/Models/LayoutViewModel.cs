namespace VVibrantDynamicLayout.Client.Models;

public class LayoutViewModel
{
    public string Gutter { get; set; } = string.Empty;
    public string PartitionSpacing { get; set; } = string.Empty;
    public List<PartitionViewModel> Partitions { get; set; } = null!;
}
