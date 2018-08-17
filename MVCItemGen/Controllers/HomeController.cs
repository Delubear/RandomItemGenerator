using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using MVCItemGen.Model.BaseItem;
using MVCItemGen.ViewModels;
using System;
using System.Collections.Generic;

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
            if(items == null)
            {
                items = new List<SarahsItem>();
            }
            items = _baseItemRespository.BaseSarahRepo;
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SarahsItem item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            item.Id = Guid.NewGuid().ToString();
            items.Add(item);
            _baseItemRespository.BaseSarahRepo = items;
            SaveList();

            return RedirectToAction("SList");
        }

        public void SaveList()
        {
            _baseItemRespository.SaveChanges();
        }
    }
}