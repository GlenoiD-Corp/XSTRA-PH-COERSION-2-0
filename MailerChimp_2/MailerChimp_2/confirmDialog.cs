using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Windows;

namespace MailerChimp_2
{
    public partial class confirmDialog : Telerik.WinControls.UI.RadForm
    {
        Administration admin = new Administration();
        MailerChimp mchimp = new MailerChimp();
        public confirmDialog()
        {
            InitializeComponent();
        }

        private void confirmDialog_Load(object sender, EventArgs e)
        {
            btnSave.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
