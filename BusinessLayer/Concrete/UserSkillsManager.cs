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
    public class UserSkillsManager : IUserSkillsService

    {
        IUserSkillsDal _userSkillsDal;
        public UserSkillsManager(IUserSkillsDal userSkillsDal)
        {
            _userSkillsDal = userSkillsDal;
        }
        public UserSkills GetByID(int id)
        {
            return _userSkillsDal.Get(x => x.id == id);
        }

        public List<UserSkills> GetList()
        {
            return _userSkillsDal.List();
        }

        public void UserSkillsAdd(UserSkills userSkills)
        {
            _userSkillsDal.Insert(userSkills);
        }

        public void UserSkillsDelete(UserSkills userSkills)
        {
            _userSkillsDal.Delete(userSkills);    
        }

        public void UserSkillsUpdate(UserSkills userSkills)
        {
            _userSkillsDal.Update(userSkills);
        }
    }
}
