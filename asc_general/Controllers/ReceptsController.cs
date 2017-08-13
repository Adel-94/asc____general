using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asc_general.Models;
using System.Dynamic;
using System.Net;

namespace asc_general.Controllers
{
    public class ReceptsController : Controller
    {

        private DbAscEntities db = new DbAscEntities();
        // GET: Recepts
        public ActionResult Index(int? id,int? categoryID)
        {
            if (id == null || categoryID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dynamic mymodel = new ExpandoObject();
            food food_id = db.foods.Find(id);
            mymodel.foodId = food_id;
            mymodel.recepts = db.foods.ToList();
            mymodel.allrecepts = db.foods.Where(f => f.category_id == food_id.category_id).ToList();
            mymodel.prev = db.foods.OrderByDescending(x=> x.id).FirstOrDefault(p=> p.id > id && p.category_id == food_id.category_id);
            mymodel.next = db.foods.FirstOrDefault(n => n.id < id && n.category_id == food_id.category_id);
            mymodel.categories = db.food_categories.ToList();
            return View(mymodel);
        }

        public ActionResult Allrecepts(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dynamic mymodel = new ExpandoObject();
            mymodel.food_cat_id = db.food_categories.Find(id);
            mymodel.othercategories = db.food_categories.Where(f => f.id != id).ToList();
            mymodel.receptbycategories = db.foods.Where(f => f.category_id == id).ToList();
            return View(mymodel);
        }
    }
}