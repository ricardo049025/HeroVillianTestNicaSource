using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Main.Bussiness;
using Application.Main.Services;
using UnitTestHero.Utility.Consts;
namespace UnitTestHero
{
    [TestClass]
    public class HeroVillianBLTest
    {
        #region
            public HeroVillianBL obj;
            public SuperHeroVillianApiService service;
        #endregion

        #region Constructor
        public HeroVillianBLTest()
        {
            service = new SuperHeroVillianApiService(Config.endpoint);
            obj = new HeroVillianBL(service);
        }
        #endregion

        #region Tests Methods
        [TestMethod]        

        public void TestgetByName()
        {
            var dto = obj.getByName("batman");                
        }
        [TestMethod]
        public void TestgetById()
        {
            var dto = obj.getById(100);
        }

        #endregion
    }
}
