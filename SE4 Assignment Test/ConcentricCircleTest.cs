using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid ConcentricCircle Parameters
    /// </summary>
    [TestClass]
    public class ConcentricCircleTest
    {
        /// <summary>
        /// Test for Invalid ConcentricCircle paramaters
        /// </summary>
        /// <param name="shapeCommand"> command word passed in</param>
        /// <param name="parameters"> paramaeters to be checked</param>
        [DataTestMethod]
        [DataRow("CONCIRCLE", "-50")]
        [DataRow("CONCIRCLE", "10,20,30,40")]
        [DataRow("CONCIRCLE", "abc")]
        public void TestInvalidCircleParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                ConcentricCircle circle = new ConcentricCircle(param);
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
        /// Test for Valid ConcentricCircle parameters
        /// </summary>
        [TestMethod]
        public void TestValidCircleParameters()
        {
            string parameters = "CONCIRCLE 50";

            try
            {
                string[] param = parameters.Split(' ');
                ConcentricCircle circle = new ConcentricCircle(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
