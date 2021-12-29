using System;

namespace Sample1.Models.Input
{
    public class PalletTransportRequest
    {
        public long loadId { get; set; }
        public decimal x { get; set; }
        public decimal y { get; set; }
    }
}
