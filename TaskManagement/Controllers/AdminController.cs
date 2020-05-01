using BLL.Enums;
using BLL.Interfaces;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Services.Description;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly iAdminOperations adminServices;
        // GET: Admin
        public AdminController(iAdminOperations _adminServices)
        {
            adminServices = _adminServices;
        }
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public PartialViewResult NewProject()
        {
                return PartialView("_NewProject",new ProjectViewModel());
        }
        
        
        [HttpPost]
        public JsonResult CreateProject(ProjectViewModel model)
        {
            string response = adminServices.CreateProject(new BLL.DTO.ProjectDTO() { Label = model.Label, CreatedById = 1 });
            return Json(new { Message = response });
        }

        [HttpPost]
        public JsonResult CreateTask(ProjectTaskModel model)
        {
            string response = adminServices.AddNewTask(new BLL.DTO.ProjectTasksDTO() { Label = model.Label, CreatedById = 1 ,ProjectId = model.ProjectId,PriorityStatusId = model.PriorityStatusId,TaskStatusId=(int)TaskStatusEnum.Created});
            return Json(new { Message = response });
        }

        [HttpGet]
        public PartialViewResult NewTask()
        {
            var projects = new SelectList(adminServices.GetProjects(), "ProjectId", "Label");
            var priorities =  new SelectList(adminServices.GetPriorities(), "PriorityId", "Label");
            return PartialView("_NewTask",new ProjectTaskModel() { Projects = projects ,Priorities = priorities });
        }

        [HttpGet]
        public PartialViewResult NewRoles()
        {
            return PartialView("_NewRoles");
        }

        [HttpGet]
        public PartialViewResult NewUsers()
        {
            return PartialView("_NewUsers");
        }

        [HttpGet]
        public PartialViewResult AssigntToProject()
        {
            return PartialView("_AssigntToProject");
        }
    }
}