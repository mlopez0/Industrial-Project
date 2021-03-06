﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EnergyAndMaterialBalanceModule.Models;
using EnergyAndMaterialBalanceModule.Data;
using Microsoft.EntityFrameworkCore;
using EnergyAndMaterialBalanceModule.Data.Repositories;
using Microsoft.AspNetCore.Http;

namespace EnergyAndMaterialBalanceModule.Controllers
{ 
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;
        private readonly IResourcesRepository _resourceRepository;

        const string SessionSelectedResource = "_Resource";

        public MainController(ILogger<MainController> logger, IResourcesRepository resourceRepository)
        {
            _logger = logger;
            _resourceRepository = resourceRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Resources> resources = await _resourceRepository.GetAllResources();
            ViewData["Resources"] = resources;
            return View();
        }

       [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            IEnumerable<Resources> resources = await _resourceRepository.GetAllResources();
            ViewData["Resources"] = resources;
            HttpContext.Session.SetInt32(SessionSelectedResource, id);
            ViewData["SelectedResource"] = HttpContext.Session.GetInt32(SessionSelectedResource);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
