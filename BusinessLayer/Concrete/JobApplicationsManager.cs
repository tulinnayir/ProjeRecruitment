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
    public class JobApplicationsManager :IJobApplicationsService
    {

        IJobApplicationsDal _jobApplicationsDal;
        public JobApplicationsManager(IJobApplicationsDal jobApplicationsDal)
        {
            _jobApplicationsDal = jobApplicationsDal;
        }
        public JobApplications GetByID(int id)
        {
            return _jobApplicationsDal.Get(x => x.id == id);
        }

        public List<JobApplications> GetList()
        {
            return _jobApplicationsDal.List();
        }

        public void JobApplicationsAdd(JobApplications jobApplications)
        {
            _jobApplicationsDal.Insert(jobApplications);        }

        public void JobApplicationsDelete(JobApplications jobApplications)
        {
            _jobApplicationsDal.Delete(jobApplications);
        }

        public void JobApplicationsUpdate(JobApplications jobApplications)
        {
            _jobApplicationsDal.Update(jobApplications);
        }
    }
}
