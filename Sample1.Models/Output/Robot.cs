using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1.Models.Output
{
    public class Robot
    {
        public long robotId { get; set; }
        public decimal distanceToGoal { get; set; }
        public decimal batteryLevel { get; set; }
    }
}
