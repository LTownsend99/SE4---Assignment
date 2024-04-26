using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid VAR parameters
    /// </summary>
    [TestClass]
    public class VarTest
    {
        /// <summary>
        /// Test for Invalid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("VAR", "count 40")]
        [DataRow("VAR", "count")]
        [DataRow("VAR", "c = + 2 3")]
        [DataRow("VAR", "c = 2 -")]
        public void TestInvalidVarParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Var var = new Var(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Number of Parmeters"))
                    {
                        return;
                    }
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
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
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("VAR", "size = 50")]
        [DataRow("VAR", "a = 5 + 6")]
        [DataRow("VAR", "a = 5 - 6")]
        [DataRow("VAR", "a = 5 * 6")]
        [DataRow("VAR", "a = 5 / 6")]

        public void TestValidVarParameters(string shapeCommand, string parameters)
        {
            try
            {
                string[] param = parameters.Split(' ');
                Var var = new Var(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }

    }
}
