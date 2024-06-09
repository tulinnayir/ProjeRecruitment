using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoriesManager : ICategoriesService


    {
        ICategoriesDal _categoriesDal;
        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal=categoriesDal;   
        }

        public void CategoriesDelete(Categories categories)
        {
            _categoriesDal.Delete(categories);
        }

        public void CategoriessAdd(Categories categories)
        {
            _categoriesDal.Insert(categories);
        }

        public void CategoriesUpdate(Categories categories)
        {
            _categoriesDal.Update(categories);
        }

        public Categories GetByID(int id)
        {
            return _categoriesDal.Get(x => x.id == id);
        }

        public List<Categories> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
