
namespace SE4_Assignment
{
    public class Draw
    {
        Pen pen;
        SolidBrush brush;
        Color colour = Color.Black;
        Color colour1 = Color.Black;
        Color colour2 = Color.Black;

        int xPos = 0;
        int yPos = 0;
        Bitmap bitmap;
        Bitmap bitmap2;
        Bitmap currentBitmap;
        PictureBox drawingBox;
        bool fill = false;
        bool flashFlag = false;
        Thread flashingThread;
        Pen multiColourPen;
        SolidBrush multiColourBrush;
        bool multiColour = false;

        public bool drawEnabled { get; set; } = true;


        public Draw(PictureBox drawingBox)
        {
            this.drawingBox = drawingBox;
            bitmap = new Bitmap(drawingBox.Width, drawingBox.Height);
            bitmap2 = new Bitmap(drawingBox.Width, drawingBox.Height);
            currentBitmap = bitmap;
            pen = new Pen(colour);
            brush = new SolidBrush(colour);
            multiColourPen = new Pen(colour);
            multiColourBrush = new SolidBrush(colour);
            flashingThread = new Thread(FlashBitmaps);
            flashingThread.Start();
        }

        public void drawCircle(int radius)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                if (fill)
                {
                    if (multiColour == false)
                    {
                        g.FillEllipse(brush, xPos, yPos, radius * 2, radius * 2);
                        g2.FillEllipse(brush, xPos, yPos, radius * 2, radius * 2);

                    }
                    else
                    {
                        multiColourBrush.Color = colour1;
                        g.FillEllipse(multiColourBrush, xPos, yPos, radius * 2, radius * 2);
                        multiColourBrush.Color = colour2;
                        g2.FillEllipse(multiColourBrush, xPos, yPos, radius * 2, radius * 2);

                    }

                }
                else
                {
                    if (multiColour == false)
                    {
                        g.DrawEllipse(pen, xPos, yPos, radius * 2, radius * 2);
                        g2.DrawEllipse(pen, xPos, yPos, radius * 2, radius * 2);

                    }
                    else
                    {
                        multiColourPen.Color = colour1;
                        g.DrawEllipse(multiColourPen, xPos, yPos, radius * 2, radius * 2);
                        multiColourPen.Color = colour2;
                        g2.DrawEllipse(multiColourPen, xPos, yPos, radius * 2, radius * 2);
                    }
                }

