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
    public class UsersManager : IUsersService

    {
        IUsersDal _usersDal;


        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }
        public Users GetByID(int id)
        {
            return _usersDal.Get(x => x.id == id);
        }

        public List<Users> GetList()
        {
            return _usersDal.List();
        }


        public void UsersAdd(Users users)
        {
            _usersDal.Insert(users);
        }

        public void UsersDelete(Users users)
        {
            _usersDal.Delete(users);
        }

        public void UsersUpdate(Users users)
        {
            _usersDal.Update(users);
        }
    }
}
