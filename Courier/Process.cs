using System;
using System.Collections.Generic;
using Courier.Data;

namespace Courier
{
    public class Process
    {
        public Order Calculate(List<Parcel> parcels)
        {
            var order = new Order();
            foreach (var parcel in parcels)
            {
                var item = new Item();
                var cost = new Cost();
                if (parcel.Size < 10)
                {
                    cost.Price = 3;
                    cost.Name = "Size";

                    item.Total += 3;
                    order.Total += 3;
                }else if (parcel.Size < 50)
                {
                    cost.Price = 8;
                    cost.Name = "Size";

                    item.Total += 8;
                    order.Total += 8;
                }else if (parcel.Size < 100)
                {
                    cost.Price = 15;
                    cost.Name = "Size";

                    item.Total += 15;
                    order.Total += 15;
                }
                else
                {
                    cost.Price = 25;
                    cost.Name = "Size";

                    item.Total += 25;
                    order.Total += 25;
                }

                
                item.Costs.Add(cost);

                order.Items.Add(item);
            }

            return order;
        }
    }
}
