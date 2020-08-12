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
                    cost = Calculate(parcel.Weight, 1, 2);
                    break;
                }
                case ParcelType.Medium:
                {
                    cost = Calculate(parcel.Weight, 3, 2);
                    break;
                }
                case ParcelType.Large:
                {
                    cost = Calculate(parcel.Weight, 6, 2);
                    break;
                }
                case ParcelType.XL:
                {
                    if (parcel.Weight < 50)
                    {
                        cost = Calculate(parcel.Weight, 10, 2);
                    }
                    else
                    {
                        item.ParcelType = ParcelType.Heavy;
                        cost = 50 +  Calculate(parcel.Weight, 50, 1);
                    }
                    
                    break;
                }
            }

            item.Costs.Add(Constants.Weight, cost);
            item.Total += cost;

            return item;
        }

        private float Calculate(float weight, float limit, float cost)
        {
            var diff = limit - weight;
            return weight > limit ? Math.Abs(diff) * cost : 0;
        }
    }
}
