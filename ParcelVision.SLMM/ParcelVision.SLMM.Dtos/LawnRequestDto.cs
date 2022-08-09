using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System;

namespace ParcelVision.SLMM.Dtos
{
    public class LawnRequestDto
    {
        public LawnDto Lawn { get; set; }
        public MowingMachine MowingMachine { get; set; }
        public Actions Actions { get; set; }
    }

    public class LawnDto
    {
        public int Width { get; set; }
        public int Length { get; set; }
    }
}
