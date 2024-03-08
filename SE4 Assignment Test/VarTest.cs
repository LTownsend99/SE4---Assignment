using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class VarTest
    {
        [DataTestMethod]
        [DataRow("VAR", "count 40")]
        [DataRow("VAR", "count")]
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
            string parameters = "VAR size = 50";

            shapeFactory shapeFactory = new shapeFactory();

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
