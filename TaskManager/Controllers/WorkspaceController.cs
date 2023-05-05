using Microsoft.AspNetCore.Mvc;

namespace TaskManagerUI.Controllers
{
	public class WorkspaceController : Controller
	{
		public IActionResult WorkspaceMenu()
		{

			return View();
		}
	}
}
