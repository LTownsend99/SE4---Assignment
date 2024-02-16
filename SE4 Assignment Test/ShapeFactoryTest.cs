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

        [DataTestMethod]
        [DataRow("CIRCLE", "50")] // Valid circle command
        [DataRow("RECTANGLE", "10,20,30,40")] // Valid rectangle command
        [DataRow("TRIANGLE", "3,4")] // Valid triangle command
        [DataRow("MOVETO", "10,5")] // Valid moveTo command
        [DataRow("DRAWTO", "25,30")] // Valid drawTo command
        [DataRow("FILL", "ON")] // Valid fill command
        [DataRow("CLEAR", "")] // Valid clear command
        [DataRow("RESET", "")] // Valid reset command
        [DataRow("COLOUR", "216, 173, 230")] // Valid colour command
        public void TestValidCommandWord(string shapeCommand, string parameters)
        {

            shapeFactory shapeFactory = new shapeFactory();

            try
            {
                shapeFactory.proccessCommand(shapeCommand + " " + parameters);

            }
            catch (Exception ex)
            {
                Assert.Fail(" An exception was thrown: " + ex);
            }

        }

    }
}