using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit438StockInformation
{
    public class WebService
    {
        public bool Authenticate(int userID, string password)
        {
            // Authenticate the web service
            // Example valid IDs and password, in non stub application would use a DB
            List<int> validUserIDs = new List<int>{ 1111, 2222, 3333, 4444, 5555, 6666, 7777, 8888, 9999 };
            string validPassword = "ValidPassword";

            if(validUserIDs.Contains(userID) && password == validPassword)
            {
                return true;
            }

            return false;
        }

        private List<string> validSymbols = new List<string>{ "AAA", "BBB", "CCC", "DDD", "EEE" };
        private string companyInfo = "A Company,100,50";

        public string GetStockInfo(string symbol)
        {
            // When a valid stock symbol is provided, csv is returned
            if (validSymbols.Contains(symbol))
            {
                return string.Format("{0},{1}", symbol, companyInfo);
            }

            // Return is: stockSymbol, companyName, latestTradingPrice, numberOfSharesOutstanding

            return "No such symbol";
        }
    }
}
