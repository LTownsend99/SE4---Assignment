using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class ShapeFactoryTest
    {
        [TestMethod]
        public void TestInvalidCommandName()
        {
            string commandName = "SQUARE";

            shapeFactory shapeFactory = new shapeFactory();

            Assert.ThrowsException<Exception>(() => shapeFactory.proccessCommand(commandName), ("Invalid Command Word " + commandName)); 

        }

        [TestMethod]
        public void TestValidCommand()
        {
            string commandName = "CIRCLE 50";
            string[] parameters = commandName.Split(' ').Skip(1).ToArray();
            Circle expected = new Circle(parameters);

            shapeFactory shapeFactory = new shapeFactory();

            Circle actual = (Circle) shapeFactory.proccessCommand(commandName);

            Assert.AreEqual(actual , expected);

        }
    }
}