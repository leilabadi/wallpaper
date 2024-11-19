namespace Wallpaper
{
    public partial class FormMain : FormHidden
    {
        private readonly string _imagePath;

        public FormMain()
        {
            InitializeComponent();

            _imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image.jpg");

            if (!File.Exists(_imagePath))
            {
                MessageBox.Show("Image not found!");
            }

            if (Screen.PrimaryScreen == null)
            {
                MessageBox.Show("Primary Screen not found!");
            }

            InitializeForm(this, Screen.PrimaryScreen);

            foreach (var screen in Screen.AllScreens)
            {
                if ((screen == null) || screen.Primary) continue;

                FormHidden form = new();
                InitializeForm(form, screen);

                form.Show();
                form.SendToBack();
            }
        }

        private void InitializeForm(Form form, Screen screen)
        {
            this.SuspendLayout();

            form.Enabled = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.StartPosition = FormStartPosition.Manual;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = screen.WorkingArea.Location;
            form.Size = screen.WorkingArea.Size;
            form.BackColor = Color.FromArgb(0, 0, 35);
            form.ContextMenuStrip = contextMenuStripMain;

            form.BackgroundImage = new System.Drawing.Bitmap(_imagePath);
            form.BackgroundImageLayout = ImageLayout.Center;

            form.Shown += Form_Shown;

            this.ResumeLayout(false);
        }

        private void Form_Shown(object? sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
