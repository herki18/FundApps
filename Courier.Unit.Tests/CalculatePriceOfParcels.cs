using System.Collections.Generic;
using Courier.Data;
using Xunit;

namespace Courier.Unit.Tests
{
    public class CalculatePriceOfParcels
    {
        [Theory]
        [MemberData(nameof(TestData.Data), MemberType = typeof(TestData))]
        public void Given_Order_Should_Return_Correct_Calculated_Prices(List<Parcel> parcels, Order order)
        {
            var process = new Process();

            var orderResult = process.Calculate(parcels);

            Compare(orderResult, order);
        }

        private void Compare(Order calculated, Order expected)
        {
            Assert.Equal(expected.Total, calculated.Total);
            Assert.Equal(expected.Items.Count, calculated.Items.Count);

            for (int index = 0; index < expected.Items.Count; index++)
            {
                Assert.Equal(expected.Items[index].Total, calculated.Items[index].Total);
                Assert.Equal(expected.Items[index].Costs.Count, calculated.Items[index].Costs.Count);

                for (int j = 0; j < expected.Items[index].Costs.Count; j++)
                {
                    Assert.Equal(expected.Items[index].Costs[j].Name, calculated.Items[index].Costs[j].Name);
                    Assert.Equal(expected.Items[index].Costs[j].Price, calculated.Items[index].Costs[j].Price);
                }
            }
        }
    }
}
