using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class MoveToTest
    {
        [DataTestMethod]
        [DataRow("MOVETO", "-50,20")]
        [DataRow("MOVETO", "50,-20")]
        [DataRow("MOVETO", "10,20,30")]
        [DataRow("MOVETO", "abc")]
        public void TestInvalidMoveToParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                MoveTo moveTo = new MoveTo(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when x should be Positive"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when y should be Positive"))
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
        public void TestValidMoveToParameters()
        {
            string parameters = "MOVETO 10 20";

            try
            {
                string[] param = parameters.Split(' ');
                DrawTo drawTo = new DrawTo(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }

    }
}
