using CorrectifSecu_WEB_DAL.Entities;

namespace CorrectifSecu_WEB_DAL.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<AppUser> GetAll();
        UserDetails GetById(int id);
        AppUser Login(string email, string password);
        void Register(RegisterUserModel m);
    }
}