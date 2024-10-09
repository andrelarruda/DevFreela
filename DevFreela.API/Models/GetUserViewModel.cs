using DevFreela.API.Entities;

namespace DevFreela.API.Models
{
    public class GetUserViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }

        public static GetUserViewModel FromEntity(User entity)
        {
            return new GetUserViewModel { FullName = entity.FullName, Email = entity.Email, BirthDate = entity.BirthDate, Active = entity.Active };
        }
    }
}
