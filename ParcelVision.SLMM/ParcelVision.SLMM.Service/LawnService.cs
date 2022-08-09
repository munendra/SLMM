using ParcelVision.SLMM.Dtos;
using ParcelVision.SLMM.Logic;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Service
{
    public class LawnService : ILawnService
    {
        private readonly ILawnLogic _lawnLogic;
        public LawnService(ILawnLogic lawnLogic)
        {
            _lawnLogic = lawnLogic;
        }
        public async Task<LawnRequestDto> Task(LawnRequestDto lawnRequest)
        {
            var updateMowingMachine = await _lawnLogic.Task(lawnRequest.Actions, lawnRequest.MowingMachine, lawnRequest.Lawn.Width, lawnRequest.Lawn.Length);
            lawnRequest.MowingMachine = updateMowingMachine;
            return lawnRequest;
        }
    }
}
