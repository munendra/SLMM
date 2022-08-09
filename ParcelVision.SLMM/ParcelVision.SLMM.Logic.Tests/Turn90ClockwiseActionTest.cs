using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Threading.Tasks;
using Xunit;

namespace ParcelVision.SLMM.Logic.Tests
{
    public class Turn90ClockwiseActionTest
    {
        private readonly Turn90ClockwiseAction _turn90ClockwiseAction;
       
        public Turn90ClockwiseActionTest()
        {

            _turn90ClockwiseAction = new Turn90ClockwiseAction();
        }

        [Fact]
        public async Task MowingMachineLogic_Rotate_ShouldRoteTheMachineClockwise90()
        {
            var initMowingMachine = new MowingMachine();
            initMowingMachine.MoveTo = Direction.North;
            var mowingMachine = await _turn90ClockwiseAction.Do(initMowingMachine);
            Assert.Equal(Direction.East,mowingMachine.MoveTo);
        }

        [Fact]
        public async Task MowingMachineLogic_Rotate_ShouldRoteTheMachineClockwise90FromWestToNorth()
        {
            var initMowingMachine = new MowingMachine();
            initMowingMachine.MoveTo = Direction.West;
            var mowingMachine = await _turn90ClockwiseAction.Do(initMowingMachine);
            Assert.Equal(Direction.North, mowingMachine.MoveTo);
        }
    }
}
