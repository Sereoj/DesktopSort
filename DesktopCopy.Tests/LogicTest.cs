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
                setting.ID = "name" + x;
                setting.IsChecked = true;
                Settings.Add(setting);
            }
            Data.Save(Settings, "File.xml");

            var Load = Data.Load<Settings>("File.xml");
            
            Assert.AreEqual(Load.Count, Settings.Count);
            
            //Assert.AreEqual(Load[0].Count, Load[0].Count);
        }
    }
}
