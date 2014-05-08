using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MailerChimp_2
{
    public partial class addRecipient : Telerik.WinControls.UI.RadForm
    {
        Recipients recpt = new Recipients();
        int initY = 27;
        int maxAdd = 10;
        int initAdd = 1;
        
        public addRecipient()
        {
            InitializeComponent();
            radlblWarning.Visible = false;
        }

        /*
         * needs validation with email and names
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            recpt.loadNewEmails(panel1);
            recpt.insertNewEmails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (initAdd != maxAdd)
            {
                TextBox txF = new TextBox();
                TextBox txL = new TextBox();
                TextBox txM = new TextBox();

                initY += 36;

                recpt.addTextBox(txF, 6, initY, 220, 30, "txtFname" + initAdd.ToString());
                recpt.addTextBox(txL, 235, initY, 220, 30, "txtLname" + initAdd.ToString());
                recpt.addTextBox(txM, 464, initY, 220, 30, "txtEmail" + initAdd.ToString());
                btnAdd.Location = new Point(690, initY);
                btnRemove.Location = new Point(727, initY);

                initAdd++;

                this.panel1.Controls.Add(txF);
                this.panel1.Controls.Add(txL);
                this.panel1.Controls.Add(txM);
            }
            else
            {
                btnAdd.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail0_TextChanged(object sender, EventArgs e)
        {
            //recpt.duplicateDetector(txtEmail0);
        }

    }
}
