﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services.Models;

#nullable disable

namespace Services.Migrations
{
    [DbContext(typeof(Recipe_Organizer_PRN211Context))]
    partial class Recipe_Organizer_PRN211ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Collection", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("RecipeId", "UserId");

                    b.HasIndex(new[] { "UserId" }, "IX_Collection_user_id");

                    b.ToTable("Collection", (string)null);
                });

            modelBuilder.Entity("RecipeHasCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.HasKey("CategoryId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Recipe_has_Categories", (string)null);
                });

            modelBuilder.Entity("Services.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Services.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("feedback_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("FeedbackId");

                    b.HasIndex(new[] { "UserId" }, "IX_Feedback_user_id");

                    b.ToTable("Feedback", (string)null);
                });

            modelBuilder.Entity("Services.Models.MealPlanning", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("plan_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanId"), 1L, 1);

                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.Property<string>("Session")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("session");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<DateTime>("WeekStartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("week_start_date");

                    b.HasKey("PlanId");

                    b.HasIndex("RecipeId");

                    b.HasIndex(new[] { "UserId" }, "IX_MealPlanning_user_id");

                    b.ToTable("MealPlanning", (string)null);
                });

            modelBuilder.Entity("Services.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("img");

                    b.Property<string>("Ingredient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ingredient");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("RecipeId");

                    b.HasIndex(new[] { "UserId" }, "IX_Recipe_user_id");

                    b.ToTable("Recipe", (string)null);
                });

            modelBuilder.Entity("Services.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role_name");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Services.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("avatar");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime")
                        .HasColumnName("birthday");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "Role" }, "IX_User_role");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Collection", b =>
                {
                    b.HasOne("Services.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_Collection_Recipe");

                    b.HasOne("Services.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Collection_User");
                });

            modelBuilder.Entity("RecipeHasCategory", b =>
                {
                    b.HasOne("Services.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_has_Categories_Category");

                    b.HasOne("Services.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_has_Categories_Recipe");
                });

            modelBuilder.Entity("Services.Models.Feedback", b =>
                {
                    b.HasOne("Services.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Models.MealPlanning", b =>
                {
                    b.HasOne("Services.Models.Recipe", "Recipe")
                        .WithMany("MealPlannings")
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_MealPlanning_Recipe");

                    b.HasOne("Services.Models.User", "User")
                        .WithMany("MealPlannings")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_MealPlanning_User");

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Models.Recipe", b =>
                {
                    b.HasOne("Services.Models.User", "User")
                        .WithMany("RecipesNavigation")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Models.User", b =>
                {
                    b.HasOne("Services.Models.Role", "RoleNavigation")
                        .WithMany("Users")
                        .HasForeignKey("Role")
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.Navigation("RoleNavigation");
                });

            modelBuilder.Entity("Services.Models.Recipe", b =>
                {
                    b.Navigation("MealPlannings");
                });

            modelBuilder.Entity("Services.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Services.Models.User", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("MealPlannings");

                    b.Navigation("RecipesNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
