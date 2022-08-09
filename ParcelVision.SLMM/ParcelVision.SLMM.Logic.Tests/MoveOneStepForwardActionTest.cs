using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading.Tasks;
using Xunit;

namespace ParcelVision.SLMM.Logic.Tests
{
    public class MoveOneStepForwardActionTest
    {
        private readonly MoveOneStepForwardAction _moveOneStepForwardAction;

        public MoveOneStepForwardActionTest()
        {

            _moveOneStepForwardAction = new MoveOneStepForwardAction();
        }

        [Fact]
        public async Task MoveOneStepForwardAction_Do_ShouldMoveOneStepTowardsNorth()
        {
            var mowingMachine = new MowingMachine()
            {
                MoveTo = Direction.North,
                Position = new Axis
                {
                    X = 5,
                    Y = 6
                }
            };
            var newMowingMachinePosition = await _moveOneStepForwardAction.Do(mowingMachine);
            Assert.Equal(4, newMowingMachinePosition.Position.X);
        }

        [Fact]
        public async Task MoveOneStepForwardAction_Do_ShouldMoveOneStepTowardsWest()
        {
            var mowingMachine = new MowingMachine()
            {
                MoveTo = Direction.West,
                Position = new Axis
                {
                    X = 5,
                    Y = 6
                }
            };
            var newMowingMachinePosition = await _moveOneStepForwardAction.Do(mowingMachine);
            Assert.Equal(5, newMowingMachinePosition.Position.Y);
        }
    }
}
