using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public class MoveOneStepForwardAction : IAction
    {
        public Actions Actions => Actions.MoveOneStepForward;

        public Task<MowingMachine> Do(MowingMachine mowingMachine)
        {
            Thread.Sleep(5000);
            var position = Movement.Position[mowingMachine.MoveTo];
            mowingMachine.Position.X = mowingMachine.Position.X + position.X;
            mowingMachine.Position.Y = mowingMachine.Position.Y + position.Y;
            return Task.Run(() => mowingMachine);
        }
    }
}
