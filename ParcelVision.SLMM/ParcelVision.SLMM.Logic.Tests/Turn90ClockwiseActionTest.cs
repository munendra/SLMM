using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
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
        public void MowingMachineLogic_Rotate_ShouldRoteTheMachineClockwise90()
        {
            var initMowingMachine = new MowingMachine();
            initMowingMachine.MoveTo = Direction.North;
            var mowingMachine = _turn90ClockwiseAction.Do(initMowingMachine);
            Assert.Equal(Direction.East,mowingMachine.MoveTo);
        }

        [Fact]
        public void MowingMachineLogic_Rotate_ShouldRoteTheMachineClockwise90FromWestToNorth()
        {
            var initMowingMachine = new MowingMachine();
            initMowingMachine.MoveTo = Direction.West;
            var mowingMachine = _turn90ClockwiseAction.Do(initMowingMachine);
            Assert.Equal(Direction.North, mowingMachine.MoveTo);
        }
    }
}
