using Abituriyent.Models;
using Abituriyent.Models.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abituriyent.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        CedvellerDataContext db = new CedvellerDataContext();
        public ActionResult Universitet()
        {
            var viewModel = new UniversitetViewModel
            {
                Universitets = db.Universitets.ToList()
            };
            return View(viewModel);
        }

        

        public ActionResult UniversitetInsert()
        {
            var viewModel = new UniversitetViewModel
            {
                Universitets = db.Universitets.ToList()
            };
            return View(viewModel);
        }
        
        [HttpPost]
        public ActionResult UniversitetInsert(Universitet universitet)
        {

            db.Universitets.InsertOnSubmit(universitet);
            db.SubmitChanges();
            return RedirectToAction("Universitet");
        }

        public ActionResult UniversitetDelete( int id)
        {
            db.Universitets.DeleteOnSubmit(db.Universitets.SingleOrDefault(x => x.UniversitetId == id));
            db.SubmitChanges();
           return RedirectToAction("Universitet");
        }

        public ActionResult UniversitetUpdate(int id)
        {
            Universitet universitet = db.Universitets.SingleOrDefault(x => x.UniversitetId == id);
            return View(universitet);

        }
        [HttpPost]
        public ActionResult UniversitetUpdate(int id,Universitet universitet)
        {
            Universitet newuniversitet = db.Universitets.SingleOrDefault(x => x.UniversitetId == id);
            newuniversitet.Ad = universitet.Ad;
            db.SubmitChanges();
            return RedirectToAction("Universitet");
        }

        public ActionResult Fakulte()
        {
            var viewModel = new UniversitetViewModel
            {
                Universitets = db.Universitets.ToList(),
                fakultes = db.Fakultes.ToList(),
                umumis = db.Umumis.ToList(),
                tehsilFormasis = db.TehsilFormasis.ToList()
            };
            return View(viewModel);
        }

        public ActionResult FakulteInsert()
        {
            var viewModel = new UniversitetViewModel
            {
                Universitets= db.Universitets.ToList(),
                fakultes = db.Fakultes.ToList(),
                umumis = db.Umumis.ToList(),
                tehsilFormasis = db.TehsilFormasis.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]

        public ActionResult FakulteInsert(Fakulte fakulte,Umumi umumi, TehsilFormasi tehsilFormasi,Universitet universitet)
        {
            db.Fakultes.InsertOnSubmit(fakulte);
            db.TehsilFormasis.InsertOnSubmit(tehsilFormasi);
            db.Universitets.InsertOnSubmit(universitet);
            
            db.SubmitChanges();
            return RedirectToAction("Fakulte");
        }






    }
}