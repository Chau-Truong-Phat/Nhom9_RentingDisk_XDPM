using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TitleDAL
    {

        private RentingDiskDBContext db;
        public TitleDAL()
        {
            db = new RentingDiskDBContext();
        }
        public Title GetItemTitleById(string id)
        {
            return db.Titles.FirstOrDefault(x => x.idTitle == id);
        }
    }
}
