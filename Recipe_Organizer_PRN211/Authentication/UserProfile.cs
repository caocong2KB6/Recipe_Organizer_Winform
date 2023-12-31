﻿using Recipe_Organizer_PRN211.Recipe;
using Recipe_Organizer_PRN211.Utility;
using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Organizer_PRN211.Authentication
{
	public partial class UserProfile : Form
	{
		UserRepository _userRepository;
		public UserProfile()
		{
			_userRepository = new UserRepository();
			InitializeComponent();
		}

		private void UserProfile_Load(object sender, EventArgs e)
		{
			User user = _userRepository.getUser(AppContext.CurrentUser.Username);
			txtUsername.Text = user.Username;
			txtFirstname.Text = user.FirstName;
			txtLastname.Text = user.LastName;
			txtEmail.Text = user.Email;
			if (user.Birthday != null)
				dateBirthday.Text = user.Birthday.ToString();
			if (user.FirstName != null)
				txtWelcome.Text = "Hello " + user.FirstName;
			else
				txtWelcome.Text = "Hello " + user.Username;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			User user = _userRepository.getUser(AppContext.CurrentUser.Username);
			string firstName = txtFirstname.Text;
			string lastname = txtLastname.Text;
			DateTime birhday = dateBirthday.Value;
			string email = txtEmail.Text;

			if (firstName.Length == 0)
			{
				MessageBox.Show("First name not empty", "Warning");
				return;
			}
			if (lastname.Length == 0)
			{
				MessageBox.Show("Last name not empty", "Warning");
				return;
			}
			if (email.Length == 0)
			{
				MessageBox.Show("Email not empty", "Warning");
				return;
			}
			if (!EmailService.IsValidEmail(email))
			{
                MessageBox.Show("Invalid email format", "Warning");
                return;
            }
			user.FirstName = firstName.Trim();
			user.LastName = lastname.Trim();
			user.Email = email.Trim();
			user.Birthday = birhday;

			_userRepository.Update(user);
			MessageBox.Show("Update successful", "Success");
			pageLoad();
		}

		private void pageLoad()
		{
			User user = _userRepository.getUser(AppContext.CurrentUser.Username);
			if (user.Birthday != null)
				dateBirthday.Text = user.Birthday.ToString();
			if (user.FirstName != null)
				txtWelcome.Text = "Hello " + user.FirstName;
			else
				txtWelcome.Text = "Hello " + user.Username;
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			Form changePassword = new ChangePassword();
			this.Hide();
			changePassword.Show();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form login = new Homepage();
			this.Hide();
			login.Show();
		}

		private void btnLogo_Click(object sender, EventArgs e)
		{
			Form listRecipe = new SearchRecipe();
			this.Hide();
			listRecipe.ShowDialog();
		}
	}
}
