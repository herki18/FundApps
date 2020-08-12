using System.Collections.Generic;

namespace Courier.Data
{
    public class Order
    {
        public List<Item> Items = new List<Item>();
        public float Total;
    }
}
