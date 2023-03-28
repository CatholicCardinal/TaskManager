using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserWorkspace
    {
        public int UserID { get; set; }
        public int WorkspaceID { get; set; }
        public Workspace Workspace { get; set; }
        public User User { get; set; }

    }
}
