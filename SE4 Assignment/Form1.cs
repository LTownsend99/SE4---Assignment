namespace SE4_Assignment
{
    /// <summary>
    /// Form1 is the driver class for the windows Form and will hold all the event methods
    /// </summary>
    public partial class Form1 : Form
    {

        Draw draw;
        VarStorage varStorage = VarStorage.Instance;
        MethodStorage methodStorage = MethodStorage.Instance;

        /// <summary>
        /// Initializes the form so it renders correctly and creates the GUI for the user to use
        /// </summary>
        public Form1()
        {

            InitializeComponent();

            draw = new Draw(drawingBox);

        }

        /// <summary>
        /// When Open is clicked, the file the user has selected will be loaded into the commandBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When Save is clicked all the text in the CommandBox will be saved to a text document to a location of the 
        /// users choosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When New is clicked everything is cleared and will be blank. Basically a Fresh Start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clears both the command line and box
            commandBox.Clear();
            commandLine.Clear();
            // Clears the drawing panel
            draw.clear();
        }

        /// <summary>
        /// Allows you to draw to the drawingBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Runs the command typed in the commandLine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runButton_Click(object sender, EventArgs e)
        {
            String commandText = commandLine.Text;
            try
            {
                Command command = shapeFactory.processCommand(commandText);    //  passes the commmand from the command line

                command.runCommand(draw, varStorage, methodStorage);       //  proccesses the commmand
            }
            catch (Exception ex)
            {
                Terminal.Text += ex.Message + Environment.NewLine; ;     // If the proccess of the command fails, print a message to the terminal including th exception message
            }
            commandLine.Text = "";
        }

        /// <summary>
        /// Reads through all the lines in the commandBox and executes them a line at a time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns> Will return which commands have errors to the Terminal (if any)</returns>
        private void runProgram_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < commandBox.Lines.Length; i++)       // loops through the lines in the commandBox
            {
                string line = commandBox.Lines[i];
                try
                {
                    Command command = shapeFactory.processCommand(line);       //  passes the commmand from the line

                    command.runCommand(draw, varStorage, methodStorage);       //  proccesses the commmand

                    if (command is IF IfCommand)
                    {
                        if (IfCommand.singleLine == false)  // if it is a single line IF statement proccess as normal and ignore this block of code
                        {

                            for (int a = i + 1; a < commandBox.Lines.Length; a++)
                            {
                                string instruction = commandBox.Lines[a];

                                command = shapeFactory.processCommand(instruction);       //  passes the commmand from the line

                                if (IfCommand.check)
                                {
                                    command.runCommand(draw, varStorage, methodStorage);
                                }

                                if (command is EndIf)       // if endIf is reached break the loop and move on to the next line
                                {
                                    i = a;
                                    break;

                                }
                            }

                        }
                    }

                    if (command is While WhileCommand)
                    {
                        int temp = i;

                        while (WhileCommand.check)
                        {
                            for (int a = i + 1; a < commandBox.Lines.Length; a++)
                            {
                                string instruction = commandBox.Lines[a];

                                command = shapeFactory.processCommand(instruction);       //  passes the commmand from the line

                                if (WhileCommand.check)
                                {
                                    command.runCommand(draw, varStorage, methodStorage);
                                }

                                if (command is EndWhile)        // if endWhile is reached break the loop and move on to the next line
                                {
                                    temp = a;
                                    break;

                                }

                            }

                            WhileCommand.runCommand(draw, varStorage, methodStorage);
                        }
                        i = temp;
                    }

                    if (command is Method methodCommand)
                    {
                        List<string> method = new List<string>();

                        for (int a = i + 1; a < commandBox.Lines.Length; a++)
                        {
                            if (commandBox.Lines[a].ToUpper() != "ENDMETHOD")
                            {
                                // adds all the lines between METHOD and ENDMETHOD to a list 
                                method.Add(commandBox.Lines[a]);
                            }
                            else
                            {
                                i = a; // sets i to a so the programe contiues after the method is declared
                                break;
                            }

                            methodCommand.setCommands(method);


                        }


                    }
                }
                catch (Exception ex)
                {
                    Terminal.Text += ex.Message + " For Command: " + line + " on Line : " + (i + 1) + Environment.NewLine;    
                    // If the proccess of the command fails, print a message to the terminal including the exception message
                }
            }

        }

        /// <summary>
        /// Runs the code without drawing anything to the drawingBox, this checks for any Sytax errors typed in the commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns> Will return which commands have sytax errors to the Terminal (if any)</returns>
        private void syntaxButton_Click(object sender, EventArgs e)
        {
            draw.drawEnabled = false;       // turns drawing off so just the validation is run

            for (int i = 0; i < commandBox.Lines.Length; i++)       // loops through the lines in the commandBox
            {

                string line = commandBox.Lines[i];

                try
                {
                    Command command = shapeFactory.processCommand(line);       //  passes the commmand from the line

                    command.runCommand(draw, varStorage, methodStorage);       //  proccesses the commmand
                }
                catch (Exception ex)
                {
                    Terminal.Text += ex.Message + " For Command: " + line + " on Line : " + (i+1) + Environment.NewLine;    
                    // If the proccess of the command fails, print a message to the terminal including the exception message
                }
            }

            draw.drawEnabled = true;        // turns drawing back on 
        }

        /// <summary>
        /// Stops the Threads running when X is pressed on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            draw.runFlag = false;   // when the form is closed the thread is stopped and the programme stops running
        }
    }
}
