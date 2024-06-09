using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFramework
{
    public class EfCompaniesDal : GenericRepository<Companies>, ICompaniesDal
    {
    }
}
