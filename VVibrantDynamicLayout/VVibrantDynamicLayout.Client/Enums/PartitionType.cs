using System.Runtime.Serialization;

namespace VVibrantDynamicLayout.Client.Enums;

public enum PartitionType
{
    [EnumMember(Value = "column")]
    Column,
    [EnumMember(Value = "row")]
    Row
}
