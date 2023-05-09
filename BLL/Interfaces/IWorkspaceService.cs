using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IWorkspaceService
	{
		public IEnumerable<Workspace> GetAllWorkspacesList();
		public IEnumerable<UserWorkspace> GetAllWorkspacesByUser(int id);
		Workspace GetWorkspaceById(int id);
		public void DeleteWorkspace(int id);
		public void AddWorkspace(Workspace workspace);

	}
}
