using Microsoft.AspNetCore.Mvc;

namespace TaskManagerUI.Controllers
{
	public class WorkspaceController : Controller
	{
		public IActionResult Index()
		{

			return View();
		}
	}
}
