using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Enums
{
    public enum TaskStatusEnum : int
    {
        Created=1,
        InProcess=2,
        SLAcompleted=3,
        PartialCompelted=4,
        Completed=5
    }
}
