using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid ColourRGB parameters
    /// </summary>
    [TestClass]
    public class ColourRGBTest
    {
        /// <summary>
        /// Test for Invalid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked</param>
        [DataTestMethod]
        [DataRow("COLOURRGB", "-50,120,200")]
        [DataRow("COLOURRGB", "50,-20,150")]
        [DataRow("COLOURRGB", "50,220,350")]
        [DataRow("COLOURRGB", "100,200,-30,20")]
        [DataRow("COLOURRGB", "abc")]
        public void TestInvalidColourRGBParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                ColourRGB colour = new ColourRGB(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Number out the range when Red should be between 0 and 255"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Number out the range when Blue should be between 0 and 255"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Number out the range when Green should be between 0 and 255"))
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
        [TestMethod]
        public void TestValidColourRGBParameters()
        {
            string parameters = "COLOUR 173 216 230";

            try
            {
                string[] param = parameters.Split(' ');
                ColourRGB colour = new ColourRGB(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
