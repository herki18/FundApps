using System;
using Courier.Data;

namespace Courier.Rules
{
    public class WeightRule : IRule
    {
        public Item Apply(Parcel parcel, Item item)
        {
            var cost = 0f;

            switch (item.ParcelType)
            {
                case ParcelType.Small:
                {
                    cost = Calculate(parcel.Weight, 1);
                    break;
                }
                case ParcelType.Medium:
                {
                    cost = Calculate(parcel.Weight, 3);
                    break;
                }
                case ParcelType.Large:
                {
                    cost = Calculate(parcel.Weight, 6);
                    break;
                }
                case ParcelType.XL:
                {
                    cost = Calculate(parcel.Weight, 10);
                    break;
                }
            }

            item.Costs.Add(Constants.Weight, cost);
            item.Total += cost;

            return item;
        }

        private float Calculate(float weight, float limit)
        {
            var diff = limit - weight;
            return diff < limit ? Math.Abs(diff) * 2 : 0;
        }
    }
}
