using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtrenlop
{
    public class XeOToService
    {
        private List<XeOTo> danhSachXe = new List<XeOTo>();

        public void ThemXe(XeOTo xe)
        {
            danhSachXe.Add(xe);
        }

        public void SuaXe(int ma, XeOTo xe)
        {
            var xeCu = danhSachXe.FirstOrDefault(x => x.Ma == ma);
            if (xeCu != null)
            {
                xeCu.Ten = xe.Ten;
                xeCu.Gia = xe.Gia;
                xeCu.GhiChu = xe.GhiChu;
            }
        }

        public void XoaXe(int ma)
        {
            var xe = danhSachXe.FirstOrDefault(x => x.Ma == ma);
            if (xe != null)
            {
                danhSachXe.Remove(xe);
            }
        }

        public List<XeOTo> LayDanhSachXe()
        {
            return danhSachXe;
        }
    }
}
