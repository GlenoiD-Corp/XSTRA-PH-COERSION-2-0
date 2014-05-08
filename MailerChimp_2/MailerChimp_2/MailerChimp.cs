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
using Telerik.WinControls;
using Telerik.Windows.Controls;
using Telerik.WinControls.Themes;
using System.IO;
using MySql.Data.MySqlClient;

namespace MailerChimp_2
{
    public partial class MailerChimp : Telerik.WinControls.UI.RadForm
    {
        Administration admin = new Administration();
        DatabaseManagement dbmgt = new DatabaseManagement();
        addRecipient addRep = new addRecipient();

        public MailerChimp()
        {
            InitializeComponent();
        }

        private void rpvMainMenu_SelectedPageChanged(object sender, EventArgs e)
        {
            String x = rpvMainMenu.SelectedPage.Text;
            rpvDetails.SelectedPage = rpvDetails.Pages["rpv" + x];

            if (x.Equals("Administration"))
                admin.radAdministrationGroupManager(rpvAdministration);
        }

        private void rpvMainMenu_Click(object sender, EventArgs e)
        {
            String x = rpvMainMenu.SelectedPage.Text;
            rpvDetails.SelectedPage = rpvDetails.Pages["rpv" + x];
            /*if (rpvMainMenu.Pages["rpv" + x].ToString().Equals("rpv" + x))
                rpvMainMenu.Pages["rpv" + x].Item.Visibility = ElementVisibility.Visible;
            else
                rpvMainMenu.Pages["rpv" + x].Item.Visibility = ElementVisibility.Collapsed;*/

            if (x.Equals("Administration"))
            {
                admin.radAdministrationGroupManager(rpvAdministration);
                
                String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
                String sql = "SELECT * FROM tbladministration";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    txtOutbound.Text = (dr.GetString("setOutboundServer"));
                    txtPort.Text = (dr.GetString("setPort"));
                    txtFrom.Text = (dr.GetString("setFrom"));
                    txtPickup.Text = (dr.GetString("setPickupFolder"));
                    txtEmail.Text = (dr.GetString("setEmail"));
                    txtFooter.Text = (dr.GetString("setFooter"));
                }

                conn.Close();
            }
            else if (x.Equals("Recipients"))
            {
                String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";

                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT rptFname AS 'First Name', rptLName AS 'Last Name', rptEmail AS 'Email Address' FROM tblrecipients", conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                dgvRecipients.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 12, FontStyle.Bold);
                dgvRecipients.Font =
                    new Font("Segoe UI", 10, FontStyle.Regular);
                dgvRecipients.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

        private void MailerChimp_Load(object sender, EventArgs e)
        {
            rpvDetails.SelectedPage = rpvDetails.Pages["rpvCampaigns"];
            rpvMainMenu.SelectedPage = rpvMainMenu.Pages["Campaigns"];
            rpvDetails.ViewElement.Visibility = ElementVisibility.Hidden;

            //dbmgt.createDb();
            //dbmgt.createTables();
        }

        private void saveOutbound_Click(object sender, EventArgs e)
        {
            savers(saveOutbound.Tag.ToString(), txtOutbound.Text.Trim());
        }

        private void savePickup_Click(object sender, EventArgs e)
        {
            savers(savePickup.Tag.ToString(), txtPickup.Text.Trim());
        }

        private void saveFrom_Click(object sender, EventArgs e)
        {
            savers(saveFrom.Tag.ToString(), txtFrom.Text.Trim());
        }

        private void saveEmail_Click(object sender, EventArgs e)
        {
            savers(saveEmail.Tag.ToString(), txtEmail.Text.Trim());
        }

        private void saveFooter_Click(object sender, EventArgs e)
        {
            savers(saveFooter.Tag.ToString(), txtFooter.Text.Trim());
        }

        private void cancelFrom_Click(object sender, EventArgs e)
        {
            cancellers();
        }

        private void cancelPickup_Click(object sender, EventArgs e)
        {
            cancellers();
        }

        private void cancelEmail_Click(object sender, EventArgs e)
        {
            cancellers();
        }

        private void cancelFooter_Click(object sender, EventArgs e)
        {
            cancellers();
        }

        private void cancelOutbound_Click(object sender, EventArgs e)
        {
            cancellers();
        }

        private void btnOutbound_Click(object sender, EventArgs e)
        {
            admin.radAdministrationGroupManager(rpvAdministration, btnOutbound.Tag.ToString());
            admin.radAdministrationGroupManager(pnlMain, 0);

        }

        private void btnPickup_Click(object sender, EventArgs e)
        {
            admin.radAdministrationGroupManager(rpvAdministration, btnPickup.Tag.ToString());
            admin.radAdministrationGroupManager(pnlMain, 0);
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            admin.radAdministrationGroupManager(rpvAdministration, btnFrom.Tag.ToString());
            admin.radAdministrationGroupManager(pnlMain, 0);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            admin.radAdministrationGroupManager(rpvAdministration, btnEmail.Tag.ToString());
            admin.radAdministrationGroupManager(pnlMain, 0);
        }

        private void btnFooter_Click(object sender, EventArgs e)
        {
            admin.radAdministrationGroupManager(rpvAdministration, btnFooter.Tag.ToString());
            admin.radAdministrationGroupManager(pnlMain, 0);
        }

        private void findPickup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            string path = fbd.SelectedPath.ToString();
            txtPickup.Text = path;
        }

