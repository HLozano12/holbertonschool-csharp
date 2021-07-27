using NUnit.Framework;
using System;

namespace MyMath.Tests
{
	[TestFixture]
	/// <summary> All unittest for class method </summary>
    public class MatrixTests
    {
       
        [Test]
        /// <summary>Test to determine outcome if num is equal to 0</summary>
        public void NumEqulToZero()
        {
            // Assign
            int num = 0;
            int[,] tempMat = new int[,] {{2, 4}, {6, 8}};
            int[,] div;
            // Act
            div = Matrix.Divide(tempMat, num);
            // Assert
            Assert.IsNull(div);
        }
		[Test]
        ///<summary>Test function with division by 0.</summary>
        public void Divide_0()
        {
            try
            {
                int[,] soulution = Matrix.Divide(testMatrix, 0);
            }
            catch(Exception e)
            {
                Assert.AreEqual(e, "Num cannot be 0");
            }
        }
    }
}