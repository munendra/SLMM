using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System;

namespace ParcelVision.SLMM.Logic
{
    public class LawnLogic : ILawnLogic
    {

        private readonly IMowingMachineLogic _mowingMachineLogic;
        public LawnLogic(IMowingMachineLogic mowingMachineLogic)
        {
            _mowingMachineLogic = mowingMachineLogic;
        }


        public MowingMachine Task(Actions action, MowingMachine mowingMachine, int width, int length)
        {
            var lawn = GetLownOrientation(width, length);
            var isValid = _mowingMachineLogic.Validation(action, mowingMachine, lawn);
            if (isValid)
            {
              return _mowingMachineLogic.Operates(action, mowingMachine);
            }
            return mowingMachine;
        }

        public Lawn GetLownOrientation(int width, int length)
        {
            if (width == default(int) || length == default(int))
            {
                throw new Exception("Invalid width or length");
            }
            var lawn = new Lawn();
            lawn.Orientation.Add(Direction.West, GetWest(width, length, lawn.Orientation[Direction.South]));
            lawn.Orientation.Add(Direction.North, GetNorth(width, length, lawn.Orientation[Direction.South]));
            lawn.Orientation.Add(Direction.East, GetEast(width, length, lawn.Orientation[Direction.South]));
            return lawn;
        }

        private Axis GetWest(int width, int length, Axis referanceAxisFrom)
        {
            return new Axis()
            {
                X = referanceAxisFrom.X + length,
                Y = referanceAxisFrom.Y
            };
        }


        private Axis GetNorth(int width, int length, Axis referanceAxisFrom)
        {
            return new Axis()
            {
                X = referanceAxisFrom.X,
                Y = referanceAxisFrom.Y + width
            };
        }

        private Axis GetEast(int width, int length, Axis referanceAxisFrom)
        {
            return new Axis()
            {
                X = referanceAxisFrom.X + length,
                Y = referanceAxisFrom.Y + width
            };
        }

    }
}
