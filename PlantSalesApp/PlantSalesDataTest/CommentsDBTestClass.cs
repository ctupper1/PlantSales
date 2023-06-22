using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantSalesData;
using System;

namespace PlantSalesDataLibraryTest
{
    [TestClass]
    public class CommentsDBTestClass
    {
        [TestMethod]
        public void TestCommentsDBConnection()
        {
            // Arrange
            bool expected = true;
            bool actual = false;

            // Act
            try
            {
                CommentsDB.GetConnection();
                actual = true;
            }
            catch (Exception)
            {
                actual = false;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}