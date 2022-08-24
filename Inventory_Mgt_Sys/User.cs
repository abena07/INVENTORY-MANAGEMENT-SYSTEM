using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mgt_Sys
{
    internal class User
    {
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

		private DateOnly dateOfBirth;

		public DateOnly DateOfBirth
		{
			get { return dateOfBirth; }
			set { dateOfBirth = value; }
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

		public User(string firstName, string lastName,string dateOfBirth,string role,string password, string userName)
		{

			this.userName = userName;
			this.firstName = firstName;
			this.lastName = lastName;
            this.role = role;
			this.password = password;
			this.dateOfBirth = DateOnly.Parse(dateOfBirth);


        }




	}
}
