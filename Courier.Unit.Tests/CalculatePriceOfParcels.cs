using System.Collections.Generic;
using Courier.Data;
using Xunit;

namespace Courier.Unit.Tests
{
    public class CalculatePriceOfParcels
    {
        [Theory]
        [MemberData(nameof(TestData.OneParcel), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.MultipleParcels), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.MultipleParcelsWithFastShipping), MemberType = typeof(TestData))]
        public void Given_Order_Should_Return_Correct_Calculated_Prices(bool fastDelivery, List<Parcel> parcels, Order order)
        {
            var process = new Process();

            var orderResult = process.Calculate(parcels, fastDelivery);

            Compare(orderResult, order);
        }

        private void Compare(Order calculated, Order expected)
        {
            Assert.Equal(expected.Total, calculated.Total);
            Assert.Equal(expected.FastDelivery, calculated.FastDelivery);
            Assert.Equal(expected.Items.Count, calculated.Items.Count);
            

            for (int index = 0; index < expected.Items.Count; index++)
            {
                Assert.Equal(expected.Items[index].Total, calculated.Items[index].Total);
                Assert.Equal(expected.Items[index].Costs.Count, calculated.Items[index].Costs.Count);
                Assert.Equal(expected.Items[index].ParcelType, calculated.Items[index].ParcelType);

                foreach (var expectedCost in expected.Items[index].Costs)
                {
                    Assert.True(calculated.Items[index].Costs.ContainsKey(expectedCost.Key));
                    var cost = calculated.Items[index].Costs[expectedCost.Key];

                    Assert.Equal(expectedCost.Value, cost);
                }
            }
        }
    }
}
