using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using MVCItemGen.ViewModels;
using RPGItemGenerator.ItemGeneration;
using System;

namespace MVCItemGen.Controllers
{
    public class ItemController : Controller
    {
        private readonly IBaseItemRepository _baseItemRespository;
        public ItemController(IBaseItemRepository baseItemRepository)
        {
            _baseItemRespository = baseItemRepository;
        }
        
        public ActionResult List()
        {
            List<Item> items;
            items = _baseItemRespository.BaseItemRepository; 
            return View(new ItemListViewModel()); 
        }

        public ViewResult Generate(int amount)
        {
            List<Item> items ;            

            items = _baseItemRespository.BaseItemRepository;
            for(int i = 0; i < amount; i++)
            {
                items.Add(_baseItemRespository.AddRandomItem());
            }
            return View(new ItemListViewModel { ItemList = items });
        }
        
        [HttpPost]
        public ActionResult List(ItemListViewModel ilvm)
        {
            if (ModelState.IsValid)
            {
                var myint = Convert.ToInt32(ilvm.Amount);
                return RedirectToAction("Generate", new { amount = myint });
            }
            return View();
        }
    }
}