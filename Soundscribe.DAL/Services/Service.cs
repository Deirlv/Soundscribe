using Microsoft.EntityFrameworkCore;
using Soundscribe.DAL.Entities;
using Soundscribe.DAL.Repositories;
using System.Linq.Expressions;

namespace Soundscribe.DAL.Services
{
    public class Service : IService
    {
        private readonly Repository _repository;

        public Service(Context context)
        {
            _repository = new Repository(context);
        }
        public void Add(object entity)
        {
            _repository.Add(entity);
        }
        public void Remove(object entity)
        {
            _repository.Delete(entity);
        }

        public void Update(object entity)
        {
            _repository.Update(entity);
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetAll<User>();
        }

        public User? FindUserByName(string userName)
        {
            return _repository.GetAll<User>().FirstOrDefault(u => u.Username == userName);
        }
        public User? GetUserByID(int id)
        {
            return _repository.GetById<User>(id);
        }

        public Statistic? GetStatisticByUserID(int id)
        {
            return _repository.GetAll<Statistic>().Where(s => s.UserId == id).FirstOrDefault(); 
        }

        public UserStatus IsUserUnique(User user)
        {
            bool isUsernameExists = _repository.GetAll<User>().Any(u => u.Username == user.Username);
            bool isEmailExists = _repository.GetAll<User>().Any(u => u.Email == user.Email);

            if (!isUsernameExists && !isEmailExists)
            {
                return UserStatus.Available;
            }
            if (isUsernameExists)
            {
                return UserStatus.NotAvailableUsername;
            }
            return UserStatus.NotAvailableEmail;
        }

        public bool CheckAdmin(User user)
        {
            if(GetAllUsers().Count == 0) 
            {
                user.IsAdmin = 1;
                return true;
            }
            if(user.IsAdmin == 1) 
            {
                return true;
            }
            return false;
        }
    }
}
