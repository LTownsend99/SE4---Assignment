namespace SE4_Assignment
{
    public partial class Form1 : Form
    {

        Draw draw;
        public Form1()
        {

            InitializeComponent();

            draw = new Draw(drawingBox);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";    //sets the type of file it can open

            if (open.ShowDialog() == DialogResult.OK)
            {
                commandBox.Text = System.IO.File.ReadAllText(open.FileName);    //print the contents of the file to the commandBox

                Terminal.Text += "File Successfully Opened" + Environment.NewLine;

            }                                               // If the save is successful/Unsuccessul print a message to the terminal

            else { Terminal.Text += "Could not Open File" + Environment.NewLine; }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";    //sets the type of file it can open

            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(save.FileName, commandBox.Text);    //Saves the contents of the text box to a .txt file

                Terminal.Text += "File Successfully Saved" + Environment.NewLine;

            }                                               // If the save is successful/Unsuccessul print a message to the terminal

            else { Terminal.Text += "Could not Save File" + Environment.NewLine; }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clears both the command line and box
            commandBox.Clear();
            commandLine.Clear();
            // Clears the drawing panel
            drawingBox.Image = null;
            drawingBox.Update();
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            String commandText = commandLine.Text;

            try
            {
                Command command = shapeFactory.proccessCommand(commandText);    //  passes the commmand from the command line

                command.runCommand(draw);       //  proccesses the commmand
            }
            catch (Exception ex)
            {
                Terminal.Text += ex.Message + Environment.NewLine; ;     // If the proccess of the command fails, print a message to the terminal including th exception message
            }
            commandLine.Text = "";
        }

        private void runProgram_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < commandBox.Lines.Length; i++)       // loops through the lines in the commandBox
            {
                string line = commandBox.Lines[i];
                try
                {
                    Command command = shapeFactory.proccessCommand(line);       //  passes the commmand from the line

                    command.runCommand(draw);       //  proccesses the commmand
                }
                catch (Exception ex)
                {
                    Terminal.Text += ex.Message + " For Command: " + line + Environment.NewLine; ;     // If the proccess of the command fails, print a message to the terminal including th exception message
                }
            }

        }

        private void syntaxButton_Click(object sender, EventArgs e)
        {
            draw.drawEnabled = false;       // turns drawing off so just the validation is run

            for (int i = 0; i < commandBox.Lines.Length; i++)       // loops through the lines in the commandBox
            {

                string line = commandBox.Lines[i];
                try
                {
                    Command command = shapeFactory.proccessCommand(line);       //  passes the commmand from the line

                    command.runCommand(draw);       //  proccesses the commmand
                }
                catch (Exception ex)
                {
                    Terminal.Text += ex.Message + " For Command: " + line + Environment.NewLine; ;     // If the proccess of the command fails, print a message to the terminal including th exception message
                }
            }

            draw.drawEnabled = true;        // turns drawing back on 
        }
    }
}
