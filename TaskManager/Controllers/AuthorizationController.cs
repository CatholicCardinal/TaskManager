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
		public ActionResult Login(LoginModel  model)
		{
			// Ваш код для проверки учетных данных пользователя
			_authorization.Login(model.Email, model.Password);
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
