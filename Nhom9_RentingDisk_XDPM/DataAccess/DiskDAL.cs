using DataAccess.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DiskDAL
    {
        private RentingDiskDBContext db;
        public DiskDAL()
        {
            db = new RentingDiskDBContext();
        }
        public List<Disk> getDisks()
        {
            return db.Disks.ToList();
        }
        public Result delete(string id)
        {
            var item = db.Disks.FirstOrDefault(x => x.idDisk == id);

            if (item != null)
            {
                db.Disks.Remove(item);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    return new Result
                    {
                        message = e
                            .EntityValidationErrors
                            .LastOrDefault()
                            .ValidationErrors
                            .LastOrDefault()
                            .ErrorMessage,
                        isSuccess = false
                    };
                }
                return new Result
                {
                    message = "Xóa  thành công",
                    isSuccess = true
                };
            }
            else
            {
                return new Result
                {
                    message = "Không tìm thấy",
                    isSuccess = false
                };
            }
        }
        public Result add(Disk disk)
        {
            db.Disks.Add(disk);
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                return new Result
                {
                    message = e
                        .EntityValidationErrors
                        .LastOrDefault()
                        .ValidationErrors
                        .LastOrDefault()
                        .ErrorMessage,
                    isSuccess = false
                };
            }
            return new Result
            {
                message = "Thêm thành công",
                isSuccess = true
            };
        }
        public List<Disk> GetListDiskByIDtitle(string id)
        {
            return db.Disks.Where(x => x.idTitle == id).ToList();
        }
        public bool updateStatusDisk(Disk disk)
        {
            var check = db.Disks.FirstOrDefault(x => x.idDisk.Equals(disk.idDisk));
            if(check != null)
            {
                check.status = disk.status;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Disk> getDisksOnShelf()
        {
            return db.Disks.Where(x => x.status == Entities.Enum.Status.OnShelf).ToList();
        }
    
        public Disk getDiskByID(string id)
        {
            return db.Disks.FirstOrDefault(x => x.idDisk == id);
        }
        public Disk GetONEDiskByIDtitle(string id)
        {
            return db.Disks.FirstOrDefault(x => x.idTitle == id);
        }
    }
}
