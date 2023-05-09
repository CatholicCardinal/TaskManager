using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagerUI.Controllers
{
	public class WorkspaceController : Controller
	{
		private IWorkspaceService _workspaceService;

		public WorkspaceController(IWorkspaceService workspaceService)
		{
			_workspaceService = workspaceService;
		}

		public IActionResult WorkspaceMenu()
		{
			return View(_workspaceService.GetAllWorkspacesByUser(1));
		}
	}
}
