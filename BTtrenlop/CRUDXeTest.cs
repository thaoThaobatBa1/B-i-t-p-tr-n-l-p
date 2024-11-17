using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtrenlop
{
    public class CRUDXeTest
    {
        private XeOToService service;

        [SetUp]
        public void Setup()
        {
            service = new XeOToService();
        }

        [Test]
        public void TestThemXe()
        {
            var xe = new XeOTo { Ma = 1, Ten = "Toyota Camry", Gia = 1000000.0m, GhiChu = "Xe mới" };
            service.ThemXe(xe);

            var danhSachXe = service.LayDanhSachXe();
            Assert.AreEqual(1, danhSachXe.Count);
            Assert.AreEqual(xe.Ma, danhSachXe[0].Ma);
            Assert.AreEqual(xe.Ten, danhSachXe[0].Ten);
            Assert.AreEqual(xe.Gia, danhSachXe[0].Gia);
            Assert.AreEqual(xe.GhiChu, danhSachXe[0].GhiChu);
        }

        [Test]
        public void TestSuaXe()
        {
            var xe1 = new XeOTo { Ma = 1, Ten = "Toyota Camry", Gia = 1000000.0m, GhiChu = "Xe mới" };
            service.ThemXe(xe1);

            var xe2 = new XeOTo { Ma = 1, Ten = "Toyota Corolla", Gia = 800000.0m, GhiChu = "Xe cũ" };
            service.SuaXe(1, xe2);

            var danhSachXe = service.LayDanhSachXe();
            Assert.AreEqual(1, danhSachXe.Count);
            Assert.AreEqual(xe2.Ma, danhSachXe[0].Ma);
            Assert.AreEqual(xe2.Ten, danhSachXe[0].Ten);
            Assert.AreEqual(xe2.Gia, danhSachXe[0].Gia);
            Assert.AreEqual(xe2.GhiChu, danhSachXe[0].GhiChu);
        }

        [Test]
        public void TestXoaXe()
        {
            var xe1 = new XeOTo { Ma = 1, Ten = "Toyota Camry", Gia = 1000000.0m, GhiChu = "Xe mới" };
            service.ThemXe(xe1);

            service.XoaXe(1);

            var danhSachXe = service.LayDanhSachXe();
            Assert.AreEqual(0, danhSachXe.Count);
        }

    }
}
