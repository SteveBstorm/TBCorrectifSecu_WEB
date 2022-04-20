using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifSecu_WEB_DAL.Entities
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Degree { get; set; }
        public string Origin { get; set; }
    }
}
