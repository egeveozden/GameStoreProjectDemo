using System;

namespace GameProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlayer player1 = new GamePlayer();
            player1.Id = 1;
            player1.Name = "Ege";
            player1.Surname = "Özden";
            player1.DateofBirth = "1998";
           
            GamePlayer player2 = new GamePlayer();
            player2.Id = 2;
            player2.Name = "Hüsnü";
            player2.Surname = "Özden";
            player2.DateofBirth = "1973";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 932;
            campaign1.CampaignName = "Assırı Siyah Cuma";
            campaign1.CampaignDiscount = "%50 Discount";

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 328;
            campaign2.CampaignName = "Bembeyaz Pazartesi";
            campaign2.CampaignDiscount = "%70 Discount";

            Game game1 = new Game();
            game1.GameId = 9133;
            game1.GameName = "Need For Speed Underground 2";
            game1.GamePrice = 100;

            Game game2= new Game();
            game2.GameId = 3142;
            game2.GameName = "Prince Of Persia";
            game2.GamePrice = 200;

             

            IGamePlayerService gameplayerManager = new GamePlayerManager();
            gameplayerManager.Update(player1);
        
            IGameService gameManager = new GameManager();
            gameManager.Add(game1);

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            ILoggerService smsService = new SmsLoggerService();
            ILoggerService databaseService = new DatabaseLoggerService();

            smsService.Log();
            databaseService.Log();
           





        }
    }
}
