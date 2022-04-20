using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifSecu_WEB_DAL.Entities
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Role { get; set; }
        public IEnumerable<Beer> favoriteBeers { get; set; }

    }
}
