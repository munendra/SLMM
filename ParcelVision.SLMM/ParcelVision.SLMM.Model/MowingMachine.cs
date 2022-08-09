using ParcelVision.SLMM.Constants;
using System.Collections.Generic;

namespace ParcelVision.SLMM.Model
{
    public class MowingMachine
    {
        public Axis Position { get; set; }

        public Direction MoveTo { get; set; }

        public MowingMachine()
        {
            Position = new Axis { X = 0, Y = 0 };
            MoveTo = Direction.North;
        }

    }


    


}
