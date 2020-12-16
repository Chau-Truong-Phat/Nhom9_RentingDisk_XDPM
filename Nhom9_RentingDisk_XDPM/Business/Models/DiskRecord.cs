using DataAccess.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class DiskRecord
    {
        public string idDisk { get; set; }
        public string name { get; set; }
        public Status status { get; set; }
        public string nameTitle { get; set; }
        public string nameCustomer { get; set; }
        public DateTime? rentDate { get; set; }
        public DateTime? dueDate { get; set; }
    }
}
