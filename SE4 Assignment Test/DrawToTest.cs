using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class DrawToTest
    {
        [DataTestMethod]
        [DataRow("DRAWTO", "-50,20")]
        [DataRow("DRAWTO", "50,-20")]
        [DataRow("DRAWTO", "10,20,30")]
        [DataRow("DRAWTO", "abc")]
        public void TestInvalidDrawToParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                DrawTo drawTo = new DrawTo(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when x should be Positive"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when y should be Positive"))
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
        public void TestValidDrawToParameters()
        {
            string parameters = "DRAWTO 10 20";

            shapeFactory shapeFactory = new shapeFactory();

            try
            {
                string[] param = parameters.Split(' ');
                DrawTo drawTo = new DrawTo(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }

    }
}
