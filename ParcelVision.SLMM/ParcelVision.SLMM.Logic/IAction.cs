using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;

namespace ParcelVision.SLMM.Logic
{
    public interface IAction
    {
        Actions Actions { get; }

        MowingMachine Do(MowingMachine mowingMachine);
    }
}
