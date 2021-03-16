using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProjectController : Controller
    {
        private IObjectsRepository projects;
        public ProjectController(IObjectsRepository repo)
        {
            projects = repo;
        }
        public ViewResult Index()
        {
            return View(projects.Projects);
        }
    }
}
