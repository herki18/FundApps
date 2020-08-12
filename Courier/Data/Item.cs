using System.Collections.Generic;

namespace Courier.Data
{
    public class Item
    {
        public int Id;

        public ParcelType ParcelType { get; set; }

        public Dictionary<string, float> Costs { get; set; } = new Dictionary<string, float>();

        public float Discount { get; set; }
        public float Total { get; set; }

        public bool UsedInDiscount { get; set; }
    }
}
