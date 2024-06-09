using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoriesService
    {
        List<Categories> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void CategoriessAdd(Categories categories);
        Categories GetByID(int id);
        void CategoriesDelete(Categories categories);
        void CategoriesUpdate(Categories categories);
    }
}
