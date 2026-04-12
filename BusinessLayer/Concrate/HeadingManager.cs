using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class HeadingManager : IHeadingService
    {
        IHeaderDal _headerDal;

        public HeadingManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public void AddHeading(Heading heading)
        {
            _headerDal.insert(heading);
        }

        public void DeleteHeading(Heading heading)
        {
            _headerDal.delete(heading);
        }

        public Heading GetByID(int id)
        {
            return _headerDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _headerDal.list();
        }

        public void UpdateHeading(Heading heading)
        {
            _headerDal.update(heading);
        }
    }
}
