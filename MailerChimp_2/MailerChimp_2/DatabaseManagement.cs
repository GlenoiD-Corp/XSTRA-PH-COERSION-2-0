using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MailerChimp_2
{
	class DatabaseManagement
	{
		MySqlConnection conn;
		MySqlCommand cmd;
		MySqlDataReader dr;
		String connStr;
		String sqlStr;

		private void connectionStrings()
		{
			connStr = "server=localhost;user=root;port=3306;password=password;database=hello;";
			conn = new MySqlConnection(connStr);
			cmd = conn.CreateCommand();
		}

		public void createDb()
		{
			connStr = "server=localhost;user=root;port=3306;password=password;";
			conn = new MySqlConnection(connStr);
			cmd = conn.CreateCommand();
			conn.Open();
			
			sqlStr = "CREATE DATABASE IF NOT EXISTS `hello`;";
			cmd.CommandText = sqlStr;
			cmd.ExecuteNonQuery();

			conn.Close();
		}

		public void createTables()
		{
			connectionStrings();
			conn.Open();

			sqlStr = "select count(*) from information_schema.tables where TABLE_NAME='tblrecipients' AND TABLE_SCHEMA='hello'";
			cmd.CommandText = sqlStr;
			//cmd.ExecuteNonQuery();
			//dr = new MySqlDataReader();
			dr = cmd.ExecuteReader();

			if (!dr.HasRows)
			{
				sqlStr = @"CREATE TABLE `tblrecipients`
					`rptNo` INT(11) NOT NULL,
					`rptFname` TINYTEXT NOT NULL,
					`rptLName` TINYTEXT NOT NULL,
					`rptEmail` VARCHAR(255) NOT NULL,
					`rptList` VARCHAR(255) NOT NULL,
					`rptGroups` VARCHAR(255) NOT NULL,
					`rptIsActive` INT(1) NOT NULL,
					`rptDateAdded` DATE NOT NULL,
					PRIMARY KEY (`rptNo`)
					)
					ENGINE=InnoDB;
					END";
			}

			cmd.CommandText = sqlStr;
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		
	}
}
