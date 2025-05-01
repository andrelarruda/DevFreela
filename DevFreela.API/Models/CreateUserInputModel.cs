using DevFreela.Core.Entities;

namespace DevFreela.Core.Models
{
    public class CreateUserInputModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public User ToEntity()
        {
            return new User(FullName, Email, BirthDate);
        }
    }
}
