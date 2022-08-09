using ParcelVision.SLMM.Constants;
using System;
using System.Collections.Generic;

namespace ParcelVision.SLMM.Model
{
    public class Lawn
    {
        public Lawn()
        {
            Orientation = new Dictionary<Direction, Axis>();
            Orientation.Add(Direction.South, new Axis { X = 0, Y = 0 });
        }

        public Dictionary<Direction, Axis> Orientation { get; set; }


    }


}
