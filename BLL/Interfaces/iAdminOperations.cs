using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface iAdminOperations
    {
        string CreateProject(ProjectDTO projectDTO);
        string AddNewTask(ProjectTasksDTO projectTasksDTO);

        IEnumerable<Project> GetProjects();
        IEnumerable<TaskPriority> GetPriorities();
    }
}
