using AcurenzAppFramework.Data;
using AcurenzAppFramework.DataAccess;
using AcurenzAppFramework.Service;
using Repository;
using Repository.Providers.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AcurenzAppFramework.Controllers
{
    public class LicenseController : Controller
    {
        // GET: License
       
        private readonly IDriverLicenseService _driverlicenseservice;
        private readonly IUnitOfWork _unitofwork;
        public LicenseController(IDriverLicenseService driverlicenseservice, IUnitOfWork unitofwork)
        {
            _driverlicenseservice = driverlicenseservice;
            _unitofwork = unitofwork;
        }
        public ActionResult Index()
        {
            //var licensetypes = _context.LicenseTypes.ToList();
            if (_driverlicenseservice != null)
            {
                var licensetypes = _driverlicenseservice.GetAll().ToList();
                return View(licensetypes);
            }
            // return View();
            return null;
        }

        // GET: License/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: License/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: License/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "DisplayName,LookupName,Description")] LicenseType licenseType)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState != null && ModelState.IsValid)
                {
                    licenseType.DateUpdated = DateTime.Now;
                    licenseType.UpdatedBy = "jigarParikh";
                    _driverlicenseservice.Add(licenseType);
                    _unitofwork.Save();
                    return RedirectToAction("Index");
                }


            }
            catch (Exception ex)
            {
                return View();
            }
            return View();
        }

        [HttpGet]
        public virtual JsonResult GetStates()
        {
            var list = new List<string>
    {
        "Alabama","Alaska","Arizona","Arkansas","California"
    };
            //var results = list.Where(n => n.ToLower().Contains(term.ToLower()));
            return new JsonResult()
            {
                Data = list.ToArray(),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        // GET: License/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: License/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: License/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: License/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
