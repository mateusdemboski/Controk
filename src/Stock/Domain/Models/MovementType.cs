namespace Controk.Stock.Domain.Models;

using System.ComponentModel;

public enum MovementType
{
    Unknown = 0,

    [Description("Input")]
    In = 1,

    [Description("Output")]
    Out = 2,
}
