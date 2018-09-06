using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using MVCItemGen.ViewModels;
using System;
using System.Linq;

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
            if(retry == false)
                return View(new ItemListViewModel { Failure = false, Generating = false });
            else
                return View(new ItemListViewModel { Failure = true, Generating = false });            
        }

        public ViewResult Generate(int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                _baseItemRespository.AddRandomItem();
            }
            _baseItemRespository.SaveChanges();
            return View(new ItemListViewModel { ItemList = _baseItemRespository.BaseItemRepository.TakeLast(amount).ToList(), Generating = true });
        }

        public ViewResult ShowAll()
        {
            return View(new ItemListViewModel { ItemList = _baseItemRespository.BaseItemRepository, Generating = true });
        }
        
        [HttpPost]
        public ActionResult List(ItemListViewModel ilvm)
        {
            if (ModelState.IsValid)
            {
                int outParse;
                if(int.TryParse(ilvm.Amount, out outParse))
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