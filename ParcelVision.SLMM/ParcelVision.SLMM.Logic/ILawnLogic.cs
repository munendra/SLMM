

using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;

namespace ParcelVision.SLMM.Logic
{
    public interface ILawnLogic
    {
        Lawn GetLownOrientation(int width, int length);
        MowingMachine Task(Actions action, MowingMachine mowingMachine, int width, int length);
    }
}
