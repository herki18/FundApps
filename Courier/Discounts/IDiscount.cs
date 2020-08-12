using System.Collections.Generic;
using Courier.Data;

namespace Courier.Discounts
{
    public interface IDiscount
    {
        void Apply(List<Item> items);
    }
}
