using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading;

namespace ParcelVision.SLMM.Logic
{
    public class MoveOneStepForwardAction : IAction
    {
        public Actions Actions => Actions.MoveOneStepForward;
       
        public MowingMachine Do(MowingMachine mowingMachine)
        {
            Thread.Sleep(5000);
            var position = Movement.Position[mowingMachine.MoveTo];
            mowingMachine.Position.X = mowingMachine.Position.X + position.X;
            mowingMachine.Position.Y = mowingMachine.Position.Y + position.Y;
            return mowingMachine;
        }
    }
}
