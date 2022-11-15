using PROJEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PROJEM.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
       
        Takip_SistemiEntities db=new Takip_SistemiEntities();   
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();

        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public ActionResult Login(Kullanici p)
        {
            var bilgiler=db.Kullanici.FirstOrDefault(x=>x.KullaniciAd==p.KullaniciAd && x.Sifre==p.Sifre); 
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAd, false);
                Session["Ad"]=bilgiler.Ad.ToString();
                Session["Soyad"] = bilgiler.Soyad.ToString();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.hata = "Kullanıcı Adı Veya Şifre Hatalı";
            }


            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Kullanici a)
        {
            db.Kullanici.Add(a);
            a.Rol = "U";
            db.SaveChanges();
            return RedirectToAction("Login", "Account");

        }


    }

}