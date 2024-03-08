using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class ClearTest
    {
        [DataTestMethod]
        [DataRow("CLEAR", "-50")]
        [DataRow("MOVETO", "50,-20")]
        public void TestInvalidClearParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Clear clear = new Clear(param);
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
        public void TestValidClearParameters()
        {
            string parameters = "CLEAR";

            try
            {
                string[] param = parameters.Split(' ');
                Clear clear = new Clear(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
