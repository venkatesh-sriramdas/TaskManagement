using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProjectTasksDTO
    {
        public string Label { get; set; }
        public int ProjectId { get; set; }
        public int PriorityStatusId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TaskStatusId { get; set; }
    }
}
