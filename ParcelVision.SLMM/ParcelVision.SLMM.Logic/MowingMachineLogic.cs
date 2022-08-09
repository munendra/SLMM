using Microsoft.Extensions.DependencyInjection;
using ParcelVision.SLMM.Constants;
using ParcelVision.SLMM.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelVision.SLMM.Logic
{
    public class MowingMachineLogic : IMowingMachineLogic
    {
        IEnumerable<IAction> _action;
        IEnumerable<IActionValidator> _actionValidator;
        public MowingMachineLogic(IEnumerable<IAction> action, IEnumerable<IActionValidator> actionValidator)
        {
            _action = action;
            _actionValidator = actionValidator;
        }

        public async Task<MowingMachine> Operates(Actions userAction, MowingMachine mowingMachine)
        {
            var actions = _action;
            var action = actions.FirstOrDefault(a => a.Actions == userAction);
            if (action == null)
            {
                throw new System.Exception("Invalid actions");
            }
            return await action.Do(mowingMachine);
        }

        public async Task<bool> Validation(Actions userAction, MowingMachine mowingMachine, Lawn lawn)
        {
            var actionValidators = _actionValidator;
            var actionValidator = actionValidators.FirstOrDefault(a => a.Actions == userAction);
            if (actionValidator != null)
            {
                return await actionValidator.IsActionValid(mowingMachine, lawn);
            }
            return true;
        }
    }
}
