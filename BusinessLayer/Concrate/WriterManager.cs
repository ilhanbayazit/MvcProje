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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public void AddWriter(Writer writer)
        {
            _writerdal.insert(writer);
        }

        public void DeleteWriter(Writer writer)
        {
            _writerdal.delete(writer);
        }

        public Writer GetByID(int id)
        {
            return _writerdal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerdal.list();
        }

        public void UpdateWriter(Writer writer)
        {
            _writerdal.update(writer);
        }
    }
}
