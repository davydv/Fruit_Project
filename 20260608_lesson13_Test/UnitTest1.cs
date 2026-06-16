using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace _20260608_lesson13_Test
{

    [TestClass]
    public class FruitTests
    {
        [TestMethod]
        public void FruitConstructor_ShouldSetNameAndColor()
        {
            Fruit fruit = new Fruit("Apple", "red");

            Assert.AreEqual("Apple", fruit.Name);
            Assert.AreEqual("red", fruit.Color);
        }

        [TestMethod]
        public void FruitToString_ShouldReturnCorrectString()
        {
            Fruit fruit = new Fruit("Banana", "yellow");

            string result = fruit.ToString();

            Assert.AreEqual("Fruit: Banana, Color: yellow", result);
        }

        [TestMethod]
        public void CitrusConstructor_ShouldSetAllFields()
        {
            Citrus citrus = new Citrus("Lemon", "yellow", 0.053);

            Assert.AreEqual("Lemon", citrus.Name);
            Assert.AreEqual("yellow", citrus.Color);
            Assert.AreEqual(0.053, citrus.VitaminC);
        }

        [TestMethod]
        public void CitrusToString_ShouldReturnCorrectString()
        {
            Citrus citrus = new Citrus("Orange", "orange", 0.045);

            string result = citrus.ToString();

            Assert.AreEqual("Citrus: Orange, Color: orange, Vitamin C: 0,045 g", result);
        }
    }
}
