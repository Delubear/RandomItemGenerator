using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using MVCItemGen.ViewModels;
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
        

        public ActionResult List(bool retry = false)
        {
            //List<Item> items;
            //items = _baseItemRespository.BaseItemRepository; 
            if(retry == false)
            {
                return View(new ItemListViewModel { Failure = false });
            }
            else
            {
                return View(new ItemListViewModel { Failure = true });
            }
            
        }

        public ViewResult Generate(int amount)
        {
            _baseItemRespository.Reset();
            //List<Item> items ;            

            //items = _baseItemRespository.BaseItemRepository;
            for(int i = 0; i < amount; i++)
            {
                _baseItemRespository.AddRandomItem();
            }
            return View(new ItemListViewModel { ItemList = _baseItemRespository.BaseItemRepository });
        }
        
        [HttpPost]
        public ActionResult List(ItemListViewModel ilvm)
        {
            if (ModelState.IsValid)
            {
                int outParse;
                if(Int32.TryParse(ilvm.Amount, out outParse))
                {
                    var myint = Convert.ToInt32(ilvm.Amount);
                    return RedirectToAction("Generate", new { amount = myint });
                }
                else
                {
                    return RedirectToAction("List", new { retry = true });
                }
                
            }
            return View();
        }
    }
}