using Moq;
using ParcelVision.SLMM.Constants;
using System;
using Xunit;

namespace ParcelVision.SLMM.Logic.Tests
{
    public class LawnLogicTest
    {
        public readonly LawnLogic _lawnLogic;
        private readonly Mock<IMowingMachineLogic> _mowingMachineLogic;
        public LawnLogicTest()
        {
            _mowingMachineLogic = new Mock<IMowingMachineLogic>();
            _lawnLogic = new LawnLogic(_mowingMachineLogic.Object);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldThrowTheExceptionIfLengthWightIsZero()
        {
            Assert.Throws<Exception>(() => _lawnLogic.GetLownOrientation(0, 0));
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForSouthX()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(0, lawn.Orientation[Direction.South].X);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForSouthY()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(0, lawn.Orientation[Direction.South].Y);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForWestX()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(20, lawn.Orientation[Direction.West].X);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForWestY()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(0, lawn.Orientation[Direction.West].Y);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForNorthX()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(0, lawn.Orientation[Direction.North].X);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForNorthY()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(10, lawn.Orientation[Direction.North].Y);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForEastX()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(20, lawn.Orientation[Direction.East].X);
        }

        [Fact]
        public void LawnLogic_GetLownOrientation_ShouldReturnZeroLawnOrientationForEastY()
        {
            var lawn = _lawnLogic.GetLownOrientation(10, 20);
            Assert.Equal(10, lawn.Orientation[Direction.East].Y);
        }
    }
}
