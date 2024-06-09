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
    public class JobTypesManager : IJobTypesService
    {
        IJobTypesDal _jobtype;
        public JobTypesManager(IJobTypesDal jobtype)
        {
            _jobtype = jobtype;
        }
        public JobTypes GetByID(int id)
        {
            return _jobtype.Get(x => x.id == id);
        }

        public List<JobTypes> GetList()
        {
            return _jobtype.List();
        }

        public void JobTypesAdd(JobTypes jobTypes)
        {
            _jobtype.Insert(jobTypes);
        }

        public void JobTypesDelete(JobTypes jobTypes)
        {
            _jobtype.Delete(jobTypes);
        }

        public void JobTypesUpdate(JobTypes jobTypes)
        {
           _jobtype.Update(jobTypes);
        }
    }
}
