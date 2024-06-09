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
    public class JobSkillsManager : IJobSkillsService


    {
        IJobSkillsDal _jobskillsDal;

        public JobSkillsManager()
        {
        }

        public JobSkillsManager(IJobSkillsDal jobskillsDal)
        {
            _jobskillsDal = jobskillsDal;
        }
        public JobSkills GetByID(int id)
        {
            return _jobskillsDal.Get(x => x.id == id);
        }

        public List<JobSkills> GetList()
        {
           return _jobskillsDal.List();
        }

        public void JobSkillsAdd(JobSkills jobSkills)
        {
            _jobskillsDal.Insert(jobSkills);
        }

        public void JobSkillsDelete(JobSkills jobSkills)
        {
            _jobskillsDal.Delete(jobSkills);
        }

        public void JobSkillsUpdate(JobSkills jobSkills)
        {
            _jobskillsDal.Update(jobSkills);
        }
    }
}
