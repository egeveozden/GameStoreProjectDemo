using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class GamePlayerManager : IGamePlayerService
    {
        public void Add(GamePlayer player)
        {
            Console.WriteLine("Game Player Id:"+player.Id);
            Console.WriteLine("Game Player Name:" + player.Name + " " + player.Surname);
            Console.WriteLine("-------------------------------------------------------");
        }

        public void Delete(GamePlayer player)
        {
            Console.WriteLine("Game Player Id:" + player.Id);
            Console.WriteLine("Game Player Name:" + player.Name + " " + player.Surname);
            Console.WriteLine("Game Player Birthday:"+player.DateofBirth);
            Console.WriteLine("-------------------------------------------------------");
        }

        public void Update(GamePlayer player)
        {
            Console.WriteLine("Game Player Id:" + player.Id);
            Console.WriteLine("Game Player Name:" + player.Name + " " + player.Surname);
            Console.WriteLine("Game Player Birthday:" + player.DateofBirth);
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
