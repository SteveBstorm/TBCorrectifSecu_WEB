using CorrectifSecu_WEB.Models;
using CorrectifSecu_WEB_DAL.Entities;

namespace CorrectifSecu_WEB.Tools
{
    public static class Mappers
    {
        public static RegisterUserModel ToDal(this RegisterForm form)
        {
            return new RegisterUserModel
            {
                Email = form.Email,
                FavoriteId = form.FavoriteBeer,
                Nickname = form.Nickname,
                Password = form.Password
            };
        }
    }
}
