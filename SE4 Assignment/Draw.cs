namespace SE4_Assignment
{
    public class Draw
    {
        Pen pen;
        SolidBrush brush;
        Graphics g;
        Color colour = Color.Black;
        int xPos;
        int yPos;

        public Draw(Graphics g)
        {
            this.g = g;
            xPos = 0;
            yPos = 0;

        }

        public void drawCircle(int radius)
        {
            pen.Color = colour;
            g.DrawEllipse(pen, xPos, yPos, radius * 2, radius * 2);
        }

        public void fillCircle(int radius)
        {
            brush = new(colour);

            g.FillEllipse(brush, xPos, yPos, radius * 2, radius * 2);
        }
    }
}
