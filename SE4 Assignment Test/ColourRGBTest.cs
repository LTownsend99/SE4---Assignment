using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class ColourRGBTest
    {
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

        [TestMethod]
        public void TestValidColourRGBParameters()
        {
            string parameters = "COLOUR 173 216 230";

            shapeFactory shapeFactory = new shapeFactory();

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
