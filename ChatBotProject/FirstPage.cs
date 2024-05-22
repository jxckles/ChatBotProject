using System;
using System.Windows.Forms;

namespace ChatBotProject
{
    public partial class FirstPage : Form
    {
        private Form1 form1Instance;
        private Timer fadeInTimer;
        private Timer fadeOutTimer;

        public FirstPage(Form1 form1)
        {
            InitializeComponent();
            this.form1Instance = form1;
            panelForm.Controls.Add(pbxSmoke);
            pbxSmoke.Controls.Add(lblPercentage);
            pbxSmoke.Controls.Add(lblInitializingDatabase);
            pbxSmoke.Controls.Add(lblBuildVersion);
            pbxSmoke.Controls.Add(lblProgrammer);
            pbxSmoke.Controls.Add(lblKAI);
            pbxSmoke.Controls.Add(lblSlogan);
            pbxSmoke.Controls.Add(pbxBotGif);

            // Initialize and configure the timers
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 50; // Set the interval for smooth transition
            fadeInTimer.Tick += FadeInTimer_Tick;

            fadeOutTimer = new Timer();
            fadeOutTimer.Interval = 25; // Set a faster interval for faster fade-out
            fadeOutTimer.Tick += FadeOutTimer_Tick;
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.06; // Increase opacity gradually
            }
            else
            {
                fadeInTimer.Stop(); // Stop the timer when fully faded in
            }
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.3; // Increase the opacity decrement for faster fade-out
            }
            else
            {
                fadeOutTimer.Stop(); // Stop the timer when fully faded out
                form1Instance.Show(); // Show Form1 after fade out
                this.Hide(); // Hide FirstPage
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInitializingDatabase.Text = "";
            bool DatabaseIsEmpty = form1Instance.IsDatabaseEmpty();
            if (DatabaseIsEmpty)
            {
                lblInitializingDatabase.Text = "Initializing .aiml files...";
                progressbar.Width += 6;
            }
            else
            {
                lblInitializingDatabase.Text = "Initializing Database and .aiml files...";
                progressbar.Width += 2;
            }
            

            if (progressbar.Width >= 870)
            {
                timer1.Stop();

                // Start the fade out process
                fadeOutTimer.Start();
            }

            // Update the percentage label
            int percentage = (int)Math.Round((double)progressbar.Width / 870 * 100);
            lblPercentage.Text = $"{percentage}%";
        }

        private void FirstPage_Shown(object sender, EventArgs e)
        {
            // Start the fade in process
            fadeInTimer.Start();
        }

        private void lblKAI_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
