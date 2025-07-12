using System.Runtime.Serialization;

namespace VVibrantDynamicLayout.Client.Enums;

public enum LayoutType
{
    [EnumMember(Value = "row")]
    Row,
    [EnumMember(Value = "column")]
    Column
}
