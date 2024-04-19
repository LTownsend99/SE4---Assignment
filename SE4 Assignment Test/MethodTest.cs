using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class MethodTest
    {

        [DataTestMethod]
        [DataRow("METHOD", "")]
        [DataRow("METHOD", "A")]
        [DataRow("METHOD", "c = + 2 3")]
        public void TestInvalidMethodParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Method method = new Method(param);
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


        [DataTestMethod]
        [DataRow("METHOD", "myMethod()")]
        [DataRow("METHOD", "myMethod(a,b)")]
        public void TestValidMethodParameters(string shapeCommand, string parameters)
        {
            try
            {
                string[] param = parameters.Split(' ');
                Method method = new Method(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
