using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUsersService
    {
        List<Users> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void UsersAdd(Users users);
        Users GetByID(int id);
        void UsersDelete(Users users);
        void UsersUpdate(Users users);
    }
}
