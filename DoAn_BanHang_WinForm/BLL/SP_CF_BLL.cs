using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SP_CF_BLL
    {
        SP_CF_DAL SPDAL = new SP_CF_DAL();
        public List<MatHang> HienThiDanhSachSanPham()
        {
            return SPDAL.HienThiDanhSachSanPham();
        }
    }
}
