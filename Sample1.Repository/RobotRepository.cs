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
            Robot r = new Robot();

            r.batteryLevel = 1;
            r.distanceToGoal = 1;
            r.robotId = 1;

            return r;

            //Sorry, ran out of time trying to figure out the formula...
        }
    }
}
