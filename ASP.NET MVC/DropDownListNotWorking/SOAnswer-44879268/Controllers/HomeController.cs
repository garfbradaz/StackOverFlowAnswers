using SOAnswer_44879268.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOAnswer_44879268.Controllers
{
    public class  DeptCode
    {
        public int Id { get; set; }
        public string Description { get; set; }

    }
    public class HomeController : Controller
    {
        private List<BudgetModel> BudgetDb = new List<BudgetModel>();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            //--Didnt know OPs structure for this.
            List<DeptCode> _depts = new List<DeptCode>();
            _depts.Add(new DeptCode { Id = 0, Description = "IT"});
            _depts.Add(new DeptCode { Id = 1, Description = "Customer Services" });
            _depts.Add(new DeptCode { Id = 2, Description = "Warehouse" });


            var _listSelectItem = _depts.Select(@group => new SelectListItem
            {
                Selected = true,
                Text = @group.Description,
                Value = @group.Id.ToString()

            }).ToList();

            var firstOrDefault = _listSelectItem.FirstOrDefault();
            if(firstOrDefault != null)
            {
                ViewBag.DeptList = new SelectList(_listSelectItem, "Value", "Text", firstOrDefault.Text);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Create(BudgetViewModel model, int month =1, int year = 2017)
        {
            model.DATETIME = DateTime.Now;
            //BudgetDb.insert(model);
            BudgetDb.Add(model);
            return RedirectToAction("Index");
        }


    }
}