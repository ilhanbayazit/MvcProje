using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService 
    {
        List<Heading> GetList();
        Heading GetByID(int id);
        void AddHeading(Heading heading);
        void DeleteHeading(Heading heading);
        void UpdateHeading(Heading heading);
        void RecoverHeading(Heading heading);
    }
}
