using System;
using System.Collections.Generic;
using System.Linq;
using Courier.Data;
using Courier.Discounts;
using Courier.Rules;

namespace Courier
{
    public class Process
    {
        private List<IRule> _rules;
        private List<IDiscount> _discounts;

        public Process()
        {
            _rules = new List<IRule>();
            _rules.Add(new SizeRule());
            _rules.Add(new WeightRule());

            _discounts = new List<IDiscount>();
            _discounts.Add(new SmallDiscount());
            _discounts.Add(new MediumDiscount());
            _discounts.Add(new MixedDiscount());
        }

        public Order Calculate(List<Parcel> parcels, bool fastDelivery)
        {
            if(parcels == null || parcels.Count == 0)
            {
                throw new ArgumentNullException();
            }

            var order = new Order();
            foreach (var parcel in parcels)
            {
                var item = new Item();

                foreach (var rule in _rules)
                {
                    rule.Apply(parcel, item);
                }

                order.Total += item.Total;
                order.Items.Add(item);
            }

            foreach (var discount in _discounts)
            {
                discount.Apply(order.Items);
            }

            order.Total = order.Items.Sum(x => x.Total);
            order.Total += order.Items.Sum(x => x.Discount);

            if (fastDelivery)
            {
                order.FastDelivery = order.Total;
                order.Total = order.Total * 2;
            }

            return order;
        }
    }
}
