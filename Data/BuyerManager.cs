namespace HemSoft.TCE.Data
{
    using System.Collections.Generic;

    public class BuyerManager
    {
        public static List<BuyerMaster> GetAllBuyerMasters()
        {
            var buyersAI = GetBuyerMasters(Config.BuyerMasterAIUrl);
            var buyersJR = GetBuyerMasters(Config.BuyerMasterJRUrl);
            var buyersSZ = GetBuyerMasters(Config.BuyerMasterSZUrl);
            var buyers = new List<BuyerMaster>();
            buyers.AddRange(buyersAI);
            buyers.AddRange(buyersJR);
            buyers.AddRange(buyersSZ);
            return buyers;
        }

        public static List<BuyerMaster> GetBuyerMasters(string url)
        {
            string offset = null;
            bool done = false;
            var buyers = new List<BuyerMaster>();
            BuyerMaster buyer = null;

            while (!done)
            {
                var apiBuyers = BaseManager.GetPage(url, offset);
                foreach (var r in apiBuyers.records)
                {
                    buyer = new BuyerMaster();
                    buyer.AirTableKey = r.id;
                    buyer.Name = r.fields["Name"];
                    buyers.Add(buyer);
                }

                if (apiBuyers.offset == null)
                {
                    done = true;
                }
                else
                {
                    offset = apiBuyers.offset;
                }
            }

            return buyers;
        }
    }
}
