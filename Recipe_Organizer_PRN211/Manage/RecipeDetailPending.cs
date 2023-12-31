﻿using Recipe_Organizer_PRN211.Authentication;
using Recipe_Organizer_PRN211.Utility;
using Services.Service;
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
	public partial class RecipeDetailPending : Form
	{
		private RecipeRepository _recipeRepository;

		public RecipeDetailPending()
		{
			InitializeComponent();
			_recipeRepository = new RecipeRepository();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (Recipe_Organizer_PRN211.Authentication.AppContext.RecipeId > 0)
			{
				// Get the recipe from the database
				int recipeId = Recipe_Organizer_PRN211.Authentication.AppContext.RecipeId;
				Services.Models.Recipe recipe = _recipeRepository.GetRecipe(recipeId);

				if (recipe != null)
				{
					lbTitle.Text = recipe.Title;

					// Clear any existing controls in the table layout panel
					tlpIngredients.Controls.Clear();

					// Set the column and row styles to autosize
					tlpIngredients.ColumnStyles.Clear();
					tlpIngredients.RowStyles.Clear();
					tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

					// Add a row for each ingredient
					string[] ingredients = recipe.Ingredient.Split(new[] { "\\n" }, StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < ingredients.Length; i++)
					{
						tlpIngredients.RowStyles.Add(new RowStyle(SizeType.AutoSize));

						// Create a Label control for the ingredient
						Label ingredientLabel = new Label();
						ingredientLabel.Text = ingredients[i];
						ingredientLabel.AutoSize = true;

						// Add the Label control to the table layout panel
						tlpIngredients.Controls.Add(ingredientLabel, 0, i);
					}

					// Clear any existing controls in the table layout panel
					tlpDirection.Controls.Clear();
					recipePicture.Image = Base64.Base64ToImage(recipe.Img);
					// Set the column and row styles to autosize
					tlpDirection.ColumnStyles.Clear();
					tlpDirection.RowStyles.Clear();
					tlpDirection.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
					tlpDirection.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

					// Add a row for each step in the description
					string[] steps = recipe.Description.Split(new[] { "\\n" }, StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < steps.Length; i++)
					{
						tlpDirection.RowStyles.Add(new RowStyle(SizeType.AutoSize));

						// Create a Label control for the step description
						Label stepLabel = new Label();
						stepLabel.Text = $"Step {i + 1}: {steps[i]}";
						stepLabel.AutoSize = true;

						// Add the Label control to the table layout panel
						tlpDirection.Controls.Add(stepLabel, 0, i);
					}

					lbDate.Text = "Date: " + recipe.Date.ToString();
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{

		}

		private void lbDate_Click(object sender, EventArgs e)
		{

		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			if (Recipe_Organizer_PRN211.Authentication.AppContext.RecipeId > 0)
			{
				// Get the recipe from the database
				int recipeId = Recipe_Organizer_PRN211.Authentication.AppContext.RecipeId;
				_recipeRepository.updateRecipeStatus(recipeId, "Approve");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Cannot approve pending recipe", "Error", MessageBoxButtons.OK);
			}
		}

		private void btnReject_Click(object sender, EventArgs e)
		{
			if (Recipe_Organizer_PRN211.Authentication.AppContext.RecipeId > 0)
			{
				// Get the recipe from the database
				int recipeId = Recipe_Organizer_PRN211.Authentication.AppContext.RecipeId;
				_recipeRepository.updateRecipeStatus(recipeId, "Reject");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Cannot reject pending recipe", "Error", MessageBoxButtons.OK);
			}
		}

		private void btnBack_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
