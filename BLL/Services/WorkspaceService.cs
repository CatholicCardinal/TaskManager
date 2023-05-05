using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class WorkspaceService
	{
		private readonly IUnitOfWork _db;

		public WorkspaceService(IUnitOfWork db)
		{
			_db = db;
		}

		public IEnumerable<Workspace> GetAllWorkspacesList()
		{
			return _db.Workspaces.GetAll();
		}

		public Workspace GetWorkspaceById(int id)
		{
			return _db.Workspaces.Get(id);
		}

		public void DeleteWorkspace(int id)
		{
			var employee = _db.Workspaces.Get(id);
			_db.Workspaces.Remove(employee);
			_db.Save();
		}

		public void AddWorkspace(Workspace workspace)
		{
			_db.Workspaces.Save(workspace);
			_db.Save();
		}

		public IEnumerable<Desk> GetAllDeskList()
		{
			return _db.Desks.GetAll();
		}
	}
}
