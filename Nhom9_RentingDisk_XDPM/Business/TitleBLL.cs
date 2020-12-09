using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TitleBLL
    {
        private TitleDAL dal;
        public TitleBLL()
        {
            dal = new TitleDAL();
        }
        public Title GetItemTitleById(string id)
        {
            return dal.GetItemTitleById(id);
        }
    }
}
