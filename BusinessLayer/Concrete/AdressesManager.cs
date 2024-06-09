using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdressesManager : IAdressesService
    {
        IAdressesDal _adressesDal;

        public AdressesManager(IAdressesDal adressesDal)
        {
            _adressesDal = adressesDal;
        }

        public void AdressesAdd(Adresses adresses)
        {
            _adressesDal.Insert(adresses);


        }

        public void AdressesDelete(Adresses adresses)
        {
            _adressesDal.Delete(adresses);
        }

        public void AdressesUpdate(Adresses adresses)
        {
            _adressesDal.Update(adresses);
        }



        public Adresses GetByID(int id)
        {
            return _adressesDal.Get(x => x.id == id);
        }

        public List<Adresses> GetList()
        {
            return _adressesDal.List();
        }
    }
}
