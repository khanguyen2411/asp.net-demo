using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    public class NhanviensController : Controller
    {
        // GET: Nhanviens

        List<Nhanvien> list = new List<Nhanvien>();

        public NhanviensController()
        {
            list.Clear();
            Nhanvien nv1 = new Nhanvien("nv01", "Nguyen Thi Anh", 1000, 100);
            list.Add(nv1);

            Nhanvien nv2 = new Nhanvien("nv02", "Tran Van Tuan", 3000, 300);
            list.Add(nv2);

            Nhanvien nv3 = new Nhanvien("nv03", "Le Thi Ha", 1000, 200);
            list.Add(nv3);

            Nhanvien nv4 = new Nhanvien("nv04", "Hoang Van Long", 4000, 600);
            list.Add(nv4);

            Nhanvien nv5 = new Nhanvien("nv05", "Phan Tuyet Nga", 2000, 500);
            list.Add(nv5);
        }

        public ActionResult Index()
        {
            List<Nhanvien> l1 = new List<Nhanvien>();
            List<Nhanvien> l2 = new List<Nhanvien>();

            foreach (Nhanvien nv in list)
            {
                if(nv.luong > 2000)
                {
                    if (!l1.Contains(nv))
                    {
                        l1.Add(nv);
                    }
                }
                if(nv.thuong >= 500)
                {
                    if (!l2.Contains(nv))
                    {
                        l2.Add(nv);
                    }
                }
            }

            ViewBag.list1 = l1;
            ViewBag.list2 = l2;

            return View();
        }

        public ActionResult Input(FormCollection data)
        {
            return View();
        }

        public ActionResult Output(FormCollection data)
        {
            ViewBag.manv = data["manv"];
            ViewBag.hoten = data["hoten"];
            ViewBag.luong = data["luong"];
            ViewBag.thuong = data["thuong"];
            try
            {
                ViewBag.thucnhan = Convert.ToDecimal(data["luong"]) + Convert.ToDecimal(data["thuong"]);
            } catch (Exception e)
            {

            }
            return View();
        }
    }
}