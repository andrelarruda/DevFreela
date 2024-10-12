using DevFreela.API.Entities;
using DevFreela.API.Enums;
using Microsoft.Data.SqlClient;

namespace DevFreela.API.Models
{
    public class ProjectItemViewModel
    {
        public ProjectItemViewModel(int id, string title, string clientName, string freelancerName, decimal totalCost, List<CommentViewModel> comments)
        {
            Id = id;
            Title = title;
            ClientName = clientName;
            FreelancerName = freelancerName;
            TotalCost = totalCost;
            Comments = comments;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string ClientName { get; private set; }
        public string FreelancerName { get; private set; }
        public decimal TotalCost { get; private set; }
        public List<CommentViewModel> Comments { get; } = [];

        public static ProjectItemViewModel FromEntity(Project project) => new(project.Id, project.Title, project.Client.FullName, project.Freelancer.FullName, project.TotalCost, project.Comments.Select(c => new CommentViewModel(c.User.FullName, c.Content)).ToList());
    }
}
