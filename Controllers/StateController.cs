using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CensusManagement_System.Models;
using CensusManagement_System.Services;
using CensusManagement_System.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CensusManagement_System.Controllers
{
    public class StateController : Controller
    {
        private readonly IState state;
        private readonly UserManager<User> userManager;
        public StateController(IState state, UserManager<User> userManager)
        {
            this.state = state;
            this.userManager = userManager;
        }
        // GET: State
        public ActionResult Index()
        {
            var result = state.GetStates();
            return View(result);
        }

        // GET: State/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "the Item Could not be found";
                return View("NotFound");
            }
            var choice = state.GetState(id);
            if (choice == null)
            {
                ViewBag.Message = "The item could not be retrieved";
                return View("NotFound");
            }
            return View(choice);
        }

        public IActionResult DetailsView(int? id)
        {
            var det = new DetailsStateViewModel();
            if (id==null)
            {
                ViewBag.Message = $"Sorry We could not find what you were looking for because the state with id of {id} is missing.";
                return View("NotFound");
            }

            det.StateId = id;
            det.State = state.GetState(id);
            var choice = det.State;
            det.NumberOfCitezens = userManager.Users.Where(x => x.State == choice).Count();
            return View(det);
        }

        // GET: State/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: State/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(State obj)
        {
            try
            {
                // TODO: Add insert logic here
                state.Create(obj);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: State/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id==null)
            {
                ViewBag.Message = "the Item Could not be found";
                return View("NotFound");
            }
            
            var choice = state.GetState(id);
            if (choice==null)
            {
                ViewBag.Message = "The item could not be retrieved";
                return View("NotFound");
            }
            return View(choice);
        }

        // POST: State/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, State obj)
        {
            try
            {
                // TODO: Add update logic here
                state.Update(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: State/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "the Item Could not be found";
                return View("NotFound");
            }
            var choice = state.GetState(id);
            return View(choice);
        }

        // POST: State/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, State obj)
        {
            try
            {
                // TODO: Add delete logic here
                state.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}