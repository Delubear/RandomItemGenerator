﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCItemGen.Model;
using MVCItemGen.ViewModels;
using RPGItemGenerator.ItemGeneration;

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

            items = _baseItemRespository.BaseItemRepository.OrderBy( i => i.Name);

            return View(new ItemListViewModel
            {
                ItemList = items
            });
        }
    }
}