using Moq;
using ParcelVision.SLMM.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using ParcelVision.SLMM.Model;

namespace ParcelVision.SLMM.Logic.Tests
{
    public class Turn90AntiClockwiseActionTest
    {
        private readonly Turn90AntiClockwiseAction _turn90AntiClockwiseAction;
       
        public Turn90AntiClockwiseActionTest()
        {
            _turn90AntiClockwiseAction = new Turn90AntiClockwiseAction();
        }

        [Fact]
        public void MowingMachineLogic_Rotate_ShouldRoteTheMachineAntiClockwise90FromNorthToWest()
        {
            var initMowingMachine = new MowingMachine();
            initMowingMachine.MoveTo = Direction.North;
            var mowingMachine = _turn90AntiClockwiseAction.Do(initMowingMachine);
            Assert.Equal(Direction.West,mowingMachine.MoveTo);
        }

        [Fact]
        public void MowingMachineLogic_Rotate_ShouldRoteTheMachineClockwise90FromWestToNorth()
        {
            var initMowingMachine = new MowingMachine();
            initMowingMachine.MoveTo = Direction.West;
            var mowingMachine = _turn90AntiClockwiseAction.Do(initMowingMachine);
            Assert.Equal(Direction.South, mowingMachine.MoveTo);
        }
    }
}
