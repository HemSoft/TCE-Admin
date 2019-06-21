namespace HemSoft.TCE
{
    public static class Config
    {
        public static string BuyerMasterAIUrl =
            "https://api.airtable.com/v0/appL4wo8iTyBxk9Ck/Loyalty%20Ranks%20%7BA-I%7D?view=Grid%20view";
        public static string BuyerMasterJRUrl =
            "https://api.airtable.com/v0/appdQ0mKmSv8j06JR/Loyalty%20Ranks%20%7BJ-R%7D?view=Grid%20view";
        public static string BuyerMasterSZUrl =
            "https://api.airtable.com/v0/appuvogZoQHSjZVml/Loyalty%20Ranks%20%7BS-Z%7D?view=Grid%20view";

        public static string LatestSalesBuyers =
            "https://api.airtable.com/v0/appotVSmfe0873i8c/Buyers?view=Buyer%20Master";
        public static string LatestSalesBuyersGetOne =
            "https://api.airtable.com/v0/appotVSmfe0873i8c/Buyers/";
        public static string LatestSalesVouches =
            "https://api.airtable.com/v0/appotVSmfe0873i8c/Vouches?view=Master";
    }
}
