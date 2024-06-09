using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompaniesManager : ICompaniesService
    {
        ICompaniesDal _companiesDal;
        public CompaniesManager(ICompaniesDal companiesDal)
        {
            _companiesDal = companiesDal;
        }
        public void CompaniesAdd(Companies companies)
        {
            _companiesDal.Insert(companies);
        }

        public void CompaniesDelete(Companies companies)
        {
            _companiesDal.Delete(companies);
        }

        public void CompaniesUpdate(Companies companies)
        {
            _companiesDal.Update(companies);
        }

        public Companies GetByID(int id)
        {
            return _companiesDal.Get(x => x.id == id);
        }

        public List<Companies> GetList()
        {
            return _companiesDal.List();
        }
    }
}
