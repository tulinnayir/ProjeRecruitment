using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserSkillsService
    {
        List<UserSkills> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void UserSkillsAdd(UserSkills userSkills);
        UserSkills GetByID(int id);
        void UserSkillsDelete(UserSkills userSkills);
        void UserSkillsUpdate(UserSkills userSkills);
    }
}
