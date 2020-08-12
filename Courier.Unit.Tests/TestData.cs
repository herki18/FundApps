using System.Collections.Generic;
using Courier.Data;

namespace Courier.Unit.Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> OneParcel()
        {
            yield return new object[]
            {
                false,
                new List<Parcel> { new Parcel(1, 9, 2) },
                new Order()
                {
                    Total = 5,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 5,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3},
                                { Constants.Weight, 2 }
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                false,
                new List<Parcel> { new Parcel(1, 15, 4) },
                new Order()
                {
                    Total = 10,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 10,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 2 }
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                false,
                new List<Parcel> { new Parcel(2, 65, 7) },
                new Order()
                {
                    Total = 17,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Large,
                            Total = 17,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 15 },
                                { Constants.Weight, 2 }
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                false,
                new List<Parcel> { new Parcel(3, 110, 11) },
                new Order()
                {
                    Total = 27,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.XL,
                            Total = 27,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 25 },
                                { Constants.Weight, 2 }
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                false,
                new List<Parcel> { new Parcel(3, 110, 55) },
                new Order()
                {
                    Total = 80,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Heavy,
                            Total = 80,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 25 },
                                { Constants.Weight, 55 }
                            }
                        }
                    }
                }
            };
        }

        public static IEnumerable<object[]> MultipleParcels()
        {
            yield return new object[]
            {
                false,
                new List<Parcel> { new Parcel(4, 9, 2), new Parcel(5, 15, 4) },
                new Order()
                {
                    Total = 15,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 5,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 2 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 10,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 2 }
                            }
                        }
                    }
                }
            };
        }

        public static IEnumerable<object[]> MultipleParcelsWithFastShipping()
        {
            yield return new object[]
            {
                true,
                new List<Parcel> { new Parcel(4, 9, 2), new Parcel(5, 15, 5) },
                new Order()
                {
                    Total = 34,
                    FastDelivery = 17,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 5,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 2 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 12,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 4 }
                            }
                        }
                    }
                }
            };
        }
    }
}
