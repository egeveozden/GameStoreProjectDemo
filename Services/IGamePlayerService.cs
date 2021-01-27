using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    interface IGamePlayerService
    {
        void Add(GamePlayer player);
        void Update(GamePlayer player);
        void Delete(GamePlayer player);

    }
}
