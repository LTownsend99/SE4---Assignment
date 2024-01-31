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
            drawingBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            commandBox = new RichTextBox();
            commandLine = new TextBox();
            runButton = new Button();
            syntaxButton = new Button();
            Terminal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)drawingBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // drawingBox
            // 
            drawingBox.BackColor = SystemColors.ControlLightLight;
            drawingBox.Location = new Point(439, 41);
            drawingBox.Name = "drawingBox";
            drawingBox.Size = new Size(481, 573);
            drawingBox.TabIndex = 0;
            drawingBox.TabStop = false;
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
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(54, 24);
            saveToolStripMenuItem.Text = "Save";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 861);
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
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private RichTextBox commandBox;
        private TextBox commandLine;
        private Button runButton;
        private Button syntaxButton;
        private TextBox Terminal;
    }
}
