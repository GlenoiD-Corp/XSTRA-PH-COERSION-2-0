using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace MailerChimp_2
{
    class Recipients
    {
        //addRecipient addR;
        String[] fnames = new String[10];
        String[] lnames = new String[10];
        String[] emails = new String[10];

        public void addEmail(String f, String l, String e)
        {
            //String fname = f.Trim();
            //String lname = l.Trim();
            //String email = e.Trim();

            if (f.Trim() != null || l.Trim() != null || e.Trim() != null)
            {
                String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
                int userno = 0;

                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT rptNo FROM tblrecipients ORDER BY rptNo DESC LIMIT 1 ", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    userno = Int32.Parse(dr.GetString("rptNo")) + 1;
                }

                conn.Close();

                String sql = @"INSERT INTO tblrecipients(`rptNo`,`rptFName`,`rptLName`,`rptEmail`,`rptList`,`rptGroups`,`rptIsActive`,`rptDateAdded`)
                                VALUES(" + userno + ", '" + f + "', '" + l + "', '" + e + "', 'none', 'none', 1, '2014-05-05')";

                MessageBox.Show(sql);
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@fn", "l");
                //cmd.Parameters.AddWithValue("@ln", "lname");
                //cmd.Parameters.AddWithValue("@em", "email");
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void addTextBox(TextBox t, int x, int y, int s1, int s2, String objName)
        {
            t.Name = objName;
            t.Location = new Point(x, y);
            t.Size = new Size(s1, s2);
            t.BackColor = Color.SkyBlue;
            t.BorderStyle = BorderStyle.FixedSingle;
            t.Font = new Font("Segoe UI", 11);
            t.TextAlign = HorizontalAlignment.Center;
            t.Visible = true;
            //t.Click += new EventHandler(duplicateDetector(t.Text));
        }

        public void loadNewEmails(Control btnSignal)
        {
            foreach (Control ctrl in btnSignal.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    int l = ((TextBox)ctrl).Name.Length;
                    String strIndex = ((TextBox)ctrl).Name.Substring(l - 1, 1);
                    int intIndex = Int32.Parse(strIndex);

                    if(((TextBox)ctrl).Name.Contains("txtFname"))
                    {
                        fnames[intIndex] = ((TextBox)ctrl).Text.ToString().Trim();
                    }
                    else if (((TextBox)ctrl).Name.Contains("txtLname"))
                    {
                        lnames[intIndex] = ((TextBox)ctrl).Text.ToString().Trim();
                    }
                    else if (((TextBox)ctrl).Name.Contains("txtEmail"))
                    {
                        emails[intIndex] = ((TextBox)ctrl).Text.ToString().Trim();
                    }
                }

                if (ctrl.HasChildren)
                    loadNewEmails(ctrl);
            }
        }

        public void insertNewEmails()
        {
            string t = "";

            for (int x = 0; x < 10; x++)
            {
                t += x.ToString() + " - " + fnames[x] + " , " + lnames[x] + " , " + emails[x] + "\n";
                addEmail(fnames[x], lnames[x], emails[x]);
            }

            MessageBox.Show(t);
        }

        public bool emailCheckDuplicate(String e)
        {
            String connectionString = "Server=localhost;userid=root;password=password;database=database_xmailer";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT rptEmail FROM tblrecipients where rptEmail = '"+ e + "'", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            conn.Close();
            
            if (dr.HasRows)
                return true;
            else
                return false;
        }

        /*public void duplicateDetector(TextBox txbx)
        {
            bool duplicateDetected = emailCheckDuplicate(txbx);

            if (duplicateDetected)
            {
                txbx.BackColor = Color.Red;
                radlblWarning.Visible = true;
            }
            else
            {
                txbx.BackColor = Color.SkyBlue;
                radlblWarning.Visible = false;
            }
        }*/
    }
}
