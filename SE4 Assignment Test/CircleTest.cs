using SE4_Assignment;

namespace SE4_Assignment_Test
{
    [TestClass]
    public class CircleTest
    {

        [DataTestMethod]
        [DataRow("CIRCLE", "-50")]
        [DataRow("CIRCLE", "10,20,30,40")]
        [DataRow("CIRCLE", "abc")]
        public void TestInvalidCircleParameters(string shapeCommand, string parameters)
        {
            try
            {

                string[] param = parameters.Split(',');

                Circle circle = new Circle(param);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (ex.Equals("Invalid Data - Cannot convert to Integer"))
                    {
                        return;
                    }
                    else if (ex.Equals("Invalid data - Provided a Negative Number when Radius should be Positive"))
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
        public void TestValidCircleParameters()
        {
            string parameters = "CIRCLE 50";

            shapeFactory shapeFactory = new shapeFactory();

            try
            {
                string[] param = parameters.Split(' ');
                Circle circle = new Circle(param);
            }
            catch (Exception ex)
            {
                Assert.Fail("An Exception was thrown: " + ex);
            }

        }
    }
}
