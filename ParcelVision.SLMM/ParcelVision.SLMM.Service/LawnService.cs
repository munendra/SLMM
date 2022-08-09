using ParcelVision.SLMM.Dtos;
using ParcelVision.SLMM.Logic;

namespace ParcelVision.SLMM.Service
{
    public class LawnService : ILawnService
    {
        private readonly ILawnLogic _lawnLogic;
        public LawnService(ILawnLogic lawnLogic)
        {
            _lawnLogic = lawnLogic;
        }
        public LawnRequestDto Task(LawnRequestDto lawnRequest)
        {
            var updateMowingMachine = _lawnLogic.Task(lawnRequest.Actions, lawnRequest.MowingMachine, lawnRequest.Lawn.Width, lawnRequest.Lawn.Length);
            lawnRequest.MowingMachine = updateMowingMachine;
            return lawnRequest;
        }
    }
}
