using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;

namespace ParcelVision.SLMM.Logic
{
    public interface IActionValidator
    {
        Actions Actions { get; }

        bool IsActionValid(MowingMachine mowingMachine,Lawn lawn);
    }
}
