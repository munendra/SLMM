using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public interface IAction
    {
        Actions Actions { get; }

        Task<MowingMachine> Do(MowingMachine mowingMachine);
    }
}
