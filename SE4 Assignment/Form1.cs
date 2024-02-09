using System.Collections;
using System.Windows.Forms;

namespace SE4_Assignment
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            bitmap = new Bitmap(640, 480);
            InitializeComponent();


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
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
           String commandText = commandLine.Text;

            try
            {
                Command command = shapeFactory.proccessCommand(commandText);

                command.runCommand();
            }
            catch(Exception ex)
            {
                Terminal.Text = ex.Message;
            }
            commandLine.Text = "";
        }
    }
}
