using System.Collections.Generic;

namespace Courier.Data
{
    public class Order
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public float Total { get; set; }
        public float FastDelivery { get; set; }
    }
}
