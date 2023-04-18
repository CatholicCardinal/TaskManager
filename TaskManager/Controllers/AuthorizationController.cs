using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagerUI.Controllers
{
	public class AuthorizationController : Controller
	{
		private readonly ILogger<AuthorizationController> _logger;
		public AuthorizationController(ILogger<AuthorizationController> logger)
		{
			_logger = logger;
		}
		public ActionResult Index()
		{
			return Index();
		}
		
	}
}
