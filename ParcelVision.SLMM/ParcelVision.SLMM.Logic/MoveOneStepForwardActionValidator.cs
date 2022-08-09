using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public class MoveOneStepForwardActionValidator : IActionValidator
    {
        public Actions Actions => Actions.MoveOneStepForward;

        public Task<bool> IsActionValid(MowingMachine mowingMachine, Lawn lawn)
        {
            var position = Movement.Position[mowingMachine.MoveTo];
            int x = mowingMachine.Position.X + position.X;
            int y = mowingMachine.Position.Y + position.Y;
            var lawnOrientation = lawn.Orientation[mowingMachine.MoveTo];

            if (x < 0 || y < 0)
            {
                throw new System.Exception("Invalid mowing maching move or out of area move request.");
            }
            if (x <= lawnOrientation.X && y <= lawnOrientation.Y)
            {
                return Task.Run(() => true);
            }
            return Task.Run(() => false);
        }
    }
}
