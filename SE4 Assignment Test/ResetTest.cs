using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class ResetTest
    {
        [DataTestMethod]
        [DataRow("RESET", "-50")]
        public void TestInvalidResetParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Reset reset = new Reset(param);
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

        [TestMethod]
        public void TestValidResetParameters()
        {
            string parameters = "RESET";

            shapeFactory shapeFactory = new shapeFactory();

            try
            {
                string[] param = parameters.Split(' ');
                Reset reset = new Reset(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
