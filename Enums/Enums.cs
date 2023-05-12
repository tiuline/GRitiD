using System.ComponentModel;

namespace GRitiD.Enums
{
    public enum Messages
    {
        [Description("The informed quantity is null or zero, try a positive value!")]
        NotPositiveQuantityMessage = 1,
        [Description("The informed quantity is too high, try a lower value!")]
        QuantityTooHighMessage = 2
    }
}
