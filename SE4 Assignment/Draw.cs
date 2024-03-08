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

        public bool drawEnabled { get; set; } = true;


        public Draw(PictureBox drawingBox)
        {
            this.drawingBox = drawingBox;
            bitmap = new Bitmap(drawingBox.Width, drawingBox.Height);
            pen = new Pen(colour);
            brush = new SolidBrush(colour);

        }

        public void drawCircle(int radius)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);
                if (fill)
                {
                    g.FillEllipse(brush, xPos, yPos, radius * 2, radius * 2);

                }
                else
                {
                    g.DrawEllipse(pen, xPos, yPos, radius * 2, radius * 2);
                }

                drawingBox.Image = bitmap;
            }
        }

        public void drawRectangle(int width, int height)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);

                if (fill)
                {
                    g.FillRectangle(brush, xPos, yPos, width, height);
                }
                else
                {
                    g.DrawRectangle(pen, xPos, yPos, width, height);
                }

                drawingBox.Image = bitmap;
            }
        }

        public void drawTriangle(int width, int height)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);

                Point p1 = new Point(xPos, height);
                Point p2 = new Point(width / 2, yPos);
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
        }

        public void drawTo(int x, int y)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);

                g.DrawLine(pen, xPos, yPos, x, y);

                drawingBox.Image = bitmap;

                xPos = x;
                yPos = y;
            }
        }

        public void moveTo(int x, int y)
        {
            if (drawEnabled)
            {
                xPos = x;
                yPos = y;
            }
        }

        public void setColour(int red, int green, int blue)
        {
            if (drawEnabled)
            {
                colour = Color.FromArgb(red, green, blue);
                pen.Color = colour;
                brush.Color = colour;
            }
        }

        public void setColour(Color newColour)
        {
            if (drawEnabled)
            {
                colour = newColour;
                pen.Color = colour;
                brush.Color = colour;
            }
        }

        public void drawFill(bool fill)
        {
            if (drawEnabled)
            {
                this.fill = fill;
            }
        }

        public void clear()
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);

                g.Clear(Color.Transparent);


                drawingBox.Image = bitmap;
            }
        }

        public void reset()
        {
            if (drawEnabled)
            {
                xPos = 0;
                yPos = 0;
                colour = Color.Black;
                fill = false;
            }
        }
    }
}
