namespace Wallpaper
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            contextMenuStripMain = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStripMain
            // 
            contextMenuStripMain.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            contextMenuStripMain.Name = "contextMenuStrip1";
            contextMenuStripMain.Size = new Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 35);
            ClientSize = new Size(800, 450);
            Name = "FormMain";
            Text = "Wallpaper";
            contextMenuStripMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStripMain;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
