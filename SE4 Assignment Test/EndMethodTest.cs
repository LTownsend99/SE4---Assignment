using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid ENDMETHOD parameters
    /// </summary>
    [TestClass]
    public class EndMethodTest
    {
        /// <summary>
        /// Test for Invalid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("ENDMETHOD", "-50")]
        public void TestInvalidEndMethodParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                EndMethod endMethod = new EndMethod(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Number of Parmeters"))
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
        public void TestValidEndMethodParameters()
        {
            string parameters = "ENDMETHOD";

            try
            {
                string[] param = parameters.Split(' ');
                EndMethod endMethod = new EndMethod(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }
        }
    }
}
