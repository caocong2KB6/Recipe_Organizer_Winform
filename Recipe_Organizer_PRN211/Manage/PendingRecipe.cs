﻿using Services.Models;
using Services.Service;
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

namespace Recipe_Organizer_PRN211.Manage
{
	public partial class PendingRecipe : Form
	{
		RecipeRepository _recipeRepository;
		//Recipe recipe;
		public PendingRecipe()
		{
			_recipeRepository = new RecipeRepository();
			InitializeComponent();
			var recipeList = _recipeRepository.GetRecipeWithStatus("pending");
			dgvPendingRecipe.DataSource = new BindingSource()
			{
				DataSource = recipeList
			};
		}

		private void dgvPendingRecipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//chuột đang click ở dòng nào
			var recipeID = dgvPendingRecipe[0, e.RowIndex].Value;
			Recipe_Organizer_PRN211.Authentication.AppContext.RecipeId = (int)recipeID;
			Form pendingRecipe = new RecipeDetailPending();
			if (pendingRecipe.ShowDialog() == DialogResult.OK)
			{
				var recipeList = _recipeRepository.GetRecipeWithStatus("pending");
				dgvPendingRecipe.DataSource = new BindingSource()
				{
					DataSource = recipeList
				};
			}
			//var recipe = _recipeRepository.GetAll().Where(entity => entity.UserId.Equals(recipeID)).FirstOrDefault();
			//this.recipe = recipe;
			//if (recipe == null)
			//    return;

			//txtTitle.Text = recipe.Title;
			//txtDescription.Text = recipe.Description;
			//dateCreate.Text = recipe.Date.ToString();
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{

		}

		private void btnReject_Click(object sender, EventArgs e)
		{

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string searchValue = txtSearch.Text;
			if (searchValue.Length > 0)
			{
				var listRecipe = _recipeRepository.searchRecipeWithStatus(searchValue, "pending");

				dgvPendingRecipe.DataSource = new BindingSource()
				{
					DataSource = listRecipe
				};
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			var listRecipe = _recipeRepository.GetRecipeWithStatus("pending");
			dgvPendingRecipe.DataSource = new BindingSource()
			{
				DataSource = listRecipe
			};
		}

		private void dgvPendingRecipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvPendingRecipe_SelectionChanged(object sender, EventArgs e)
		{

		}
	}
}
