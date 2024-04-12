namespace SE4_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            drawingBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            commandBox = new RichTextBox();
            commandLine = new TextBox();
            runButton = new Button();
            syntaxButton = new Button();
            Terminal = new TextBox();
            runProgram = new Button();
            ((System.ComponentModel.ISupportInitialize)drawingBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // drawingBox
            // 
            drawingBox.BackColor = SystemColors.ControlLight;
            drawingBox.Location = new Point(439, 41);
            drawingBox.Name = "drawingBox";
            drawingBox.Size = new Size(481, 573);
            drawingBox.TabIndex = 0;
            drawingBox.TabStop = false;
            drawingBox.Paint += drawingBox_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(932, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Image = (Image)resources.GetObject("fileToolStripMenuItem.Image");
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(66, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(74, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // commandBox
            // 
            commandBox.BackColor = SystemColors.HighlightText;
            commandBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            commandBox.Location = new Point(12, 41);
            commandBox.Name = "commandBox";
            commandBox.Size = new Size(421, 505);
            commandBox.TabIndex = 2;
            commandBox.Text = "";
            // 
            // commandLine
            // 
            commandLine.BackColor = SystemColors.HighlightText;
            commandLine.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            commandLine.Location = new Point(12, 552);
            commandLine.Name = "commandLine";
            commandLine.Size = new Size(421, 25);
            commandLine.TabIndex = 3;
            // 
            // runButton
            // 
            runButton.BackColor = SystemColors.ButtonFace;
            runButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            runButton.Location = new Point(12, 585);
            runButton.Name = "runButton";
            runButton.Size = new Size(94, 29);
            runButton.TabIndex = 4;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += runButton_Click;
            // 
            // syntaxButton
            // 
            syntaxButton.BackColor = SystemColors.ButtonFace;
            syntaxButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            syntaxButton.Location = new Point(339, 585);
            syntaxButton.Name = "syntaxButton";
            syntaxButton.Size = new Size(94, 29);
            syntaxButton.TabIndex = 5;
            syntaxButton.Text = "Syntax";
            syntaxButton.UseVisualStyleBackColor = false;
            syntaxButton.Click += syntaxButton_Click;
            // 
            // Terminal
            // 
            Terminal.BackColor = SystemColors.InfoText;
            Terminal.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Terminal.ForeColor = SystemColors.HighlightText;
            Terminal.Location = new Point(12, 620);
            Terminal.Multiline = true;
            Terminal.Name = "Terminal";
            Terminal.Size = new Size(908, 229);
            Terminal.TabIndex = 6;
            // 
            // runProgram
            // 
            runProgram.BackColor = SystemColors.MenuBar;
            runProgram.BackgroundImage = (Image)resources.GetObject("runProgram.BackgroundImage");
            runProgram.BackgroundImageLayout = ImageLayout.Stretch;
            runProgram.FlatAppearance.BorderSize = 0;
            runProgram.FlatStyle = FlatStyle.Flat;
            runProgram.Location = new Point(377, 0);
            runProgram.Name = "runProgram";
            runProgram.Size = new Size(25, 28);
            runProgram.TabIndex = 7;
            runProgram.UseVisualStyleBackColor = false;
            runProgram.Click += runProgram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 861);
            Controls.Add(runProgram);
            Controls.Add(Terminal);
            Controls.Add(syntaxButton);
            Controls.Add(runButton);
            Controls.Add(commandLine);
            Controls.Add(commandBox);
            Controls.Add(drawingBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)drawingBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox drawingBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private RichTextBox commandBox;
        private TextBox commandLine;
        private Button runButton;
        private Button syntaxButton;
        private TextBox Terminal;
        private ToolStripMenuItem newToolStripMenuItem;
        private Button runProgram;
    }
}
