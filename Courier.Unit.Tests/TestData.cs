using System.Collections.Generic;
using Courier.Data;

namespace Courier.Unit.Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> Data()
        {
            yield return new object[]
            {
                new List<Parcel> { new Parcel(1, 9) },
                new Order()
                {
                    Total = 3,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Total = 3,
                            Costs = new List<Cost>()
                            {
                                new Cost() {Name = "Size", Price = 3}
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                new List<Parcel> { new Parcel(1, 15) },
                new Order()
                {
                    Total = 8,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Total = 8,
                            Costs = new List<Cost>()
                            {
                                new Cost() {Name = "Size", Price = 8}
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                new List<Parcel> { new Parcel(2, 65) },
                new Order()
                {
                    Total = 15,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Total = 15,
                            Costs = new List<Cost>()
                            {
                                new Cost() {Name = "Size", Price = 15}
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                new List<Parcel> { new Parcel(3, 110) },
                new Order()
                {
                    Total = 25,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Total = 25,
                            Costs = new List<Cost>()
                            {
                                new Cost() {Name = "Size", Price = 25}
                            }
                        }
                    }
                }
            };

            yield return new object[]
            {
                new List<Parcel> { new Parcel(4, 9), new Parcel(5, 15) }, 
                new Order()
                {
                    Total = 11,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Total = 3,
                            Costs = new List<Cost>()
                            {
                                new Cost() {Name = "Size", Price = 3}
                            }
                        },
                        new Item()
                        {
                            Total = 8,
                            Costs = new List<Cost>()
                            {
                                new Cost() {Name = "Size", Price = 8}
                            }
                        }
                    }
                }
            };
        }
    }
}
