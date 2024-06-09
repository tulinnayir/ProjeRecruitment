using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompetenciesService
    {
        List<Competencies> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void CompetenciesAdd(Competencies competencies);
        Competencies GetByID(int id);
        void CompetenciesDelete(Competencies competencies);
        void CompetenciesUpdate(Competencies competencies);

    }
}
