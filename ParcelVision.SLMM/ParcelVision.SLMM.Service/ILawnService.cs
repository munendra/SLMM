using ParcelVision.SLMM.Dtos;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Service
{
    public interface ILawnService
    {
        Task<LawnRequestDto> Task(LawnRequestDto lawnRequest);
    }
}
