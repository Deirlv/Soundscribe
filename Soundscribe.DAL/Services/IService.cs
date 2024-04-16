using Soundscribe.DAL.Entities;

namespace Soundscribe.DAL.Services
{
    public enum UserStatus
    {
        Available, NotAvailableUsername, NotAvailableEmail
    }

    public interface IService
    {
        public void Add(object entity);

        public void Remove(object entity);

        public void Update(object entity);

        public List<User> GetAllUsers();

        public User? GetUserByID(int id);

        public Statistic? GetStatisticByUserID(int id);

        public User? FindUserByName(string userName);

        public UserStatus IsUserUnique(User user);

        public bool CheckAdmin(User user);
    }
}
