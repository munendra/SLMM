using ParcelVision.SLMM.Constants;
using System.Collections.Generic;

namespace ParcelVision.SLMM.Model
{
    public static class Movement
    {
        static Movement()
        {
            Position = new Dictionary<Direction, Axis>();
            Position.Add(Direction.North, new Axis { X = -1, Y = 0 });
            Position.Add(Direction.East, new Axis { X = 0, Y = 1 });
            Position.Add(Direction.South, new Axis { X = 1, Y = 0 });
            Position.Add(Direction.West, new Axis { X = 0, Y = -1 });
        }

        public static Dictionary<Direction, Axis> Position { get;}
    }


}
