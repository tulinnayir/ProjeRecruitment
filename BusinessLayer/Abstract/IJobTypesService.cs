using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IJobTypesService
    {
        List<JobTypes> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void JobTypesAdd(JobTypes jobTypes);
        JobTypes GetByID(int id);
        void JobTypesDelete(JobTypes jobTypes);
        void JobTypesUpdate(JobTypes jobTypes);
    }
}
