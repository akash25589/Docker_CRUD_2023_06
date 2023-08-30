using CRUD_2023_06.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_2023_06.Controllers
{
    public class mainController : Controller
    {
        private readonly DB mydb;

        public mainController(DB dbData)
        {
            mydb = dbData;
        }
        public IActionResult Index()
        {
            try
            {

                IEnumerable<MyFruits> xData = mydb.myCRUD;
                ViewBag.notify = TempData["MyNotify"];
                int total = 0;
               foreach (MyFruits x in xData)
                {
                    total += x.fruitquantity;
                }
               ViewBag.mytotal = total;
                return View(xData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public ActionResult Create()
        {
            //List<Fruits_Data> cl = new List<Fruits_Data>();
            //cl = (from c in mydb.Fruits_details select c).ToList();
            //ViewBag.message = cl;

            return View(new MyFruits());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MyFruits xData)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    mydb.myCRUD.Add(xData);
                    mydb.SaveChanges();

                    TempData["MyNotify"] = "Data Inserted !! Successfully";

                    return RedirectToAction("Index");
                }

                return View(xData);
            }
            catch (Exception )
            {
                throw ;
            }

        }

        
        public IActionResult Edit(int? id)
        {

            if(id == null)
            {
                return NotFound();
            }
            var obj  = mydb.myCRUD.Find(id);

            if(obj == null)
            {
                return NotFound(obj);
            }
            List<Fruits_Data> cl = new List<Fruits_Data>();
            cl = (from c in mydb.Fruits_details select c).ToList();
            ViewBag.message = cl;

            return View(obj);   
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MyFruits obj)
        {
            try
            {
                mydb.myCRUD.Update(obj);
                mydb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception )
            {
                throw ;
            }
          

        }

        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = mydb.myCRUD.Find(id);

            if(obj == null)
            {
                return NotFound(obj);
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            try
            {
                var obj = mydb.myCRUD.Find(id);

                if(obj == null)
                {
                    return NotFound();
                }
                mydb.myCRUD.Remove(obj);
                mydb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception )
            {
                throw ;
            }
        }

        public ActionResult ViewProfile(int id)
        {
            try
            {
                //  var obj = mydb.myCRUD.Find(id);


                return View(mydb.myCRUD.Where(a => a.Id == id).FirstOrDefault());


            }

            catch (Exception )
            {
                throw ;
            }
        }
    }
}