        private void savers(String changeField, String newSetUp)
        {
            VisualStudio2012LightTheme rdthm = new VisualStudio2012LightTheme();
            DialogResult cnfrm;
            RadMessageBox.SetThemeName(rdthm.ThemeName);
            cnfrm = RadMessageBox.Show("Confirmation", "You've made some changes.\nSave these changes now?", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);

            if (cnfrm == DialogResult.OK)
            {
                MessageBox.Show("Changes saved.");
            }

            admin.radAdministrationGroupManager(pnlMain, 1);
            admin.radAdministrationGroupManager(rpvAdministration);
            admin.updateConfiguration(changeField, newSetUp);
        }
        
        public void cancellers()
        {
            admin.radAdministrationGroupManager(pnlMain, 1);
            admin.radAdministrationGroupManager(rpvAdministration);
        }

        private void txtRecipientSearch_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
            String sql = @"SELECT rptFname AS 'First Name', 
                            rptLName AS 'Last Name', 
                            rptEmail AS 'Email Address' 
                            FROM tblrecipients 
                            WHERE rptEmail LIKE '%" + txtRecipientSearch.Text.Trim() + "%'";
            
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            dgvRecipients.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            addRep.ShowDialog(this);
        }

        private void txtSearchCampaign_TextChanged(object sender, EventArgs e)
        {
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT cpnName AS 'Campaign' FROM tblcampaign WHERE cpnName LIKE '%" + txtSearchCampaign.Text + "%'", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            dgvCurrent.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
            dgvCurrent.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);
            dgvCurrent.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dgvCurrent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String cn = dgvCurrent.CurrentCell.Value.ToString();
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
            String sql = "SELECT * FROM tblcampaign WHERE cpnName = '" + cn + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblCampaignName.Text = (dr.GetString("cpnName"));
                lblDateDelivered.Text = (dr.GetString("cpnDeliveredDate"));
                lblRecipients.Text = (dr.GetString("cpnRecipients"));
                lblOpen.Text = (dr.GetString("cpnOpens"));
                lblClick.Text = (dr.GetString("cpnClicks"));

                double b = (dr.GetDouble("cpnRecipients"));
                double pOpen = (dr.GetDouble("cpnOpens"));
                double pClick = (dr.GetDouble("cpnClicks"));

                double rOpen = (pOpen / b) * 100;
                double rClick = (pClick / b) * 100;

                rprogOpen.Value1 = (int)rOpen;
                rprogClick.Value1 = (int)rClick;

