using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit438StockInformation;

namespace Unit438Test
{
    [TestClass]
    public class WebServiceTest
    {
        // Not for project, for personal use


        //[TestMethod]
        //public void Auth_ValidAuthenticatedUser()
        //{
        //    // Testing valid authentication
        //    // Arrange
        //    int userID = 1111;
        //    string password = "ValidPassword";
        //    bool expectedAuthenticate = true;
        //    bool actualAuthenticate;

        //    // Act
        //    WebService webService = new WebService();
        //    actualAuthenticate = webService.Authenticate(userID, password);

        //    // Assert
        //    Assert.AreEqual(expectedAuthenticate, actualAuthenticate);
        //}
        //[TestMethod]
        //public void Auth_InvalidAuthenticatedUser_PasswordWrong()
        //{
        //    // Testing invalid authentication with invalid password
        //    // Arrange
        //    int userID = 1111;
        //    string password = "InvalidPassword";
        //    bool expectedAuthenticate = false;
        //    bool actualAuthenticate;

        //    // Act
        //    WebService webService = new WebService();
        //    actualAuthenticate = webService.Authenticate(userID, password);

        //    // Assert
        //    Assert.AreEqual(expectedAuthenticate, actualAuthenticate);
        //}

        //[TestMethod]
        //public void Auth_InvalidAuthenticatedUser_UserIDWrong()
        //{
        //    // Testing invalid authentication with invalid userid
        //    // Arrange
        //    int userID = 11111;
        //    string password = "ValidPassword";
        //    bool expectedAuthenticate = false;
        //    bool actualAuthenticate;

        //    // Act
        //    WebService webService = new WebService();
        //    actualAuthenticate = webService.Authenticate(userID, password);

        //    // Assert
        //    Assert.AreEqual(expectedAuthenticate, actualAuthenticate);
        //}

        //[TestMethod]
        //public void GetStock_ValidStockSymbol_ValidAuthAndStock()
        //{
        //    // Testing valid getstockinfo method
        //    // Arrange
        //    // Auth vars
        //    int userID = 1111;
        //    string password = "ValidPassword";

        //    // Stock vars
        //    string stockSymbol = "AAA";
        //    string expectedInfo = "AAA,A Company,100,50";
        //    string actualInfo;

        //    // Act
        //    WebService webService = new WebService();
        //    webService.Authenticate(userID, password);
        //    actualInfo = webService.GetStockInfo(stockSymbol);

        //    // Assert
        //    Assert.AreEqual(expectedInfo, actualInfo);
        //}
        //[TestMethod]
        //public void GetStock_InvalidStockSymbol_ValidAuth()
        //{
        //    // Testing invalid stock symbol on getstockinfo
        //    // Arrange
        //    // Auth vars
        //    int userID = 1111;
        //    string password = "ValidPassword";

        //    // Stock vars
        //    string stockSymbol = "ZZZ";
        //    string expectedInfo = "No such symbol";
        //    string actualInfo;

        //    // Act
        //    WebService webService = new WebService();
        //    webService.Authenticate(userID, password);
        //    actualInfo = webService.GetStockInfo(stockSymbol);

        //    // Assert
        //    Assert.AreEqual(expectedInfo, actualInfo);
        //}


    }
}
