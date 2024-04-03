using System;
using System.Windows.Forms;

namespace Browsarium
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(addressTextBox.Text);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void addressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                addressTextBox.Text = addressTextBox.Text.Trim();
                webBrowser.Navigate(addressTextBox.Text);
            }
        }
    }
}
