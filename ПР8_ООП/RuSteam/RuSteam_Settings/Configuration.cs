using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using RuSteam_DI;
using RuSteam_Data_Sql;
using RuSteam_BII;

namespace RuSteam_Settings
{
    public class Configuration
    {
        public Container Container { get; }
        public Configuration()
        {
            Container = new Container();
            Setup();
        }
        public virtual void Setup()
        {
            Container.Register<IGame, Game>(Lifestyle.Transient);
            Container.Register<IAccount, Account>(Lifestyle.Transient);
            Container.Register<IShop, Shop>(Lifestyle.Singleton);
            Container.Register<IAccountData<IAccount>, AccountDataSql>(Lifestyle.Singleton);
            Container.Register<IGameData<IGame>, GameDataSql>(Lifestyle.Singleton);
        }
    }
}
