using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Sale sale)
        {
            Console.WriteLine(sale.GameName + " oyununda " + campaign.CampanignName + " kapmanyası başladı %" + campaign.CampaignPercent + " indirim!!");
        }

        public void Add(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Delete(Campaign campaign,Sale sale)
        {
            Console.WriteLine(sale.GameName + " oyununda " + campaign.CampanignName + " kampanyası bitti.");
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign,Sale sale)
        {
            Console.WriteLine(sale.GameName + " oyununda kampanya güncellendi!!");
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
