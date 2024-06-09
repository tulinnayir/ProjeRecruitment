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
    public class CompetenciesManager : ICompetenciesService

    {
        ICompetenciesDal _competenciesDal;
        public CompetenciesManager(ICompetenciesDal competenciesDal)
        {
            _competenciesDal = competenciesDal;
        }


        public void CompetenciesAdd(Competencies competencies)
        {
            _competenciesDal.Insert(competencies);


        }

        public void CompetenciesDelete(Competencies competencies)
        {
            _competenciesDal.Delete(competencies);
        }

        public void CompetenciesUpdate(Competencies competencies)
        {
            _competenciesDal.Update(competencies);
        }

        public Competencies GetByID(int id)
        {
           return _competenciesDal.Get(x => x.id == id);
        }

        public List<Competencies> GetList()
        {
            return _competenciesDal.List();
        }
    }
}
