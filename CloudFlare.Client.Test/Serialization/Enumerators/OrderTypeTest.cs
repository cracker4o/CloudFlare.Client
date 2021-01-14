﻿using System.Collections.Generic;
using CloudFlare.Client.Enumerators;
using CloudFlare.Client.Test.Helpers;
using FluentAssertions;
using Xunit;

namespace CloudFlare.Client.Test.Serialization.Enumerators
{
    public class OrderTypeTest
    {
        [Fact]
        public void TestSerialization()
        {
            JsonHelper.GetSerializedEnums<OrderType>().Should().BeEquivalentTo(new SortedSet<string> { "asc", "desc" });
        }
    }
}