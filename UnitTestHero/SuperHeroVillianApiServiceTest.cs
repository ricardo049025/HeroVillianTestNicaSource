using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.Main.Services;
using System.Configuration;
using Domain.Domain.Enums;
using UnitTestHero.Utility.Consts;
namespace UnitTestHero
{
    [TestClass]
    public class SuperHeroVillianApiServiceTest
    {
        #region Properties      
            private SuperHeroVillianApiService obj;
        #endregion

        #region Constructor
        public SuperHeroVillianApiServiceTest()
        {            
            obj = new SuperHeroVillianApiService(Config.endpoint);
        }
        #endregion

        #region Test of the Class
        [TestMethod]
        public void TestgetByName()
        {
            var dto = obj.getByName("batman");
            Assert.IsFalse(dto.response == StatusEnum.error.ToString());
        }

        [TestMethod]
        public void TestgetById()
        {
            var dto = obj.getById(70);
            Assert.IsFalse(dto.response == StatusEnum.error.ToString());
        }

        #endregion
    }
}
