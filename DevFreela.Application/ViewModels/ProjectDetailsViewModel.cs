using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description, decimal totalCost, DateTime startedAt, DateTime finishedAt, string clientFirstname, string clientLastname, string freelancerName)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            ClientFirstname= clientFirstname;
            ClientLastname= clientLastname;
            FreelancerName = freelancerName;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime StartedAt { get; private set; }
        public DateTime FinishedAt { get; private set; }
        public string ClientFirstname { get; private set; }
        public string ClientLastname { get; private set; }
        public string FreelancerName { get; private set; }
    }
}
