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
    public class HoldingBLL
    {
        private HoldingDAL dal;
        private CustomerBLL customerBLL;
        private TitleBLL titleBLL;
        public HoldingBLL()
        {
            dal = new HoldingDAL();
            customerBLL = new CustomerBLL();
            titleBLL = new TitleBLL();
        }

        public List<Holding> GetAllHoding()
        {
            return dal.GetAllHoding();
        }

        public Result add(Holding holding)
        {
            return dal.add(holding);
        }
        public Result delete(int idHolding)
        {
            return dal.delete(idHolding);
        }

        public Result update(Holding holding)
        {
            return dal.update(holding);
        }

        public List<ReservationHolding> getListReservationByCustomerID(int idCustomer)
        {
            var holdings = dal.getListReservationByCustomerID(idCustomer);
            var customerIds = holdings.Select(cus => cus.idCustomer);
            var allHoldingCustomer = customerBLL.GetAllCustomer();
            var allHoldingTitle = titleBLL.GetAlltt();
            var results = holdings.Select(hol => new ReservationHolding()
            {
                maDatHang = hol.idHolding,
                maKhachHang = hol.idCustomer,
                tenKhachHang = allHoldingCustomer.Where(x => x.idCustomer == hol.idCustomer).FirstOrDefault().name,
                maTieuDe = hol.idTitle,
                tenTieuDe = allHoldingTitle.Where(x => x.idTitle == hol.idTitle).FirstOrDefault().name,
                ngayDat = hol.reservationTime
            });
            return results.ToList();
            //return dal.getListReservationByCustomerID(idCustomer);
        }

        public List<ReservationHolding> GetReservationHoldings()
        {
            var holdings = dal.GetAllHoding();
            var holdingsID = holdings.Select(hol => hol.idHolding);
            var allHoldingCustomer = customerBLL.GetAllCustomer();
            var allHoldingTitle = titleBLL.GetAlltt();
            var results = holdings.Select(hol => new ReservationHolding()
            {
                maDatHang = hol.idHolding,
                maKhachHang = hol.idCustomer,
                tenKhachHang = allHoldingCustomer.Where(x => x.idCustomer == hol.idCustomer).FirstOrDefault().name,
                maTieuDe = hol.idTitle,
                tenTieuDe = allHoldingTitle.Where(x => x.idTitle == hol.idTitle).FirstOrDefault().name,
                ngayDat = hol.reservationTime
            });
            return results.ToList();
            //var allCustomersRecords = recordBll.GetAllRecords().Where(rec => customerIds.Contains(rec.idCustomer));
            
        }
    }
}
