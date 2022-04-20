using CorrectifSecu_WEB_DAL.Entities;

namespace CorrectifSecu_WEB_DAL.Repositories
{
    public interface IBeerRepository
    {
        void Create(Beer m);
        IEnumerable<Beer> GetAll();
        Beer GetById(int id);
        void Update(Beer b);
        void Delete(int id);


    }
}