using System.Collections.Generic;
using System.Linq;
using Courier.Data;

namespace Courier.Discounts
{
    public class MediumDiscount : IDiscount
    {
        public void Apply(List<Item> items)
        {
            var sortedItems = items.Where(item => item.ParcelType == ParcelType.Medium && item.UsedInDiscount == false).OrderByDescending(item => item.Total).ToList();
            int count = sortedItems.Count / 3;

            for (int index = 0; index < count * 3; index++)
            {
                if ((index + 1) % 3 == 0)
                {
                    sortedItems[index].Discount = -sortedItems[index].Total;
                }

                sortedItems[index].UsedInDiscount = true;
            }
        }
    }
}
