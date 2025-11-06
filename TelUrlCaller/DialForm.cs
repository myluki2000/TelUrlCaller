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
    public partial class DialForm : Form
    {
        public DialForm(string phoneNumber = "")
        {
            InitializeComponent();
            tbPhoneNumber.Text = phoneNumber;
        }

        private async void btnCall_Click(object sender, EventArgs e)
        {
            await Call();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void DialForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.AskBeforeDial && string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                this.Close();
                await Call();
            }
        }

        private async Task Call()
        {
            HttpResponseMessage res = await Dialer.Call(
                tbPhoneNumber.Text, 
                Properties.Settings.Default.Username, 
                Properties.Settings.Default.Password);
            if (!res.IsSuccessStatusCode)
            {
                MessageBox.Show("Failed to dial number. Response code: " + res.StatusCode);
            }
        }
    }
}
