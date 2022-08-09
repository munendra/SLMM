using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public class Turn90ClockwiseAction : IAction
    {
        public Actions Actions => Actions.Turn90Clockwise;
        public int Angel => 90;
        public Task<MowingMachine> Do(MowingMachine mowingMachine)
        {
            Thread.Sleep(2000);
            if (mowingMachine.MoveTo == Direction.West)
            {
                mowingMachine.MoveTo = Direction.North;
                return Task.Run(() => mowingMachine);
            }
            var existingAngel = (int)mowingMachine.MoveTo;
            int angel = existingAngel + Angel;
            mowingMachine.MoveTo = (Direction)angel;
            return Task.Run(() => mowingMachine);
        }
    }
}
