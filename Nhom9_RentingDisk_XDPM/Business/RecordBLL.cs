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
    public class RecordBLL
    {
        private RecordDAL dal;
        public RecordBLL()
        {
            dal = new RecordDAL();
        }
        public List<Record> GetAllRecordIsPaid(int id)
        {
           return dal.GetAllRecordIsPaid(id);
        }
        public List<Record> GetAllRecordIsReturn(int id)
        {
            return dal.GetAllRecordIsReturn(id);
        }
        public Result UpdateDateReturnAndLateFee(Record record)
        {
            return dal.UpdateDateReturnAndLateFee(record);
        }
    }
}
