using System;
using System.Collections.Generic;
using System.Text;

namespace Courier.Data
{
    public class Item
    {
        public List<Cost> Costs = new List<Cost>();
        public float Total;
    }
}
