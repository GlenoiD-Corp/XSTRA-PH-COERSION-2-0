using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using System.IO;
using MySql.Data.MySqlClient;

namespace MailerChimp_2
{
    class Administration
    {
        /*
         * this for deactivating and reactivating rpv's (rpvMainMenu)
         */
        public void radAdministrationGroupManager(Control btnSignal, int x)
        {
            foreach (Control ctrl in btnSignal.Controls)
            {
                if (ctrl.GetType() == typeof(RadPageView))
                {
                    if (((RadPageView)ctrl).Name == "rpvMainMenu")
                    {
                        if(x==0)
                            ((RadPageView)ctrl).Enabled = false;
                        else
                            ((RadPageView)ctrl).Enabled = true;
                    }
                }
            }
        }
        
        /* 
         * this will hide every button control, disable all textboxes
         * defined within the btnSignal parameter
        */
        public void radAdministrationGroupManager(Control btnSignal)
        {
            foreach (Control ctrl in btnSignal.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                    ((Button)ctrl).Hide();

                if (ctrl.GetType() == typeof(RadGroupBox))
                    ((RadGroupBox)ctrl).Show();

                if (ctrl.GetType() == typeof(TextBox))
                    ((TextBox)ctrl).ReadOnly = true;

                if (ctrl.HasChildren)
                    radAdministrationGroupManager(ctrl);
            }
        }

        /*
         * this will just show the current groupbox
         * that the user clicks for setup
         */
        public void radAdministrationGroupManager(Control btnSignal, string s)
        {
            foreach (Control ctrl in btnSignal.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    if (((Button)ctrl).Name == "cancel" + s || ((Button)ctrl).Name == "save" + s || ((Button)ctrl).Name == "find" + s)
                        ((Button)ctrl).Show();
                    else
                        ((Button)ctrl).Hide();
                }

                if (ctrl.GetType() == typeof(RadGroupBox))
                {
                    if (((RadGroupBox)ctrl).Name != "radGroup" + s)
                        ((RadGroupBox)ctrl).Hide();
                    else
                        ((RadGroupBox)ctrl).Show();
                }

                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).ReadOnly = false;
                }

                if (ctrl.HasChildren)
                    radAdministrationGroupManager(ctrl, s);
            }
        }

        /*
         * this will update the administration setup
         * in the database_xmailer
         */ 
        public void updateConfiguration(String x, String y)
        {
            if (x != "" && y != "")
            {
                String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
                String sql = "UPDATE tbladministration SET " + x + " = '" + y + "'";

                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

    }
}
