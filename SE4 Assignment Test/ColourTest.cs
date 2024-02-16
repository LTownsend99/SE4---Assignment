using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class ColourTest
    {
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

        [TestMethod]
        public void TestValidColourParameters()
        {
            string parameters = "COLOUR 173 216 230";

            shapeFactory shapeFactory = new shapeFactory();

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
