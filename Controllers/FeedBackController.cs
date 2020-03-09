using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CensusManagement_System.Models;
using CensusManagement_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace CensusManagement_System.Controllers
{
    public class FeedBackController : Controller
    {
        private readonly IFeedBack feedBack;

        public FeedBackController(IFeedBack feedBack)
        {
            this.feedBack = feedBack;
        }
        public IActionResult Index()
        {
            var res = feedBack.GetFeedBacks();
            return View(res);
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id==null)
            {
                ViewBag.Message = "we could not find the feedback must have already been deleted please refresh";
                return View("NotFound");
            }
            feedBack.Delete(id);
            return View("Index");
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FeedBack obj)
        {
            try
            {
                if (obj is null)
                {
                    ViewBag.Message = "Something Went Wrong when creating the obj pls try again";
                    return View("NotFound");
                }
                feedBack.Create(obj);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View("NotFound");
            }
           
        }
    }
}