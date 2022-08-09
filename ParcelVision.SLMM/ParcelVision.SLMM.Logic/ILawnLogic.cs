

using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public interface ILawnLogic
    {
        Lawn GetLownOrientation(int width, int length);
        Task<MowingMachine> Task(Actions action, MowingMachine mowingMachine, int width, int length);
    }
}
