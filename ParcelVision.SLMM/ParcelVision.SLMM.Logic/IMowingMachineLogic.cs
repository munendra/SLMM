using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public interface IMowingMachineLogic
    {
        Task<MowingMachine> Operates(Actions userAction, MowingMachine mowingMachine);
        Task<bool> Validation(Actions userAction, MowingMachine mowingMachine, Lawn lawn);
    }
}
