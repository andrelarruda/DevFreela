namespace DevFreela.API.Models
{
    public class CommentViewModel
    {
        public CommentViewModel(string userName, string content)
        {
            UserName = userName;
            Content = content;
        }
        public string UserName { get; set; }
        public string Content { get; set; }
    }
}
