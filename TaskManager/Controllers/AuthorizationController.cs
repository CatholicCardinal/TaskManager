using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagerUI.Models;

namespace TaskManagerUI.Controllers
{
	public class AuthorizationController : Controller
	{
		private readonly ILogger<AuthorizationController> _logger;
		private readonly IAuthorization _authorization;
		public AuthorizationController(ILogger<AuthorizationController> logger, IAuthorization authorization)
		{
			_logger = logger;
			_authorization = authorization;
		}

		[HttpGet]
		public ActionResult Authorization()
		{
			if(TempData["Error"] as string != null) 
			{
			  ViewBag.ErrorMessage = TempData["Error"] as string;
			}
			return View();
		}

		[HttpPost]
		public ActionResult Login(RegistarateModel  model)
		{
			// Ваш код для проверки учетных данных пользователя
			var user = _authorization.GetUserByLoginAndPassword(model.Email, model.Password);
			if (user != null)
			{
				return RedirectToAction("Index", "Workspace");
			}

			TempData["ErrorLogin"] = "Please enter a valid email address or password";

			//return View();
			return RedirectToAction("Authorization", "Authorization");
		}

		[HttpPost]
		public ActionResult Registration(RegistarateModel model)
		{
			// Ваш код для создания нового пользователя
			if(_authorization.AddUser(model.Name, model.Email, model.Password) == 1)
			{
				return RedirectToAction("Index", "Home");
			}

			TempData["ErrorRegistration"] = "Entering a email address is existing";

			//return View();
			return RedirectToAction("Authorization", "Authorization");
		}
	}
}
