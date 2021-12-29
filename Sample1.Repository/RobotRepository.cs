using System;
using System.Threading.Tasks;
using Sample1.Models.Input;
using Sample1.Models.Output;

namespace Sample1.Repository
{
    public class RobotRepository : IRobotRepository
    {       
        async Task<Robot> IRobotRepository.CalculatePath(PalletTransportRequest s)
        {
            throw new NotImplementedException();
        }
    }
}
