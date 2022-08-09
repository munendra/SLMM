using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;

namespace ParcelVision.SLMM.Logic
{
    public interface IMowingMachineLogic
    {
        MowingMachine Operates(Actions userAction, MowingMachine mowingMachine);
        bool Validation(Actions userAction, MowingMachine mowingMachine, Lawn lawn);
    }
}
