﻿using DataAccess;
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
        public List<Record> GetAllRecordUnPaid(int id)
        {
           return dal.GetAllRecordUnPaid(id);
        }
        public List<Record> GetAllRecordUnReturn(int id)
        {
            return dal.GetAllRecordUnReturn(id);
        }
        public Result UpdateDateReturnAndLateFee(Record record)
        {
            return dal.UpdateDateReturnAndLateFee(record);
        }
        public Result UpdateIsPaid(Record record)
        {
            return dal.UpdateIsPaid(record);
        }
        public List<Record> checkLateFee(int idCustomer)
        {
            return dal.checkLateFee(idCustomer);
        }
        public Record getRecordByID(int id)
        {
            return dal.getRecordByID(id);
        }
        public bool addRecord(Record record)
        {
            return dal.addRecord(record);
        }
        public List<Record> getPendingDiskByIDCustomer(int idCustomer)
        {
            return dal.getPendingDiskByIDCustomer(idCustomer);
        }
        public bool updateRentDate(Record record)
        {
            return dal.updateRentDate(record);
        }
    }
}
