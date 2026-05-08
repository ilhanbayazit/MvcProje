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
    public class ContentManager : IContentService
    {
        IContentDal _contentdal;

        public ContentManager(IContentDal contentdal)
        {
            _contentdal = contentdal;
        }

        public void AddContent(Content content)
        {
            _contentdal.insert(content);
        }

        public void DeleteContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            return _contentdal.list();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentdal.list(x => x.HeadingID == id);
        }

        public List<Content> GetListByWriter(int id)
        {
            return _contentdal.list(x => x.WriterID == id);
        }

        public void UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
