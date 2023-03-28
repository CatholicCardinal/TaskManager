using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class WorkspaceDesk
    {
        public int WorkspaceID { get; set; }
        public int DeskID { get; set; }

        public Workspace Workspace { get; set; }
        public Desk Desk { get; set; } 
    }
}
