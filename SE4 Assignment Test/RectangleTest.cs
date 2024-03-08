using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class RectangleTest
    {
        [DataTestMethod]
        [DataRow("RECTANGLE", "-50,20")]
        [DataRow("RECTANGLE", "50,-20")]
        [DataRow("RECTANGLE", "10,20,30,40")]
        [DataRow("RECTANGLE", "abc")]
        public void TestInvalidRectangleParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Rectangle rectangle = new Rectangle(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when Width should be Positive"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when Height should be Positive"))
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
        public void TestValidRectangleParameters()
        {
            string parameters = "RECTANGLE 10 20";

            try
            {
                string[] param = parameters.Split(' ');
                Rectangle rectangle = new Rectangle(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
