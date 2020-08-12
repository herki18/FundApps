using System;
using System.Collections.Generic;
using System.Linq;
using Courier.Data;

namespace Courier.Discounts
{
    public class SmallDiscount : IDiscount
    {
        public void Apply(List<Item> items)
        {
            var sortedItems = items.Where(item => item.ParcelType == ParcelType.Small && item.UsedInDiscount == false).OrderByDescending(item => item.Total).ToList();
            int count = sortedItems.Count / 4;

            for (int index = 0; index < count * 4; index++)
            {
                if ((index + 1) % 4 == 0)
                {
                    sortedItems[index].Discount = -sortedItems[index].Total;
                }

                sortedItems[index].UsedInDiscount = true;
            }
        }
    }
}
