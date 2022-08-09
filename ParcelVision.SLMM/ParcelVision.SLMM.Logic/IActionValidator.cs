using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public interface IActionValidator
    {
        Actions Actions { get; }

        Task<bool> IsActionValid(MowingMachine mowingMachine,Lawn lawn);
    }
}
