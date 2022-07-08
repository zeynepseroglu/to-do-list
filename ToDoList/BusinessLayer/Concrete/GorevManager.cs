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
    public class GorevManager : IGorevService
    {
        IGorevDal _gorevDal;

        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal = gorevDal;
        }

        public void TAdd(Gorev t)
        {
            _gorevDal.Insert(t);
        }

        public void TDelete(Gorev t)
        {
            _gorevDal.Delete(t);
        }

        public Gorev TGetById(int id)
        {
            return _gorevDal.GetByID(id);
        }

        public List<Gorev> TGetList()
        {
            return _gorevDal.GetList();
        }

        public void TUpdate(Gorev t)
        {
            _gorevDal.Update(t);
        }
    }
}
