using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IJobApplicationsService
    {
        List<JobApplications> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void JobApplicationsAdd(JobApplications jobApplications);
        JobApplications GetByID(int id);
        void JobApplicationsDelete(JobApplications jobApplications);
        void JobApplicationsUpdate(JobApplications jobApplications);
    }
}
