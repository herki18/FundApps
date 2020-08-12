using Courier.Data;

namespace Courier.Rules
{
    public class SizeRule : IRule
    {
        public Item Apply(Parcel parcel, Item item)
        {
            var cost = 0f;
            if (parcel.Size < 10)
            {
                cost = 3;
                item.ParcelType = ParcelType.Small;
            }
            else if (parcel.Size < 50)
            {
                cost = 8;
                item.ParcelType = ParcelType.Medium;
            }
            else if (parcel.Size < 100)
            {
                cost = 15;
                item.ParcelType = ParcelType.Large;
            }
            else
            {
                cost = 25;
                item.ParcelType = ParcelType.XL;
            }

            item.Costs.Add(Constants.Size, cost);
            item.Total += cost;

            return item;
        }
    }
}
