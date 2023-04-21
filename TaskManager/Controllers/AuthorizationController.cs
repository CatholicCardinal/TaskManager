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
			return View();
		}


		[HttpPost]
		public ActionResult Authorization(RegistarateModel  model)
		{
			// Ваш код для проверки учетных данных пользователя
			var user = _authorization.GetUserByLoginAndPassword(model.Email, model.Password);
			if (user != null)
			{
				return RedirectToAction("Index", "Home");
			}

			ViewBag.ErrorMessage = "Please enter a valid email address or password";

			return View();
		}

		[HttpPost]
		public ActionResult Registrate(RegistarateModel model)
		{
			// Ваш код для создания нового пользователя
			_authorization.Registrate(model.Name, model.Email, model.Password);
			return View();
		}
	}
}
