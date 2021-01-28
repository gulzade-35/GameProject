using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            SaleManager saleManager = new SaleManager();
            CampaignManager campaignManager = new CampaignManager();

            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Gülzade",
                LastName = "Odabaş",
                BirthYear = 1996,
                IdentityNumber = 123456
            });

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Ali";
            gamer2.LastName = "Karaca";
            gamer2.BirthYear = 1985;
            gamer2.IdentityNumber = 123456789;


            Sale sale1 = new Sale();
            sale1.SaleId = 1;
            sale1.GameName = "Sims";
            sale1.Price = 29.99;

            Sale sale2 = new Sale();
            sale2.SaleId = 2;
            sale2.GameName = "PUBG";
            sale2.Price = 49.99;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampanignName = "Yıl sonu indirimi";
            campaign1.CampaignPercent = 50;

            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer2);

            Console.WriteLine("------Satış-------");
            saleManager.Sale(sale2, gamer2);
            saleManager.Sale(sale1, gamer2);

            Console.WriteLine("----Kampanya-------");
            campaignManager.Add(campaign1, sale1);
            campaignManager.Add(campaign1, sale2);

            campaignManager.Delete(campaign1, sale2);

            campaignManager.Update(campaign1,sale1);

        }
    }
}
