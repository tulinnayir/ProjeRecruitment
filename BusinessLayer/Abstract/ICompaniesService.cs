using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompaniesService
    {
        List<Companies> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void CompaniesAdd(Companies companies);
        Companies GetByID(int id);
        void CompaniesDelete(Companies companies);
        void CompaniesUpdate(Companies companies);
    }
}
