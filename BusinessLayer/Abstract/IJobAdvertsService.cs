using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IJobAdvertsService
    {
        List<JobAdverts> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void JobAdvertsAdd(JobAdverts jobAdverts);
        JobAdverts GetByID(int id);
        void JobAdvertsDelete(JobAdverts jobAdverts);
        void JobAdvertsUpdate(JobAdverts jobAdverts);
    }
}
