﻿namespace Recipe_Organizer_PRN211.Authentication
{
	partial class AddRecipe
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			btnBack = new Button();
			groupBox1 = new GroupBox();
			label5 = new Label();
			label4 = new Label();
			btnAdd = new Button();
			txtImport = new TextBox();
			txtDescription = new TextBox();
			label1 = new Label();
			imgImage = new PictureBox();
			txtTitle = new TextBox();
			txtIngredient = new TextBox();
			label3 = new Label();
			Discription = new Label();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)imgImage).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackgroundImage = Properties.Resources._2707banhxeo;
			panel1.Controls.Add(btnBack);
			panel1.Controls.Add(groupBox1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1043, 555);
			panel1.TabIndex = 11;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Transparent;
			btnBack.BackgroundImage = Properties.Resources.left_arrow;
			btnBack.BackgroundImageLayout = ImageLayout.Zoom;
			btnBack.Location = new Point(31, 4);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(87, 51);
			btnBack.TabIndex = 27;
			btnBack.TextAlign = ContentAlignment.MiddleLeft;
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.AutoSize = true;
			groupBox1.BackColor = SystemColors.ButtonHighlight;
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(btnAdd);
			groupBox1.Controls.Add(txtImport);
			groupBox1.Controls.Add(txtDescription);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(imgImage);
			groupBox1.Controls.Add(txtTitle);
			groupBox1.Controls.Add(txtIngredient);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(Discription);
			groupBox1.Location = new Point(124, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(762, 467);
			groupBox1.TabIndex = 11;
			groupBox1.TabStop = false;
			groupBox1.Text = "Recipe";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(367, 23);
			label5.Name = "label5";
			label5.Size = new Size(91, 20);
			label5.TabIndex = 8;
			label5.Text = "ADD RECIPE";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(571, 379);
			label4.Name = "label4";
			label4.Size = new Size(51, 20);
			label4.TabIndex = 3;
			label4.Text = "Image";
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(336, 412);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(94, 29);
			btnAdd.TabIndex = 7;
			btnAdd.Text = "SAVE";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// txtImport
			// 
			txtImport.Location = new Point(19, 402);
			txtImport.Multiline = true;
			txtImport.Name = "txtImport";
			txtImport.Size = new Size(125, 27);
			txtImport.TabIndex = 10;
			txtImport.Visible = false;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(102, 239);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(313, 134);
			txtDescription.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 66);
			label1.Name = "label1";
			label1.Size = new Size(38, 20);
			label1.TabIndex = 0;
			label1.Text = "Title";
			// 
			// imgImage
			// 
			imgImage.BackColor = SystemColors.ActiveCaption;
			imgImage.Location = new Point(446, 63);
			imgImage.Name = "imgImage";
			imgImage.Size = new Size(291, 300);
			imgImage.TabIndex = 4;
			imgImage.TabStop = false;
			imgImage.Click += btImport_Click;
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(102, 63);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(313, 27);
			txtTitle.TabIndex = 1;
			// 
			// txtIngredient
			// 
			txtIngredient.Location = new Point(102, 126);
			txtIngredient.Multiline = true;
			txtIngredient.Name = "txtIngredient";
			txtIngredient.Size = new Size(313, 106);
			txtIngredient.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 126);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 2;
			label3.Text = "Ingredients";
			// 
			// Discription
			// 
			Discription.AutoSize = true;
			Discription.Location = new Point(19, 242);
			Discription.Name = "Discription";
			Discription.Size = new Size(70, 20);
			Discription.TabIndex = 1;
			Discription.Text = "Direction";
			// 
			// AddRecipe
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1043, 555);
			Controls.Add(panel1);
			Name = "AddRecipe";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AddRecipe";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)imgImage).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Label label2;
		private GroupBox groupBox1;
		private Label label5;
		private Label label4;
		private Button btnAdd;
		private TextBox txtImport;
		private TextBox txtDescription;
		private Label label1;
		private PictureBox imgImage;
		private TextBox txtTitle;
		private TextBox txtIngredient;
		private Label label3;
		private Label Discription;
		private Panel panel1;
		private Button btnBack;

	}
}