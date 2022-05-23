using System;
using Medicine;
using NUnit.Framework;


namespace TestProject11
{
    [TestFixture]
    public class CommodityUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var valerian = CreateTestItems();

            Assert.AreEqual("Valerian", valerian.ProductName);
            Assert.AreEqual("123456789", valerian.ItemNumber);
            Assert.AreEqual("10$", valerian.Prise);
            Assert.AreEqual("None", valerian.NumberOfGoods);
            Assert.AreEqual(Medicine.withoutRecipe, valerian.Type);

        }
        [Test]
        public void ToString_Items_ProductNameSpaceItemNumber()
        {
            var valerian = CreateTestItems();
            Assert.AreEqual("Valerian 123456789", valerian.ToString());
        }
        private Stuff CreateTestItems()
        {
            return new Stuff("valerian", "123456789", "10", "None", Medicine.withoutRecipe);
        }
    }
}