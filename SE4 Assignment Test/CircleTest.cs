using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid Circle Parameters
    /// </summary>
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Test for Invalid Circle paramaters
        /// </summary>
        /// <param name="shapeCommand"> command word passed in</param>
        /// <param name="parameters"> paramaeters to be checked</param>
        [DataTestMethod]
        [DataRow("CIRCLE", "-50")]
        [DataRow("CIRCLE", "10,20,30,40")]
        [DataRow("CIRCLE", "abc")]
        public void TestInvalidCircleParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Circle circle = new Circle(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when Radius should be Positive"))
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
        /// Test for Valid Circle parameters
        /// </summary>
        [TestMethod]
        public void TestValidCircleParameters()
        {
            string parameters = "CIRCLE 50";

            try
            {
                string[] param = parameters.Split(' ');
                Circle circle = new Circle(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
