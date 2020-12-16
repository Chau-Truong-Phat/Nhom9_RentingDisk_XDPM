using DataAccess;
using DataAccess.DTO;
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
        public List<Title> GetListTitleByID(string id)
        {
            return dal.GetListTitleByID(id);
        }
        public Result addTitle(Title title)
        {
            return dal.addTitle(title);
        }
        public Title GetTitleByName(string namett)
        {
            return dal.GetItemTitleById(namett);
        }
        public int getIdCategoryByIdTitle(string idTitle)
        {
            return dal.getIdCategoryByIdTitle(idTitle);
        }
        public List<Title> GetAlltt()
        {
            return dal.GetAllTitle();
        }
        //public Disk GetDiskById(string id)
        //{
        //    return dal.getDisks().FirstOrDefault(disk => disk.idDisk == id);
        //}
        //public Disk GetONEDiskByIDtitle(string id)
        //{
        //    return dal.GetONEDiskByIDtitle(id);
        //}
    }
}
