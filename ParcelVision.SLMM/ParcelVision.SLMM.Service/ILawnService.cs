using ParcelVision.SLMM.Dtos;

namespace ParcelVision.SLMM.Service
{
    public interface ILawnService
    {
        LawnRequestDto Task(LawnRequestDto lawnRequest);
    }
}
