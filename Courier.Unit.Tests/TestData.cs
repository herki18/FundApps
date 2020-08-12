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

        public static IEnumerable<object[]> DiscountedMultipleParcelsWithFastShipping()
        {
            yield return new object[]
            {
                true,
                new List<Parcel> { new Parcel(1, 40, 2), new Parcel(2, 45, 4), new Parcel(3, 45, 2),
                                    new Parcel(4, 49, 4), new Parcel(5, 45, 2), new Parcel(6, 45, 4) },
                new Order()
                {
                    Total = 72,
                    FastDelivery = 36,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 8,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 10,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 2 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 8,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 10,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 2 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 8,
                            Discount = -8,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 10,
                            Discount = -10,
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
                true,
                new List<Parcel> { new Parcel(1, 9, 1), new Parcel(2, 9, 1), new Parcel(3, 9, 1),
                                    new Parcel(4, 9, 4), new Parcel(5, 45, 2), new Parcel(6, 45, 4) },
                new Order()
                {
                    Total = 66,
                    FastDelivery = 33,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 3,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 3,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 3,
                            Discount = -3,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 9,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 6 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 8,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 10,
                            Discount = 0,
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
                true,
                new List<Parcel> { new Parcel(1, 9, 1), new Parcel(2, 9, 1), new Parcel(3, 9, 1),
                                    new Parcel(4, 100, 4), new Parcel(5, 45, 2), new Parcel(6, 45, 4) },
                new Order()
                {
                    Total = 98,
                    FastDelivery = 49,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 3,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 3,
                            Discount = -3,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Small,
                            Total = 3,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 3 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.XL,
                            Total = 25,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 25 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 8,
                            Discount = 0,
                            Costs = new Dictionary<string, float>()
                            {
                                { Constants.Size, 8 },
                                { Constants.Weight, 0 }
                            }
                        },
                        new Item()
                        {
                            ParcelType = ParcelType.Medium,
                            Total = 10,
                            Discount = 0,
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
    }
}
