using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid Command words
    /// </summary>
    [TestClass]
    public class ShapeFactoryTest
    {
        /// <summary>
        /// Test for Invalid commmand word
        /// </summary>
        [TestMethod]
        public void TestInvalidCommandName()
        {
            string commandName = "SQUARE";

            shapeFactory shapeFactory = new shapeFactory();

            Assert.ThrowsException<Exception>(() => shapeFactory.processCommand(commandName), ("Invalid Command Word " + commandName));

        }

        /// <summary>
        /// Test for Valid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("CIRCLE", "50")] // Valid circle command
        [DataRow("CONCIRCLE", "50")] // Valid Concentriccircle command
        [DataRow("RECTANGLE", "10,20,30,40")] // Valid rectangle command
        [DataRow("TRIANGLE", "3,4")] // Valid triangle command
        [DataRow("MOVETO", "10,5")] // Valid moveTo command
        [DataRow("DRAWTO", "25,30")] // Valid drawTo command
        [DataRow("FILL", "ON")] // Valid fill command
        [DataRow("CLEAR", "")] // Valid clear command
        [DataRow("RESET", "")] // Valid reset command
        [DataRow("COLOURRGB", "216, 173, 230")] // Valid colourRGB command
        [DataRow("COLOUR", "red")] // Valid colour command
        [DataRow("VAR", "a = 100")] // Valid VAR command
        [DataRow("IF", "a == b CIRCLE 100")] // Valid IF command
        [DataRow("WHILE", "5 < 10")] // Valid WHILE command
        [DataRow("ENDIF", "")] // Valid ENDIF command
        [DataRow("ENDWHILE", "")] // Valid ENDWHILE command
        [DataRow("ENDMETHOD", "")] // Valid ENDMETHOD command
        [DataRow("METHOD", "myMethod()")] // Valid METHOD command
        [DataRow("POLYGON", "10,20,30,40,50,60")] // Valid METHOD command
        public void TestValidCommandWord(string shapeCommand, string parameters)
        {

            shapeFactory shapeFactory = new shapeFactory();

            try
            {
                shapeFactory.processCommand(shapeCommand + " " + parameters);

            }
            catch (Exception ex)
            {
                Assert.Fail(" An exception was thrown: " + ex);
            }

        }

    }
}