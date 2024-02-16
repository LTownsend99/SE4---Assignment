namespace SE4_Assignment
{
    public class Fill : Shape
    {
        protected bool fill;
        public Fill(string[] array) : base(array)
        {
            noOfParameters = 1;
        }

        public override void runCommand(Draw draw)
        {
            base.runCommand(draw);

            if (parameters[0].Equals("ON"))
            {
                fill = true;
            }
            else if (parameters[0].Equals("OFF"))
            {
                fill = false;
            }
            else
            {
                // Throws an exception if an ineligible phrase is passed in 
                throw new ArgumentException("Invalid data - Provided a ineligible phrase");
            }

            draw.drawFill(fill);
        }
    }
}
