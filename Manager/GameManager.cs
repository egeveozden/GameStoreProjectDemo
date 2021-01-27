using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Id:"+game.GameId);
            Console.WriteLine("Game Name:"+game.GameName);
            Console.WriteLine("Game Price:"+game.GamePrice);
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
