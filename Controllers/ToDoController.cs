﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreToDo.Models;
using AspNetCoreToDo.Services;

namespace AspNetCoreToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService ToDoItemService)
        {
            _toDoItemService = ToDoItemService;
        }

        public async Task<IActionResult> Index()
        {
            //Get items from the db
            var ToDoItems = await _toDoItemService.GetIncompleteItemsAsync();

            //Pass items to a model
            var model = new ToDoItemViewModel()
            {
                Items = ToDoItems
            };

            //Render a view with the model data
            return View(model);
        }
    }
}