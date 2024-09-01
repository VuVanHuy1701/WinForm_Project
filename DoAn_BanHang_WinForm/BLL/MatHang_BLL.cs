using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class MatHang_BLL
    {
       

        MatHang_DAL MHDAL = new MatHang_DAL();

        public List<MatHang> HienThiDanhSachMatHang()
        {
            return MHDAL.HienThiDanhSachMatHang();
        }
        public bool ThemMH(MatHang mh)
        {
            return MHDAL.ThemMH(mh);
        }
        public bool XoaMH(MatHang mh)
        {
            return MHDAL.XoaMH(mh);
        }
        public bool SuaMH(MatHang mh)
        {
            return MHDAL.SuaMH(mh);
        }
    }
}