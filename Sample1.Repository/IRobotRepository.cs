using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample1.Models.Input;
using Sample1.Models.Output;

namespace Sample1.Repository
{
    public interface IRobotRepository
    {
        public Task<Robot> CalculatePath(PalletTransportRequest s);
    }
}
