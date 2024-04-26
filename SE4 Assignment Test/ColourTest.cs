using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid Colour Parameters
    /// </summary>
    [TestClass]
    public class ColourTest
    {
        /// <summary>
        /// Test for Invalid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("COLOUR", "green, blue")]
        [DataRow("COLOUR", "50")]
        [DataRow("COLOUR", "abc")]
        public void TestInvalidColourParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Colour colour = new Colour(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Invalid Colour name "))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid Data - Not a known colour "))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid Number of Parmeters"))
                    {
                        return;
                    }
                }
                else
                {
                    Assert.Fail("No exception was thrown");
                }
            }


        }

        /// <summary>
        /// Test for Valid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked</param>
        [DataTestMethod]
        [DataRow("COLOUR", "RED")]
        [DataRow("COLOUR", "REDGREEN")]
        [DataRow("COLOUR", "BLUEYELLOW")]
        public void TestValidColourParameters(string shapeCommand, string parameters)
        {

            try
            {
                string[] param = parameters.Split(' ');
                Colour colour = new Colour(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
