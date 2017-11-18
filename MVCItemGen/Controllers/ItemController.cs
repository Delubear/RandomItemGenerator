using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using MVCItemGen.ViewModels;

namespace MVCItemGen.Controllers
{
    public class ItemController : Controller
    {
        private readonly IBaseItemRepository _baseItemRespository;

        public ItemController(IBaseItemRepository baseItemRepository)
        {
            _baseItemRespository = baseItemRepository;
        }

        public ViewResult List()
        {
            IEnumerable<BaseItemModel> items;

            items = _baseItemRespository.BaseItemRepository.OrderBy( i => i.Id);

            return View(new ItemListViewModel
            {
                ItemList = items
            });
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}