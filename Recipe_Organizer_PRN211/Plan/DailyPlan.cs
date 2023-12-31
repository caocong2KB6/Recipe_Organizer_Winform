﻿using Services.Models;
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

namespace Recipe_Organizer_PRN211.Plan
{
    public partial class DailyPlan : Form
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;

            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            dtpkDate.Value = Date;

        }

        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }

        }

        void AddJob(PlanItem job)
        {
            ARecipe ARecipe = new ARecipe(job);
            ARecipe.Edited += ARecipe_Edited;
            ARecipe.Deleted += ARecipe_Deleteed;

            fPanel.Controls.Add(ARecipe);

        }

        void ARecipe_Deleteed(object sender, EventArgs e)
        {
            ARecipe uc = sender as ARecipe;
            PlanItem job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        void ARecipe_Edited(object sender, EventArgs e)
        {
            if (Plan.AppContext.planItem != null && Plan.AppContext.planItem.RecipeId > 0)
            {
                ARecipe uc = sender as ARecipe;
                PlanItem job = uc.Job;
                var plan = Plan.AppContext.planItem;
                int count = 0;
                foreach (PlanItem item in Job.Job)
                {
                    if (item.RecipeId.Equals(plan.RecipeId) && item.Date.Equals(job.Date) && item.Status.Equals(job.Status))
                    {
                        count++;

                    }
                }
                if (count == 0)
                {
                    job.RecipeId = plan.RecipeId;
                }
            }



        }

        List<PlanItem> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void btnPrevioursDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void mnsiAddJob_Click(object sender, EventArgs e)
        {
            int userId = Recipe_Organizer_PRN211.Authentication.AppContext.CurrentUser.UserId;

            PlanItem item = new PlanItem() { Date = dtpkDate.Value, RecipeId = -1, UserId = userId, Status = "Breakfast" };
            if (Job.Job == null)
            {
                Job = new PlanData();
                Job.Job = new List<PlanItem> { item };
            }
            Job.Job.Add(item);
            AddJob(item);
        }

        private void mnsiToDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void DailyPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Plan.AppContext.planData = Job;
        }

        private void btsmiQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
