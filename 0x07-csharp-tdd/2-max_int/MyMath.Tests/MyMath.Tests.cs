using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    /// <summary>Contains unittests for Op().</summary>
    [TestFixture]
    public class MaxTests
    {
        /// <summary>Tests Operations.Max() for an ascending list.</summary>
        [Test]
        public void MaxAscend()
        {
            var lst = new List<int>{1, 2, 3, 4, 5};
            Assert.AreEqual(5, Operations.Max(lst));
        }

        /// <summary>Tests Operations.Max() for a descending list.</summary>
        [Test]
        public void MaxDescend()
        {
            var lst = new List<int>{3, 2, 1, 0, -1};
            Assert.AreEqual(3, Operations.Max(lst));
        }

        /// <summary>Tests Operations.Max() for a random, negative list.</summary>
        [Test]
        public void MaxNeg()
        {
            var lst = new List<int>{-3, -5, -1, -4};
            Assert.AreEqual(-1, Operations.Max(lst));
        }

        /// <summary>Tests Operations.Max() for an empty list.</summary>
        [Test]
        public void MaxEmpty()
        {
            var lst = new List<int>{};
            Assert.AreEqual(0, Operations.Max(lst));
        }
    }
}