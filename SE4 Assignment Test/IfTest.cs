using SE4_Assignment;

namespace SE4_Assignment_Test
{
    /// <summary>
    /// Tests for Invalid and Valid IF parameters
    /// </summary>
    [TestClass]
    public class IfTest
    {
        /// <summary>
        /// Test for Invalid parameters
        /// </summary>
        /// <param name="shapeCommand"> commandName passed in</param>
        /// <param name="parameters"> parameters to be checked </param>
        [DataTestMethod]
        [DataRow("IF", "A + B ")]
        [DataRow("IF", "A")]
        [DataRow("IF", "c = + 2 3")]
        [DataRow("IF", "")]
        [DataRow("IF", "5 > 10")]

        public void TestInvalidIfParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                IF i = new IF(param);
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
                    if (ex.Equals("Invalid Data - Cannot Process inline Command"))
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
        [DataRow("IF", "50 < 100 CIRCLE 100")]
        [DataRow("IF", "50 > 100 CIRCLE 100")]
        [DataRow("IF", "50 <= 100 CIRCLE 100")]
        [DataRow("IF", "50 >= 100 RECTANGLE 100 50")]
        [DataRow("IF", "50 == 100 TRIANGLE 100 100")]
        public void TestValidIfParameters(string shapeCommand, string parameters)
        {
            try
            {
                string[] param = parameters.Split(' ');
                IF i = new IF(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }

    }
}
