using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PlantSalesData;

namespace PlantSalesDataLibraryTest
{
    [TestClass]
    public class UserDBTestClass
    {
        [TestMethod]
        public void VerifyCheckIfUserNameExists_ReturnsTrue_WhenPassedExistingUser()
        {
            // Arrange
            bool expected = true;
            bool actual;
            string username = "user1";

            // Act

            if (UserDB.CheckIfUsernameExists(username)) actual = true;
            else actual = false;


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckUserLogin_ReturnsNull_WhenPassedIncorrectUsernameAndPassword()
        {
            // Arrange
            User actual;
            string username = "user";
            string password = "password";

            // Act
            actual = UserDB.CheckUserLogin(username, password);

            // Assert
            Assert.IsNull(actual);
        }

    }
}
