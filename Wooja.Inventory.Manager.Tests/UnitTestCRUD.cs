using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wooja_Inventory_Manager.Models;

namespace Wooja.Inventory.Manager.Tests
{
    [TestClass]
    public class UnitTestCRUD
    {
        [TestMethod]
        [HttpGet]
        public void CanCreatingNewDeviceWithoutProperties()
        {

            // ARRANGE
            Item Item = new Item();

            // ACT
           // int result = calculator.Add("1");

            // ASSERT
          //  Assert.AreEqual(1, result);
        }

        [TestMethod]
        [HttpPost]
        public void CanCreatingNewDeviceWithProperties()
        {
            Item Item = new Item() { Name = "Fahrzeugname", Brand="MAN" } ;

        }

        
        
    }
}
