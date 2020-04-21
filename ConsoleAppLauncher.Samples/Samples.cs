using System;
using System.Windows.Forms;

namespace SlavaGu.ConsoleAppLauncher.Samples
{
    public partial class Form1 : Form
    {
        #region Public Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void buttonGetIpAddress_Click(object sender, EventArgs e)
        {
            labelIpAddress.Text = SysInfo.GetIpAddress();
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            SysInfo.PingUrl("google.com", reply => BeginInvoke((MethodInvoker)delegate { labelPing.Text = reply; }));
        }

        private void buttonSkype_Click(object sender, EventArgs e)
        {
            labelSkype.Text = SysInfo.GetFirewallRule("Skype");
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            labelVer.Text = SysInfo.GetWindowsVersion();
        }

        #endregion Private Methods
    }
}