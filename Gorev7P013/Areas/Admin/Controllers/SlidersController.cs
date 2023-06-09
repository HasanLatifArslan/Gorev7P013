﻿using Gorev7P013.Data;
using Gorev7P013.Models;
using Gorev7P013.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorev7P013.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public SlidersController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        // GET: SlidersController
        public ActionResult Index()
        {
            var model = _databaseContext.Sliders.ToList();
            return View(model);
        }

        // GET: SlidersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SlidersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SlidersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Slider collection, IFormFile? Image)
        {
            try
            {
                collection.Image = await FileHelper.FileLoaderAsync(Image);
                _databaseContext.Sliders.Add(collection);
                _databaseContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SlidersController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _databaseContext.Sliders.Find(id);
            return View(model);
        }

        // POST: SlidersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Slider collection, IFormFile? Image)
        {
            try
            {
                if (Image is not null)
                {
                    collection.Image = await FileHelper.FileLoaderAsync(Image);
                }
                _databaseContext.Sliders.Update(collection);
                _databaseContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SlidersController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _databaseContext.Sliders.Find(id);
            return View(model);
        }

        // POST: SlidersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Slider collection)
        {
            try
            {
                _databaseContext.Sliders.Remove(collection);
                _databaseContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
