using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class CampaignManager:ICampaignService
    { 
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Id:" + campaign.CampaignId);
            Console.WriteLine("Campaing Name:" + campaign.CampaignName);
            Console.WriteLine("The Campaign added");
            Console.WriteLine("-------------------------------------------------------");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Id:"+campaign.CampaignId);
            Console.WriteLine("Campaing Name:" + campaign.CampaignName);
            Console.WriteLine("Campaing Discount:"+campaign.CampaignDiscount);
            Console.WriteLine("The Campaign updated");
            Console.WriteLine("-------------------------------------------------------");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Id:"+campaign.CampaignId);
            Console.WriteLine("Campaing Name:"+campaign.CampaignName );
            Console.WriteLine("The Campaign deleted");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
