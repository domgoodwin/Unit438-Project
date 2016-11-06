using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit438StockInformation;

namespace Unit438Test
{
    [TestClass]
    public class StockInformationTest
    {
        [TestMethod]
        public void Ctor_BasicInput()
        {
            // Tests basic constructor inpu
            // Arrange

            // Act
            StockInformation stockInformation = new StockInformation(1111, "ValidPassword", "AAA");

            // Assert
            // If built successfully no exception raised
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Ctor_UserID_OverLimit()
        {
            // Testing constructor userID being over the limit of 9999
            // Arrange
            int userID = 10000;
            string expectedCompanyName = "Not allowed";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(userID, "ValidPassword", "AAA");
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);
        }

        [TestMethod]
        public void Ctor_UserID_UnderBound()
        {
            // Testing constructor userID being over the limit of 9999
            // Arrange
            int userID = 0;
            string expectedCompanyName = "Not allowed";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(userID, "ValidPassword", "AAA");
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);
        }


        [TestMethod]
        public void Ctor_UserID_Valid()
        {
            // Testing constructor userID being under the limit of 9999
            // Arrange
            int userID = 1111;
            string expectedCompanyName = "A Company";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(userID, "ValidPassword", "AAA");
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);
        }

        [TestMethod]
        public void Ctor_Password_Under8Char()
        {
            // Testing constructor password being under 8 char
            // Arrange
            string password = "AmShort";
            string expectedCompanyName = "Not allowed";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(10, password, "AAA");
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);
        }

        [TestMethod]
        public void Ctor_Password_Valid()
        {
            // Testing a valid password over or equal 8 char
            // Arrange
            string password = "ValidPassword";
            string expectedCompanyName = "A Company";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(1111, password, "AAA");
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);        
        }
        [TestMethod]
        public void Ctor_UserIDPassword_Valid()
        {
            // Testing a valid password over or equal 8 char
            // Arrange
            int userID = 1111;
            string password = "ValidPassword";
            string expectedCompanyName = "A Company";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(userID, password, "AAA");
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);
        }
        [TestMethod]
        public void Ctor_UserIDPassword_Invalid()
        {
            // Testing a valid password over or equal 8 char
            // Arrange
            int userID = 1111;
            string password = "InvalidPassword";
            string expectedCompanyName = "Not allowed";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(userID, password, "AAA");
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Ctor_Symbol_InvalidExceptionRaised()
        {
            // Testing an invalid symbol non alphanumeric 
            // Arrange
            string symbol = "N_T";

            // Act
            StockInformation stockInformation = new StockInformation(10, "ValidPassword", symbol);

            // Assert
            // Expecting an exception raised, done in tags

        }

        [TestMethod]
        public void Ctor_Symbol_ValidNoException()
        {
            // Testing constructor userID being over the limit of 9999
            // Arrange
            string symbol = "AAA";

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);

            // Assert
            // No exception raised so:
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Ctor_WS_InvalidInfo()
        {
            // Testing valid symbol but doesn't exist in web service so exception raised
            // Arrange
            string symbol = "AAAA";

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);

            // Assert
            // Exception should be raised
        }

        [TestMethod]
        public void Ctor_Available_Info()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA";
            bool expectedAvailable = true;
            bool actualAvailavle;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualAvailavle = stockInformation.Available;

            // Assert
            Assert.AreEqual(expectedAvailable, actualAvailavle);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Ctor_Available_NoInfo()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAAA";
            bool expectedAvailable = false;
            bool actualAvailavle;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualAvailavle = stockInformation.Available;

            // Assert
            Assert.AreEqual(expectedAvailable, actualAvailavle);
        }
        [TestMethod]
        public void Ctor_Exists_Known()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA";
            bool expectedExist = true;
            bool actualExist;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualExist = stockInformation.Exists;

            // Assert
            Assert.AreEqual(expectedExist, actualExist);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Ctor_Exists_NotKnown()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA_A";
            bool expectedExist = false;
            bool actualExist;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualExist = stockInformation.Exists;

            // Assert
            Assert.AreEqual(expectedExist, actualExist);
        }
        [TestMethod]
        public void Ctor_Symbol_Exists_CompanyName()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA";
            string expectedCompanyName = "A Company";
            string actualCompanyName;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualCompanyName = stockInformation.CompanyName;

            // Assert
            Assert.AreEqual(expectedCompanyName, actualCompanyName);
        }

        [TestMethod]
        public void Ctor_Symbol_Exists_CurrentPrice()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA";
            int expectedCurrentPrice = 100;
            int actualCurrentPrice;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualCurrentPrice = stockInformation.CurrentPrice;

            // Assert
            Assert.AreEqual(expectedCurrentPrice, actualCurrentPrice);
        }
        [TestMethod]
        public void Ctor_Symbol_Exists_NumberOutstanding()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA";
            int expectedNumOutstanding = 50;
            int actualNumOutstanding;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualNumOutstanding = stockInformation.NumberOfSharesOutstanding;

            // Assert
            Assert.AreEqual(expectedNumOutstanding, actualNumOutstanding);
        }

        [TestMethod]
        public void Ctor_Symbol_Exists_MarketCapitalisation()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA";
            int actualMarketCap;
            int expectedMarketCap;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualMarketCap = stockInformation.MarketCapitilisationInMillions;
            expectedMarketCap = stockInformation.CurrentPrice * stockInformation.NumberOfSharesOutstanding;

            // Assert
            Assert.AreEqual(expectedMarketCap, actualMarketCap);
        }
        [TestMethod]
        public void ToString_Valid()
        {
            // Testing valid symbol, exists in the web service so company name should be set
            // Arrange
            string symbol = "AAA";
            string expectedString = "A Company [AAA] 100";
            string actualString;

            // Act
            StockInformation stockInformation = new StockInformation(9999, "ValidPassword", symbol);
            actualString = stockInformation.ToString();

            // Assert
            Assert.AreEqual(expectedString, actualString);
        }


    }
}
