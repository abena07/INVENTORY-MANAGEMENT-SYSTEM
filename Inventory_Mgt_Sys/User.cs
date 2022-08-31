using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlX.XDevAPI.Relational;

namespace Inventory_Mgt_Sys
{
	internal class User

	{
		Db_Connection _connection;
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private DateOnly dob;

		public DateOnly Dob
		{
			get { return dob; }
			set { dob = value; }
		}

		private string userName;

		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		private string role;

		public string Role
		{
			get { return role; }
			set { role = value; }
		}

		private string gender;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}


		public User(string firstName, string lastName, string dob, string role, string password, string userName, string gender)
		{

			this.userName = userName;
			this.firstName = firstName;
			this.lastName = lastName;
			this.role = role;
			this.password = password;
			this.dob = DateOnly.Parse(dob, new CultureInfo("fr-FR"));
			this.gender = gender;


		}

		//a query to create a new user
		public void CreateUser()
		{
			_connection = new();
			MessageBox.Show(dob+"");
			String insertQuery = $"INSERT INTO user(firstName, lastName, dob,role, password, userName, gender)" +
				$"VALUES('{firstName}','{lastName}', STR_TO_DATE('{dob}', '%Y/%m/%d') ,'{role}','{password}', '{userName}','{gender}')";
			try
			{
				MySqlCommand cmd = new(insertQuery, _connection.conn);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User has been added successfully!");


			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("fuss");
				MessageBox.Show("User already exists");

			}
		}
		//function to update user
		public void UpdateUser()
		{
			_connection = new();
			string updateQuery = $"UPDATE user SET firstName='{firstName}', lastName='{lastName}', dob=STR_TO_DATE({dob},'%m/%d/%Y')," +
				$"role='{role}', password='{password}',userName='{userName}',gender='{gender}' WHERE userName='{userName}'";
			try
			{
				MySqlCommand cmd = new(updateQuery, _connection.conn);
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("fuss");
				MessageBox.Show("User has sucessfully been updated");

			}
		}


        //function to view all users
        public static void View(TableLayoutPanel table)
        {
            Db_Connection _connection = new();
            String sql, Output = "";
            string viewQuery = $"SELECT firstName,lastName, dob, role, userName, gender FROM user";
            MySqlCommand cmd = new(viewQuery, _connection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
			
			int row = 0;
            while (reader.Read())
				
            {
               // Output = Output + reader.GetValue(0) + " - " + reader.GetValue(1) + "/n";
				Label label = new Label()
				{
					Text = reader["firstName"].ToString(),
				};
                table.Controls.Add(label, 1, row);

                Label label2 = new Label()
                {
                    Text = reader["lastName"].ToString(),
                };
                table.Controls.Add(label2, 2, row);

				Label label3 = new Label()
				{
					Text = DateTime.ParseExact(reader["dob"].ToString(), "d/M/yyyy hh:mm:ss", CultureInfo.InvariantCulture).ToString()
                };
                table.Controls.Add(label3, 3, row);

                Label label4 = new Label()
                {
                    Text = reader["role"].ToString(),
                };
                table.Controls.Add(label4, 4, row);

                Label label5 = new Label()
                {
                    Text = reader["userName"].ToString(),
                };
                table.Controls.Add(label5, 5, row);

                Label label6 = new Label()
                {
                    Text = reader["gender"].ToString(),
                };
                table.Controls.Add(label6, 6, row);
				 row++;
            }

        }

        //function to delete user

        public void DeleteUser(string username)
		{
			_connection = new();
            string deleteQuery = $"DELETE FROM user WHERE userName = '{username}'";
            try
            {
                MySqlCommand cmd = new(deleteQuery, _connection.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("fuss");
                MessageBox.Show("User has been deleted");

            }
        }

        /// function to search for a user
        public static User Search(string username)
		{
			Db_Connection _connection = new();
			string searchQuery = $"SELECT * FROM user WHERE userName = '{username}'";
			User userFound = null;
			try
			{
				MySqlCommand cmd = new(searchQuery, _connection.conn);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					
					string firstName = reader["firstName"].ToString()!;
					string lastName = reader["lastName"].ToString()!;
					string userName = reader["userName"].ToString()!;
					string dob = DateTime.ParseExact(reader["dob"].ToString()!, "yyyy/M/d hh:mm:ss", 
						CultureInfo.InvariantCulture).ToString("d/M/yyyy", CultureInfo.InvariantCulture);

                    string role = reader["role"].ToString()!;
					string password = reader["password"].ToString()!;
					string gender = reader["gender"].ToString()!;
                    Console.WriteLine("Here's the date"+dob);
                    userFound = new(firstName, lastName, dob, role, password, userName, gender);
				}

				return userFound;
            }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			return userFound;

        }
	}

	
}