                rprogOpen.Text = rOpen.ToString() + "%";
                rprogClick.Text = rClick.ToString() + "%";

            }

            conn.Close();
        }

        private void btnScheduled_Click(object sender, EventArgs e)
        {
            String x = btnScheduled.Tag.ToString();
            rpvDetails.SelectedPage = rpvDetails.Pages["rpv" + x];

            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT cpnName AS 'Campaign' FROM tblcampaign WHERE cpnIsScheduled = 1 AND cpnIsDeleted = 0", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            dgvScheduled.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
            dgvScheduled.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);
            dgvScheduled.DataSource = ds.Tables[0];
            conn.Close();
            cboScheduled.Visible = true;
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            String x = btnCurrent.Tag.ToString();
            rpvDetails.SelectedPage = rpvDetails.Pages["rpv" + x];

            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT cpnName AS 'Campaign' FROM tblcampaign WHERE cpnIsCurrent = 1 AND cpnIsDeleted = 0 LIMIT 5", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            dgvCurrent.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
            dgvCurrent.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);
            dgvCurrent.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            lblDelvrdCampaignName.Text = "-";

            String x = btnDelivered.Tag.ToString();
            rpvDetails.SelectedPage = rpvDetails.Pages["rpv" + x];

            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT cpnName AS 'Campaign' FROM tblcampaign WHERE cpnIsDelivered = 1 AND cpnIsDeleted = 0 LIMIT 5", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            dgvDelivered.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
            dgvDelivered.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);
            dgvDelivered.DataSource = ds.Tables[0];
            conn.Close();
            cboDelivered.Visible = true;
        }

        private void dgvScheduled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String cn = dgvScheduled.CurrentCell.Value.ToString();
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
            String sql = "SELECT * FROM tblcampaign WHERE cpnName = '" + cn + "' AND cpnIsScheduled = 1";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblSchedCampaignName.Text = (dr.GetString("cpnName"));
                lblSchedRecipients.Text = (dr.GetString("cpnRecipients"));
                lblSchedDate.Text = (dr.GetString("cpnScheduledDate"));
            }

            conn.Close();
        }

        private void dgvDelivered_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String cn = dgvDelivered.CurrentCell.Value.ToString();
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
            String sql = "SELECT * FROM tblcampaign WHERE cpnName = '" + cn + "' AND cpnIsDelivered = 1";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblDelvrdCampaignName.Text = (dr.GetString("cpnName"));
                lblDelvrdDate.Text = (dr.GetString("cpnDeliveredDate"));
                lblDelvrdRecipients.Text = (dr.GetString("cpnRecipients"));
                lblDelvrdOpen.Text = (dr.GetString("cpnOpens"));
                lblDelvrdClick.Text = (dr.GetString("cpnClicks"));

                double b = (dr.GetDouble("cpnRecipients"));
                double pOpen = (dr.GetDouble("cpnOpens"));
                double pClick = (dr.GetDouble("cpnClicks"));

                double rOpen = (pOpen / b) * 100;
                double rClick = (pClick / b) * 100;

                rprogDelvrdOpen.Value1 = (int)rOpen;
                rprogDelvrdClick.Value1 = (int)rClick;

                rprogDelvrdOpen.Text = rOpen.ToString() + "%";
                rprogDelvrdClick.Text = rClick.ToString() + "%";

            }

            conn.Close();
        }

        private void cboScheduled_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboScheduled.Text);

            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";

            String sql = "UPDATE tblcampaign SET cpnIsDeleted = 1 WHERE cpnName = '" + lblSchedCampaignName.Text.ToString() +  "'";

            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            btnScheduled.PerformClick();
        }

        private void cboDelivered_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboDelivered.Text);

            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";

            String sql = "UPDATE tblcampaign SET cpnIsDeleted = 1 WHERE cpnName = '" + lblDelvrdCampaignName.Text.ToString() + "'";

            conn = new MySqlConnection(connectionString);
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            btnDelivered.PerformClick();
        }

    }
}
