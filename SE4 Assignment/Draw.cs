namespace SE4_Assignment
{
    public class Draw
    {
        Pen pen;
        SolidBrush brush;
        Color colour = Color.Black;
        int xPos = 0;
        int yPos = 0;
        Bitmap bitmap;
        PictureBox drawingBox;
        bool fill = false;

        public Draw(PictureBox drawingBox)
        {
          this.drawingBox = drawingBox;
          bitmap = new Bitmap(drawingBox.Width, drawingBox.Height);
          pen = new Pen(colour);
          brush = new SolidBrush(colour);

        }

        public void drawCircle(int radius)
        {
            using Graphics g = Graphics.FromImage(bitmap);
            if(fill)
            {
                g.FillEllipse(brush, xPos, yPos, radius * 2, radius * 2);

            }else
            {
                g.DrawEllipse(pen, xPos, yPos, radius *2, radius * 2);
            }

            drawingBox.Image = bitmap;
        }

        public void drawRectangle(int width, int height)
        {
            using Graphics g = Graphics.FromImage(bitmap);

            if(fill)
            {
                g.FillRectangle(brush, xPos, yPos, width, height);
            }else
            {
                g.DrawRectangle(pen, xPos, yPos, width, height);
            }
            
            drawingBox.Image = bitmap;
        }

        public void drawFill(bool fill)
        {
            this.fill = fill;
        }
    }
}
