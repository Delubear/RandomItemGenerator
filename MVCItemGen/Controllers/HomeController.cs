using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using MVCItemGen.Model.BaseItem;
using MVCItemGen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace MVCItemGen.Controllers
{
    public class HomeController : Controller
    {
        private iSarahRepo _baseItemRespository;
        public HomeController(iSarahRepo baseItemRepository)
        {
            _baseItemRespository = baseItemRepository;
        }

        public List<SarahsItem> items;

        public IActionResult Index()
        {
            return View();
            //return RedirectToAction("List", "Item");
        }     
        
        public IActionResult SList()
        {
            items = _baseItemRespository.BaseSarahRepo.ToList();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SarahsItem item)
        {
            /*
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            */
            items = _baseItemRespository.BaseSarahRepo.ToList();

            item.Id = Guid.NewGuid().ToString();
            item.DateAdded = DateTime.Today;
            items.Add(item);
            _baseItemRespository.Add(item);
            _baseItemRespository.SaveChanges();

            return RedirectToAction("SList");
        }

        public IActionResult Edit(string Id)
        {
            SarahsItem item = _baseItemRespository.BaseSarahRepo.FirstOrDefault(c => c.Id == Id);
            if(item == null)
            {
                return RedirectToAction("Slist");
            }
            else
            {
                return View(item);
            }
        }

        [HttpPost]
        public IActionResult Edit(SarahsItem item, string Id)
        {
            var itemToEdit = _baseItemRespository.BaseSarahRepo.FirstOrDefault(c => c.Id == Id);
            if(itemToEdit == null)
            {
                return RedirectToAction("Slist");
            }
            else
            {
                itemToEdit.Name = item.Name;
                itemToEdit.Description = item.Description;
                itemToEdit.TypeOfItem = item.TypeOfItem;
                _baseItemRespository.Update(itemToEdit);
                _baseItemRespository.SaveChanges();
                return RedirectToAction("Slist");
                
            }
        }


        public ActionResult Delete(string Id)
        {
            SarahsItem item = _baseItemRespository.BaseSarahRepo.FirstOrDefault(c => c.Id == Id);
            if (item == null)
            {
                return RedirectToAction("Slist");
            }
            else
            {
                return View(item);
            }
        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult ConfirmDelete(string Id)
        {
            SarahsItem item = _baseItemRespository.BaseSarahRepo.FirstOrDefault(c => c.Id == Id);
            if (item == null)
            {
                return RedirectToAction("Slist");
            }
            else
            {
                _baseItemRespository.Delete(item);
                return RedirectToAction("Slist");
            }
        }



        public void SaveList()
        {
            _baseItemRespository.SaveChanges();
            
        }
    }
}