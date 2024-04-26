using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid ENDWHILE parameters
    /// </summary>
    [TestClass]
    public class EndWhileTest
    {
        /// <summary>
        /// Test for Invalid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("ENDWHILE", "-50")]
        public void TestInvalidEndWhileParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                EndIf endIf = new EndIf(param);
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
        public void TestValidEndWhileParameters()
        {
            string parameters = "ENDWHILE";

            try
            {
                string[] param = parameters.Split(' ');
                EndIf endIf = new EndIf(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }
        }
    }
}
