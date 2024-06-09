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
    public class JobAdvertsManager : IJobAdvertsService
    {
        IJobAdvertsDal _jobAdvertsDal;
        public JobAdvertsManager(IJobAdvertsDal jobAdvertsDal)
        {
            _jobAdvertsDal = jobAdvertsDal;
        }

        public JobAdverts GetByID(int id)
        {
            return _jobAdvertsDal.Get(x => x.id == id);

        }

        public List<JobAdverts> GetList()
        {
            return _jobAdvertsDal.List();
        }

        public void JobAdvertsAdd(JobAdverts jobAdverts)
        {
            _jobAdvertsDal.Insert(jobAdverts);
        }

        public void JobAdvertsDelete(JobAdverts jobAdverts)
        {
            _jobAdvertsDal.Delete(jobAdverts);
        }

        public void JobAdvertsUpdate(JobAdverts jobAdverts)
        {
            _jobAdvertsDal.Update(jobAdverts);
        }
    }
}
