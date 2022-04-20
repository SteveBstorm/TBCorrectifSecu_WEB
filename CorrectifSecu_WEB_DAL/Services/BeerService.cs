using ApiToolbox;
using CorrectifSecu_WEB_DAL.Entities;
using CorrectifSecu_WEB_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifSecu_WEB_DAL.Services
{
    public class BeerService : IBeerRepository
    {
        private ApiRequester _requester;
        public BeerService()
        {
            _requester = new ApiRequester("https://localhost:7111/api/");
        }



        public void Create(Beer m)
        {
            _requester.Post(m, "beer");
        }

        public IEnumerable<Beer> GetAll()
        {
            return _requester.Get<IEnumerable<Beer>>("beer");
        }

        public Beer GetById(int id)
        {
            return _requester.Get<Beer>("beer/" + id);
        }

        public void Update(Beer b)
        {
            _requester.Put(b, "beer");
        }

        public void Delete(int id)
        {
            _requester.Delete("beer/" + id);
        }
    }
}
