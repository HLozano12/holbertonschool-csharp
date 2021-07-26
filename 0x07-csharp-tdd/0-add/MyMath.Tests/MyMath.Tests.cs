using NUnit.Framework;
using MyMath;
using System;

namespace MyMath.Tests
{
	/// <summary> test for .Add() method</summary>
    [TestFixture]
	public class AddTests
    {
		/// <summary> Test Operations.Add() 2 pos ints </summary> 
        [Test]
        public void Sum_Positive()
        {
            Assert.AreEqual(6, Operations.Add(2, 4));
        }

		/// <summary> Test Oppoerations.Add() method with pos & neg ints </summary>
		[Test]
		public void Add_Pos_Neg()
		{
			Assert.AreEqual(2, Operations.Add(-2, 4));
		}
    }
}