﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Record
    {
        [Key]
        [Column(Order = 1)]
        public int idCustomer { get; set; }
        [Key]
        [Column(Order = 2)]
        public string idDisk { get; set; }
        [Key]
        [Column(Order = 3)]
        public string idTitle { get; set; }

        public DateTime rentDate { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime actualReturnDate { get; set; }
        public float lateFee { get; set; }
        public bool isPaid { get; set; }
        public bool isRecord { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Disk Disk{ get; set; }
        public virtual Title Title { get; set; }
    }
}
