using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        About GetByID(int id);
        void AddAbout(About about);
        void DeleteAbout(About about);
        void UpdateAbout(About about);
    }
}
