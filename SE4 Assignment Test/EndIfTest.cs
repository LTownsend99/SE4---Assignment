using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class EndIfTest
    {
        [DataTestMethod]
        [DataRow("ENDIF", "-50")]
        public void TestInvalidEndIfParameters(string shapeCommand, string parameters)
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

        [TestMethod]
        public void TestValidEndIfParameters()
        {
            string parameters = "ENDIF";

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
