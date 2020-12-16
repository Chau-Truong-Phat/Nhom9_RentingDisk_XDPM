using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class ReservationHolding
    {
        public int maDatHang { get; set; }
        public int maKhachHang { get; set; }
        public string tenKhachHang { get; set; }
        public string maTieuDe { get; set; }
        public string tenTieuDe { get; set; }
        public DateTime ngayDat { get; set; }
    }
}
