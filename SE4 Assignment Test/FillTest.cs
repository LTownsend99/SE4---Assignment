using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class FillTest
    {
        [DataTestMethod]
        [DataRow("FILL", "50,10")]
        [DataRow("FILL", "abc")]
        public void TestInvalidFillParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Fill fill = new Fill(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid data - Provided a ineligible phrase"))
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

        [TestMethod]
        public void TestValidFillParameters()
        {
            string parameters = "FILL ON";
            shapeFactory shapeFactory = new shapeFactory();

            try
            {
                string[] param = parameters.Split(' ');
                Fill fill = new Fill(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }

    }
}
