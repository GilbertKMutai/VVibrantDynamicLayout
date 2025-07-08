using System.Runtime.Serialization;

namespace VVibrantDynamicLayout.Client.Enums;

public enum ComponentType
{
    [EnumMember(Value = "row")]
    Row,
    [EnumMember(Value = "column")]
    Column
}
