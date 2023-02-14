using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        mvccredContext _Context = new mvccredContext();
        public ActionResult Index()
        {
            var listofData = _Context.movielists.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(movielist model)
        {
            _Context.movielists.Add(model);
            _Context.SaveChanges();
            ViewBag.Message = "data insert sucessfully";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int mId)

        {
            var data = _Context.movielists.Where(x => x.mId == mId).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(movielist model)
        {
            var data = _Context.movielists.Where(x => x.mId == model.mId).FirstOrDefault();
            if (data!=null)
            {
                data.mname= model.mname;
                data.redate= model.redate;
                _Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Detail(int mId)
        {
            var data = _Context.movielists.Where(x => x.mId == mId).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int mId) 
        {
            var data = _Context.movielists.Where(x => x.mId == mId).FirstOrDefault();
            _Context.movielists.Remove(data);
            _Context.SaveChanges();
            ViewBag.Message = "record deleted sucessfully";
            return RedirectToAction("Index");
        }


    }
}