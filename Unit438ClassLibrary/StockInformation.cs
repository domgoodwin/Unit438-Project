using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Unit438StockInformation
{
    public class StockInformation
    {
        public string Symbol { get; private set; }
        public bool Available { get; private set; }
        public bool Exists { get; private set; }
        public string CompanyName { get; private set; }
        public int CurrentPrice { get; private set; }
        public int NumberOfSharesOutstanding { get; private set; }
        public int MarketCapitilisationInMillions
        {
            get
            {
                return CalculateMarketCapitalisation();
            }
        }

        public StockInformation(int userID, string password, string symbol)
        {
            // user id = int between 1-9999
            // password = upper, lower, symbols
            // symbol only alphanumeric

            // Check userID + password
            if ((userID > 0 && userID < 10000) && password.Length >= 8)
            {
                // Check stock symbol correctly formatted
                string pattern = "^[A-Za-z0-9]*$";
                if (Regex.IsMatch(symbol, pattern))
                {
                    // If acceptable pass to GetStockInfo (return csv list)
                    WebService stockWebService = new WebService();
                    // Authenticate with web service
                    if (stockWebService.Authenticate(userID, password))
                    {
                        string companyInfo = stockWebService.GetStockInfo(symbol);
                        if (companyInfo != "No such symbol")
                        {
                            Available = true;
                            Exists = true;
                            CompanyName = companyInfo.Split(',')[1];
                            Symbol = symbol;
                            int curPrice;
                            Int32.TryParse(companyInfo.Split(',')[2], out curPrice);
                            CurrentPrice = curPrice;
                            int numOutstanding;
                            Int32.TryParse(companyInfo.Split(',')[3], out numOutstanding);
                            NumberOfSharesOutstanding = numOutstanding;
                        }
                        else
                        {
                            Available = false;
                            throw new Exception("No information found from symbol " + symbol);
                        }
                    }
                    else
                    {                        
                        CompanyName = "Not allowed";
                    }                
                }
                else
                {
                    Exists = false;
                    throw new Exception("Invalid symbol");
                }
            }
            else
            {
                CompanyName = "Not allowed";
            }

            


           
        }

        public override string ToString()
        {
            return String.Format("{0} [{1}] {2}", CompanyName, Symbol, CurrentPrice.ToString());
        }

        private int CalculateMarketCapitalisation()
        {
            return this.CurrentPrice * this.NumberOfSharesOutstanding;
        }
    }
}