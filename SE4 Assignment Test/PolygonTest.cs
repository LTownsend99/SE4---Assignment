using SE4_Assignment;
namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid Polygon parameters
    /// </summary>
    [TestClass]
    public class PolygonTest
    {
        /// <summary>
        /// Test for Invalid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("POLYGON", "-50,20")]
        [DataRow("POLYGON", "50,-20")]
        [DataRow("POLYGON", "abc")]
        public void TestInvalidPolygonParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Polygon polygon = new Polygon(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when points should be Positive"))
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
        public void TestValidPolygonParameters()
        {
            string parameters = "POLYGON 10 20 30 40 50 60";

            try
            {
                string[] param = parameters.Split(' ');
                Polygon polygon = new Polygon(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}

