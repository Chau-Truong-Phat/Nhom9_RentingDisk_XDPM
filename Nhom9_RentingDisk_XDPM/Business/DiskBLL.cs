using Business.Models;
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
    public class DiskBLL
    {
        private DiskDAL dal;
        private TitleBLL titleBLL;
        private CustomerBLL customerBLL;
        public DiskBLL()
        {
            dal = new DiskDAL();
            titleBLL = new TitleBLL();
            customerBLL = new CustomerBLL();
        }
        public List<Disk> getDisks()
        {
            return dal.getDisks();
        }
        public List<Disk> GetListDiskByIDtitle(string id)
        {
            return dal.GetListDiskByIDtitle(id);
        }
        public bool updateStatusDisk(Disk disk)
        {
            return dal.updateStatusDisk(disk);
        }
        public List<Disk> getDisksOnShelf()
        {
            return dal.getDisksOnShelf();
        }
        public Disk getDiskByID(string id)
        {
            return dal.getDiskByID(id);
        }
        public Disk GetONEDiskByIDtitle(string id)
        {
            return dal.GetONEDiskByIDtitle(id);
        }
        public Result delete(string id)
        {
            return dal.delete(id);
        }
        public Result add(Disk disk)
        {
            return dal.add(disk);
        }
        public List<DiskRecord> GetALlDiskRecord(string id)
        {
            var dsk = dal.GetListDiskByIDtitle(id);

            //var holdingsID = holdings.Select(hol => hol.idHolding);
            var allTitle = titleBLL.GetAlltt();
            var allCus = customerBLL.GetAllCustomer();
            //var allHoldingTitle = titleBLL.GetAlltt();
            var results = dsk.Select(x => new DiskRecord()
            {
                idDisk = x.idDisk,
                name = x.name,
                status = x.status,
                nameTitle = allTitle.Where(y => y.idTitle == x.idTitle).FirstOrDefault().name,
                //nameCustomer = allTitle.Where()
                //rentDate
                //dueDate
            });
            return results.ToList();
        }
    }
}
