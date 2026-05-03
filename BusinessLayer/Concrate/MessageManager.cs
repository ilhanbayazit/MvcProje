using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddMessage(Message message)
        {
            _messageDal.insert(message);
        }

        public void DeleteMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.list(x => x.ReciverMail == "Admin");
        }

        public List<Message> GetListSendbox()
        {
            return _messageDal.list(x => x.SenderMail == "Admin");
        }

        public void UpdateMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
