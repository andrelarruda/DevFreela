namespace DevFreela.API.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, int projectId, int userId) : base()
        {
            Content = content;
            this.projectId = projectId;
            this.userId = userId;
        }

        public string Content { get; private set; }
        public int projectId { get; private set; }
        public Project Project { get; private set; }
        public int userId { get; private set; }
        public User User { get; private set; }

    }
}
