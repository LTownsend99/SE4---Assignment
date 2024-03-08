using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class TriangleTest
    {

        [DataTestMethod]
        [DataRow("TRIANGLE", "-50,20")]
        [DataRow("TRIANGLE", "50,-20")]
        [DataRow("TRIANGLE", "10,20,30,40")]
        [DataRow("TRIANGLE", "abc")]
        public void TestInvalidTriangleParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Triangle triangle = new Triangle(param);
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
        public void TestValidTriangleParameters()
        {
            string parameters = "TRIANGLE 10 20";

            try
            {
                string[] param = parameters.Split(' ');
                Triangle triangle = new Triangle(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
