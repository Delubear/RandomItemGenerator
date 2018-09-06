using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCItemGen.Controllers
{
    public class HomeController : Controller
    {
        private readonly SarahDBContext _context;

        public HomeController(SarahDBContext context)
        {
            _context = context;
        }

        public List<SarahsItem> items;

        public IActionResult Index()
        {
            return View();
        }     
        
        public IActionResult SList()
        {
            items = _context.SarahsItems.ToList();            
            List<SarahsItem> orderedList = items.Where(i => i.DateCompleted == null).ToList();
            orderedList.AddRange(items.Where(i => i.DateCompleted != null).ToList());
            return View(orderedList);
        }      

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SarahsItem item)
        {
            items = _context.SarahsItems.ToList();

            item.Id = Guid.NewGuid().ToString();
            item.DateAdded = DateTime.Today;
            items.Add(item);
            _context.SarahsItems.Add(item);
            _context.SaveChanges();

            return RedirectToAction("SList");
        }

        public IActionResult Edit(string Id)
        {
            SarahsItem item = _context.SarahsItems.FirstOrDefault(c => c.Id == Id);
            if(item == null)
                return RedirectToAction("Slist");            
            else
                return View(item);
        }

        [HttpPost]
        public IActionResult Edit(SarahsItem item, string Id)
        {
            var itemToEdit =_context.SarahsItems.FirstOrDefault(c => c.Id == Id);
            if(itemToEdit == null)
                return RedirectToAction("Slist");
            else
            {
                itemToEdit.Name = item.Name;
                itemToEdit.Description = item.Description;
                itemToEdit.TypeOfItem = item.TypeOfItem;
                _context.SarahsItems.Update(itemToEdit);
                _context.SaveChanges();
                return RedirectToAction("Slist");                
            }
        }

        public ActionResult Delete(string Id)
        {
            SarahsItem item = _context.SarahsItems.FirstOrDefault(c => c.Id == Id);
            if (item == null)
                return RedirectToAction("Slist");
            else
                return View(item);
        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult ConfirmDelete(string Id)
        {
            SarahsItem item = _context.SarahsItems.FirstOrDefault(c => c.Id == Id);
            if (item == null)
                return RedirectToAction("Slist");
            else
            {
                _context.SarahsItems.Remove(item);
                return RedirectToAction("Slist");
            }
        }

        public IActionResult Complete(string Id)
        {
            SarahsItem item = _context.SarahsItems.FirstOrDefault(c => c.Id == Id);
            if (item == null)
                return RedirectToAction("Slist");
            else
                return View(item);
        }

        [HttpPost]
        public IActionResult Complete(SarahsItem item, string Id)
        {
            var itemToEdit = _context.SarahsItems.FirstOrDefault(c => c.Id == Id);
            if (itemToEdit == null)
                return RedirectToAction("Slist");
            else
            {
                itemToEdit.DateCompleted = DateTime.Today;
                _context.SarahsItems.Update(itemToEdit);
                _context.SaveChanges();
                return RedirectToAction("Slist");
            }
        }

        public void SaveList()
        {
            _context.SaveChanges();            
        }
    }
}