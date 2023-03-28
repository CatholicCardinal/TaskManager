using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Workspace : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public ICollection<WorkspaceDesk> WorkspaceDesks { get; set; }
        public ICollection<UserWorkspace> UserWorkspaces { get; set; }
    }
}
