
namespace SE4_Assignment
{
    /// <summary>
    /// Drawing class the executes all methods the action something on the drawingBox
    /// </summary>
    public class Draw
    {
        private Pen pen;
        private SolidBrush brush;
        private Color colour = Color.Black;
        private Color colour1 = Color.Black;
        private Color colour2 = Color.Black;

        private int xPos = 0;
        private int yPos = 0;
        private Bitmap bitmap;
        private Bitmap bitmap2;
        private Bitmap currentBitmap;
        private PictureBox drawingBox;
        private bool fill = false;
        private bool flashFlag = false;
        public Thread flashingThread;
        private Pen multiColourPen;
        private SolidBrush multiColourBrush;
        private bool multiColour = false;

        public bool drawEnabled { get; set; } = true;
        public bool runFlag { get; set; } = true;


        /// <summary>
        /// Contructor - initialises all the relevant variables
        /// </summary>
        /// <param name="drawingBox"> the box on the form we want to draw to</param>
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

        /// <summary>
        /// Draws a circle with the radius passed in
        /// </summary>
        /// <param name="radius"> passed from the Circle class </param>
        public void drawCircle(int radius)
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                if (fill)       // if fill is on, then it will draw a solid shape
                {
                    if (multiColour == false)   // if a mutliColour isnt used then will draw in one colour
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
                    if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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

                drawingBox.Image = currentBitmap;   // what ever is drawn on the bitmap is set to the drawingBox
            }
        }

        /// <summary>
        /// Draws a Rectangle based on the parameters passed in
        /// </summary>
        /// <param name="width"> passed from the Rectangle Class </param>
        /// <param name="height">  passed from the Rectangle Class </param>
        public void drawRectangle(int width, int height)
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);


                if (fill)       // if fill is on, then it will draw a solid shape
                {
                    if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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
                    if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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

                drawingBox.Image = currentBitmap;       // what ever is drawn on the bitmap is set to the drawingBox
            }
        }

        /// <summary>
        /// Draws a Triangle based the parameters passed in
        /// </summary>
        /// <param name="width"> passed form the Triangle Class </param>
        /// <param name="height"> passed form the Triangle Class </param>
        public void drawTriangle(int width, int height)
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                Point p1 = new Point(xPos, height);
                Point p2 = new Point(width / 2, yPos);
                Point p3 = new Point(width, height);


                if (fill)       // if fill is on, then it will draw a solid shape
                {   
                    if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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
                    if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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

                drawingBox.Image = currentBitmap;       // what ever is drawn on the bitmap is set to the drawingBox
            }
        }

        /// <summary>
        /// Draws a Polygon based the parmeters passed in
        /// </summary>
        /// <param name="points"> the parameters passed from the Polygon class </param>
        public void drawPolygon(List<int> points)
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                Point[] polygonPoints = new Point[points.Count / 2];

                for (int i = 0; i < points.Count; i += 2)
                {
                    int x = points[i] + xPos; // Adjust x-coordinate
                    int y = points[i + 1] + yPos; // Use y-coordinate as is

                    polygonPoints[i / 2] = new Point(x, y);
                }

                if (fill)       // if fill is on, then it will draw a solid shape
                {
                    if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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
                    if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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

                drawingBox.Image = currentBitmap;       // what ever is drawn on the bitmap is set to the drawingBox
            }
        }

        /// <summary>
        /// Draws a Line based the parmeters passed in
        /// </summary>
        /// <param name="x"> passed from the DrawTo class</param>
        /// <param name="y"> passed from the DrawTo class </param>
        public void drawTo(int x, int y)
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                if (multiColour == false)       // if a mutliColour isnt used then will draw in one colour
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

                drawingBox.Image = currentBitmap;       // what ever is drawn on the bitmap is set to the drawingBox

                xPos = x;   // sets xPos to the current x coordinate
                yPos = y;   // sets yPos to the current y coordinate
            }
        }

        /// <summary>
        /// Move the start postion for drawing
        /// </summary>
        /// <param name="x"> passed in from the MoveTo class </param>
        /// <param name="y"> passed in from the MoveTo class </param>
        public void moveTo(int x, int y)
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                xPos = x;   // sets xPos to the current x coordinate
                yPos = y;   // sets yPos to the current y coordinate
            }
        }

        /// <summary>
        /// Sets the colour of the Brush and the Pen to the Colours passed in 
        /// </summary>
        /// <param name="red"> passed in from the ColourRGB class </param>
        /// <param name="green"> passed in from the ColourRGB class </param>
        /// <param name="blue"> passed in from the ColourRGB class </param>
        public void setColour(int red, int green, int blue)
        {
            multiColour = false;    // sets multiColour to false as it is a single colour

            if (drawEnabled)        // checks if drawing is enabled
            {
                colour = Color.FromArgb(red, green, blue);  // sets the colour using 3 integers < 255
                pen.Color = colour;
                brush.Color = colour;
            }
        }

        /// <summary>
        /// Sets the colour of the Brush and the Pen to the Colours passed in 
        /// </summary>
        /// <param name="newColour"> passed in from the Colour class </param>
        public void setColour(Color newColour)
        {
            multiColour = false;    // sets multiColour to false as it is a single colour

            if (drawEnabled)        // checks if drawing is enabled
            {
                colour = newColour; // sets colour to the new colour passed in
                pen.Color = colour;
                brush.Color = colour;
            }
        }

        /// <summary>
        /// Sets the colours 1 and 2 to the Colours passed in 
        /// </summary>
        /// <param name="colour1"></param>
        /// <param name="colour2"></param>
        public void setMultiColour(Color colour1, Color colour2)
        {
            multiColour = true; // sets multiColour to true so 2 bitmaps are used
                
            if (drawEnabled)        // checks if drawing is enabled
            {
                this.colour1 = colour1;
                this.colour2 = colour2;
            }
        }

        /// <summary>
        /// A method the Thread uses to flick between 2 bitmaps to allow the colours to flash
        /// </summary>
        public void FlashBitmaps()
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                while (runFlag)     //checks if the runFlag is active for the Thread
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

                    Thread.Sleep(500);  // tells the thread how long it should appear for
                }
            }
        }
        
        /// <summary>
        /// Sets the fill boolean to draw so solid shapes are drawn
        /// </summary>
        /// <param name="fill"> parameter passed in from the Fill class </param>
        public void drawFill(bool fill)
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                this.fill = fill;
            }
        }

        /// <summary>
        /// Clears both bitmaps
        /// </summary>
        public void clear()
        {
            if (drawEnabled)        // checks if drawing is enabled
            {
                using Graphics g = Graphics.FromImage(bitmap);
                using Graphics g2 = Graphics.FromImage(bitmap2);

                g.Clear(Color.Transparent);
                g2.Clear(Color.Transparent);

                
                drawingBox.Image = currentBitmap;       // what ever is drawn on the bitmap is set to the drawingBox
            }
        }

        /// <summary>
        /// Resets all the relevant variables
        /// </summary>
        public void reset()
        {
            if (drawEnabled)        // checks if drawing is enabled
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
