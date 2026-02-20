using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Contact
    {
        [Key]
        public int ContantID { get; set; }
        [StringLength(50)]
        public string UserSurname { get; set; }
        [StringLength(50)]

        public string UserMail { get; set; }
        [StringLength(50)]

        public string UserSubject { get; set; }
        [StringLength(500)]

        public string UserMessage { get; set; }
    }
}
