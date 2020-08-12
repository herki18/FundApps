using System.Collections.Generic;
using System.Linq;
using Courier.Data;

namespace Courier.Discounts
{
    public class MixedDiscount : IDiscount
    {
        public void Apply(List<Item> items)
        {
            var sortedItems = items.Where(item => item.UsedInDiscount == false).OrderByDescending(item => item.Total).ToList();
            int count = sortedItems.Count / 5;

            for (int index = 0; index < count * 5; index++)
            {
                if ((index + 1) % 5 == 0)
                {
                    sortedItems[index].Discount = -sortedItems[index].Total;
                }

                sortedItems[index].UsedInDiscount = true;
            }
        }
    }
}
