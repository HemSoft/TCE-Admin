namespace HemSoft.TCE
{
    using System.Configuration;

    public static class Config
    {
        public static string AirtableKey = ConfigurationManager.AppSettings["AirtableKey"];

        public static string BuyerMasterAIUrl = ConfigurationManager.AppSettings["BuyerMasterAIUrl"];
        public static string BuyerMasterJRUrl = ConfigurationManager.AppSettings["BuyerMasterJRUrl"];
        public static string BuyerMasterSZUrl = ConfigurationManager.AppSettings["BuyerMasterSZUrl"];

        public static string LatestSalesBuyers = ConfigurationManager.AppSettings["LatestSalesBuyers"];
        public static string LatestSalesBuyersGetOne = ConfigurationManager.AppSettings["LatestSalesBuyersGetOne"];
        public static string LatestSalesVouches = ConfigurationManager.AppSettings["LatestSalesVouches"];
    }
}
