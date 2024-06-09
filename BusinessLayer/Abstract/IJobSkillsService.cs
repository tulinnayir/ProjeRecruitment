using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IJobSkillsService
    {
        List<JobSkills> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void JobSkillsAdd(JobSkills jobSkills);
        JobSkills GetByID(int id);
        void JobSkillsDelete(JobSkills jobSkills);
        void JobSkillsUpdate(JobSkills jobSkills);
    }
}
