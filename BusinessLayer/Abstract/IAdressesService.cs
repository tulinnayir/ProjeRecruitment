using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdressesService
    {
        List<Adresses> GetList();
        //List<BillingAdresses> GetListUsers(int id);
        void AdressesAdd(Adresses adresses);
        Adresses GetByID(int id);
        void AdressesDelete(Adresses adresses);
        void AdressesUpdate(Adresses adresses);
    }
}
