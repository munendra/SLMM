using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParcelVision.SLMM.Logic
{
    public class Turn90AntiClockwiseAction : IAction
    {
        public Actions Actions => Actions.Turn90AntiClockwise;
        public int Angel => 90;
        public MowingMachine Do(MowingMachine mowingMachine)
        {
            Thread.Sleep(2000);
            if (mowingMachine.MoveTo == Direction.North)
            {
                mowingMachine.MoveTo = Direction.West;
                return mowingMachine;
            }
            var existingAngel = (int)mowingMachine.MoveTo;
            int angel = existingAngel - Angel;
            mowingMachine.MoveTo = (Direction)angel;
            return mowingMachine;
        }
    }
}
