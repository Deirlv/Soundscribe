namespace Soundscribe.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string DateOfBirth { get; set; }

        public string Password { get; set; }

        public int IsAdmin { get; set; }
    }
}
