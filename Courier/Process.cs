using System;
using System.Collections.Generic;
using Courier.Data;
using Courier.Rules;

namespace Courier
{
    public class Process
    {
        private List<IRule> _rules;

        public Process()
        {
            _rules = new List<IRule>();
            _rules.Add(new SizeRule());
            _rules.Add(new WeightRule());
        }

        public Order Calculate(List<Parcel> parcels, bool fastDelivery)
        {
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

            if (fastDelivery)
            {
                order.FastDelivery = order.Total;
                order.Total = order.Total * 2;
            }

            return order;
        }
    }
}
