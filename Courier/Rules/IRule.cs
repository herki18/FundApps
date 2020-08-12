using Courier.Data;

namespace Courier.Rules
{
    interface IRule
    {
        Item Apply(Parcel parcel, Item item);
    }
}
