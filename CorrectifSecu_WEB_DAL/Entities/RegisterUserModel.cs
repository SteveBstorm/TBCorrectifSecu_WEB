using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifSecu_WEB_DAL.Entities
{
    public class RegisterUserModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Nickname { get; set; }

        public IEnumerable<int> FavoriteId { get; set; }
    }
}
