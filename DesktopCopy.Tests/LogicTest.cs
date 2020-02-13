using System;
using DesktopCopy1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopCopy1.Tests
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var Settings = new Settings();
            
            for (var x = 1; x < 10; x++)
            {
                var setting = new Setting();
                Settings.Setting[x].ID = "name" + x;
                Settings.Setting[x].IsChecked = true;
                Settings.Setting.Add(setting);
            }
            Settings.Save(Settings, "File.xml");

            var Load = Settings.Load<Settings>("File.xml");
            
            Assert.AreEqual(Settings.Setting.Count, Load.Setting.Count);
            
            //Assert.AreEqual(Load[0].Count, Load[0].Count);
        }
    }
}
