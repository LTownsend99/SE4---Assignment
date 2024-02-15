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

        public void drawTriangle(int width, int height)
        {
            using Graphics g = Graphics.FromImage(bitmap);

            Point p1 = new Point(xPos, height);
            Point p2 = new Point(width / 2 , yPos);
            Point p3 = new Point(width, height);


            if (fill)
            {
                g.FillPolygon(brush, new Point[] { p1, p2, p3 });
            }
            else
            {
                g.DrawPolygon(pen, new Point[] { p1, p2, p3 });
            }

            drawingBox.Image = bitmap;
        }

        public void drawTo(int x, int y)
        {
            using Graphics g = Graphics.FromImage(bitmap);
            
            g.DrawLine(pen,xPos,yPos,x,y);
            
            drawingBox.Image = bitmap;

            xPos = x; 
            yPos = y;
        }

        public void moveTo(int x, int y)
        {
            xPos = x; 
            yPos = y;

        }

        public void drawFill(bool fill)
        {
            this.fill = fill;
        }

        public void clear()
        {
            drawingBox.Image = null;
            drawingBox.Update();
        }

        public void reset()
        {
            xPos = 0;
            yPos = 0;
            colour = Color.Black;
            fill = false;
        }
    }
}