                drawingBox.Image = currentBitmap;
            }
        }

        public void drawRectangle(int width, int height)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);


                if (fill)
                {
                    if (multiColour == false)
                    {
                        g.FillRectangle(brush, xPos, yPos, width, height);
                        g2.FillRectangle(brush, xPos, yPos, width, height);
                    }
                    else
                    {
                        multiColourBrush.Color = colour1;
                        g.FillRectangle(multiColourBrush, xPos, yPos, width, height);
                        multiColourBrush.Color = colour2;
                        g2.FillRectangle(multiColourBrush, xPos, yPos, width, height);

                    }
                }
                else
                {
                    if (multiColour == false)
                    {
                        g.DrawRectangle(pen, xPos, yPos, width, height);
                        g2.DrawRectangle(pen, xPos, yPos, width, height);
                    }
                    else
                    {
                        multiColourPen.Color = colour1;
                        g.DrawRectangle(multiColourPen, xPos, yPos, width, height);
                        multiColourPen.Color = colour2;
                        g2.DrawRectangle(multiColourPen, xPos, yPos, width, height);
                    }
                }

                drawingBox.Image = currentBitmap;
            }
        }

        public void drawTriangle(int width, int height)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                Point p1 = new Point(xPos, height);
                Point p2 = new Point(width / 2, yPos);
                Point p3 = new Point(width, height);


                if (fill)
                {
                    if (multiColour == false)
                    {
                        g.FillPolygon(brush, new Point[] { p1, p2, p3 });
                        g2.FillPolygon(brush, new Point[] { p1, p2, p3 });
                    }
                    else
                    {
                        multiColourBrush.Color = colour1;
                        g.FillPolygon(multiColourBrush, new Point[] { p1, p2, p3 });
                        multiColourBrush.Color = colour2;
                        g2.FillPolygon(multiColourBrush, new Point[] { p1, p2, p3 });
                    }
                }
                else
                {
                    if (multiColour == false)
                    {
                        g.DrawPolygon(pen, new Point[] { p1, p2, p3 });
                        g2.DrawPolygon(pen, new Point[] { p1, p2, p3 });
                    }
                    else
                    {
                        multiColourPen.Color = colour1;
                        g.DrawPolygon(multiColourPen, new Point[] { p1, p2, p3 });
                        multiColourPen.Color = colour2;
                        g2.DrawPolygon(multiColourPen, new Point[] { p1, p2, p3 });
                    }
                }

                drawingBox.Image = currentBitmap;
            }
        }

        public void drawPolygon(List<int> points)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                Point[] polygonPoints = new Point[points.Count];

                for (int i = 0; i < points.Count; i += 2)
                {
                    int x = points[i] + xPos; // Adjust x-coordinate
                    int y = points[i + yPos]; // Use y-coordinate as is

                    polygonPoints[i / 2] = new Point(x, y);
                }

                if (fill)
                {
                    if (multiColour == false)
                    {
                        g.FillPolygon(brush, polygonPoints);
                        g2.FillPolygon(brush, polygonPoints);
                    }
                    else
                    {
                        multiColourBrush.Color = colour1;
                        g.FillPolygon(multiColourBrush, polygonPoints);
                        multiColourBrush.Color = colour2;
                        g2.FillPolygon(multiColourBrush, polygonPoints);
                    }
                }
                else
                {
                    if (multiColour == false)
                    {
                        g.DrawPolygon(pen, polygonPoints);
                        g2.DrawPolygon(pen, polygonPoints);
                    }
                    else
                    {
                        multiColourPen.Color = colour1;
                        g.DrawPolygon(multiColourPen, polygonPoints);
                        multiColourPen.Color = colour2;
                        g2.DrawPolygon(multiColourPen, polygonPoints);
                    }
                }

                drawingBox.Image = currentBitmap;
            }
        }

        public void drawTo(int x, int y)
        {
            if (drawEnabled)
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                if (multiColour == false)
                {
                    g.DrawLine(pen, xPos, yPos, x, y);
                    g2.DrawLine(pen, xPos, yPos, x, y);
                }
                else
                {
                    multiColourPen.Color = colour1;
                    g.DrawLine(multiColourPen, xPos, yPos, x, y);
                    multiColourPen.Color = colour2;
                    g2.DrawLine(multiColourPen, xPos, yPos, x, y);
                }

                drawingBox.Image = currentBitmap;

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
            multiColour = false;

            if (drawEnabled)
            {
                colour = Color.FromArgb(red, green, blue);
                pen.Color = colour;
                brush.Color = colour;
            }
        }

        public void setColour(Color newColour)
        {
            multiColour = false;

            if (drawEnabled)
            {
                colour = newColour;
                pen.Color = colour;
                brush.Color = colour;
            }
        }

        public void setMultiColour(Color colour1, Color colour2)
        {
            multiColour = true;

            if (drawEnabled)
            {
                this.colour1 = colour1;
                this.colour2 = colour2;
            }
        }

        public void FlashBitmaps()
        {
            if (drawEnabled)
            {
                while (true)
                {
                    if (flashFlag == false)
                    {
                        currentBitmap = bitmap;
                        drawingBox.Image = currentBitmap;
                        flashFlag = true;
                    }
                    else
                    {
                        currentBitmap = bitmap2;
                        drawingBox.Image = currentBitmap;
                        flashFlag = false;
                    }

                    Thread.Sleep(500);
                }
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
                using Graphics g2 = Graphics.FromImage(bitmap2);

                g.Clear(Color.Transparent);
                g2.Clear(Color.Transparent);

                drawingBox.Image = currentBitmap;
            }
        }

        public void reset()
        {
            if (drawEnabled)
            {
                xPos = 0;
                yPos = 0;
                colour = Color.Black;
                colour1 = Color.Black;
                colour2 = Color.Black;
                fill = false;
                flashFlag = false;
                multiColour = false;
            }
        }

        
    }
}
