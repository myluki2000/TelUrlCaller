using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelUrlCaller
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            Bitmap icon = Properties.Resources.call_24dp_48752C_FILL0_wght400_GRAD0_opsz24;
            this.Icon = Icon.FromHandle(icon.GetHicon());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ActionUri = tbActionUri.Text;
            Properties.Settings.Default.Username = tbUsername.Text;
            Properties.Settings.Default.Password = tbPassword.Text;
            Properties.Settings.Default.AskBeforeDial = cbAskBeforeDial.Checked;
            Properties.Settings.Default.AlwaysOnTop = cbAlwaysOnTop.Checked;
            Properties.Settings.Default.NormalizeNumbers = cbNormalizeNumbers.Checked;
            Properties.Settings.Default.CountryCode = tbCountryCode.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            tbActionUri.Text = Properties.Settings.Default.ActionUri;
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;
            cbAskBeforeDial.Checked = Properties.Settings.Default.AskBeforeDial;
            cbAlwaysOnTop.Checked = Properties.Settings.Default.AlwaysOnTop;
            cbNormalizeNumbers.Checked = Properties.Settings.Default.NormalizeNumbers;

            tbCountryCode.Enabled = cbNormalizeNumbers.Checked;
            tbCountryCode.Text = Properties.Settings.Default.CountryCode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNormalizeNumbers_CheckedChanged(object sender, EventArgs e)
        {
            tbCountryCode.Enabled = cbNormalizeNumbers.Checked;
        }
    }
}
