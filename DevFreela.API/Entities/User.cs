namespace DevFreela.API.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthdate) : base()
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthdate;
            Active = true;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
    }
}
