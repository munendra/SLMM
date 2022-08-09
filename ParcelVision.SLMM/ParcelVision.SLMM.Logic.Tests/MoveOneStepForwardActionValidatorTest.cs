using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System;
using Xunit;

namespace ParcelVision.SLMM.Logic.Tests
{
    public class MoveOneStepForwardActionValidatorTest
    {
        private readonly MoveOneStepForwardActionValidator _moveOneStepForwardActionValidator;
        public MoveOneStepForwardActionValidatorTest()
        {
            _moveOneStepForwardActionValidator = new MoveOneStepForwardActionValidator();
        }


        [Fact]
        public void MoveOneStepForwardActionValidator_IsActionValid_ShouldThrowExceptionIfMachineMovementOutSideOfLawn()
        {
            var lawn = new Lawn();
            lawn.Orientation.Add(Direction.North, new Axis() { X = 0, Y = 0 });
            lawn.Orientation.Add(Direction.West, new Axis() { X = 20, Y = 0 });
            lawn.Orientation.Add(Direction.East, new Axis() { X = 20, Y = 10 });
            var mowingMaching = new MowingMachine()
            {
                MoveTo = Constants.Direction.North,
                Position = new Axis() { X = 0, Y = 0 }
            };
            Assert.Throws<Exception>(() => _moveOneStepForwardActionValidator.IsActionValid(mowingMaching, lawn));
        }


        [Fact]
        public void MoveOneStepForwardActionValidator_IsActionValid_ShouldReturnTrueIfMachineMovementInSideLawn()
        {
            var lawn = new Lawn();
            lawn.Orientation.Add(Direction.North, new Axis() { X = 0, Y = 10 });
            lawn.Orientation.Add(Direction.West, new Axis() { X = 20, Y = 0 });
            lawn.Orientation.Add(Direction.East, new Axis() { X = 20, Y = 10 });
            var mowingMaching = new MowingMachine()
            {
                MoveTo = Constants.Direction.East,
                Position = new Axis() { X = 5, Y = 6 }
            };
            Assert.True(_moveOneStepForwardActionValidator.IsActionValid(mowingMaching, lawn));
        }
    }
}
