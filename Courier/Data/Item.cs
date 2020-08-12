using System.Collections.Generic;

namespace Courier.Data
{
    public class Item
    {
        public ParcelType ParcelType;

        public Dictionary<string, float> Costs = new Dictionary<string, float>();

        public float Total;
    }
}
