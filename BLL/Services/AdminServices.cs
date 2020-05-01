using BLL.DTO;
using BLL.Enums;
using BLL.Interfaces;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminServices : iAdminOperations
    {
        private readonly Task_ManagementEntities db = new Task_ManagementEntities();
        public string CreateProject(ProjectDTO projectDTO)
        {
            try
            {
                Project project = db.Projects.Where(a => a.Label == projectDTO.Label).FirstOrDefault();
                if (project != null)
                    return "Duplicate Exists";
                project = new Project()
                {
                    Label = projectDTO.Label,
                    CreatedById =projectDTO.CreatedById??-99,
                    CreatedDate=DateTime.UtcNow
                };
                db.Projects.Add(project);
                db.SaveChanges();
                return "Successfully Created";
            }
            catch (Exception ex)
            {
                return "Something went wrong" + ex.Message ;
            }
        }
        public string AddNewTask(ProjectTasksDTO projectTasksDTO)
        {
            try
            {
                var project = db.Projects.Find(projectTasksDTO.ProjectId);
                if (project == null)
                    return "Selected project Not Found";
                Projects_Tasks projects_Tasks = db.Projects_Tasks.Where(a => a.Label == projectTasksDTO.Label && a.ProjectId == projectTasksDTO.ProjectId).FirstOrDefault();
                if (projects_Tasks != null)
                    return "Task already exists for selected Project";

                projects_Tasks = new Projects_Tasks()
                {
                    Label = projectTasksDTO.Label,
                    ProjectId = projectTasksDTO.ProjectId,
                    CreatedById = projectTasksDTO.CreatedById,
                    CreatedDate = DateTime.UtcNow,
                    PriorityStatusId = Convert.ToInt16(projectTasksDTO.PriorityStatusId),
                    TaskStatusId = Convert.ToInt16(projectTasksDTO.TaskStatusId)
                };

                db.Projects_Tasks.Add(projects_Tasks);
                db.SaveChanges();
                return "Successfully Created";
            }
            catch (Exception ex)
            {
                return "Something went wrong" + ex.Message;
            }
        }

        public IEnumerable<Project> GetProjects()
        {
            return db.Projects.AsEnumerable();
        }

        public IEnumerable<TaskPriority> GetPriorities()
        {
            return db.TaskPriorities.AsEnumerable();
        }
    }

}
