using BLL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class AuthorizationService : IAuthorizationService
	{
		private readonly IUnitOfWork _db;

		public AuthorizationService(IUnitOfWork db)
		{
			_db = db;
		}
		public List<User> GetAllUsers(string email, string password)
		{
			return _db.Users.GetAll().ToList();
		}

		public User GetUserByLoginAndPassword(string email, string password)
		{
			var allUsers = _db.Users.GetAll().ToList();
			var user = allUsers.Find(x => x.Email == email && x.Password == password);
			return user;
		}

		public int AddUser(string name, string email, string password)
		{
			var allUsers = _db.Users.GetAll().ToList();
			var finding = allUsers.Find(x => x.Email == email);
			if (finding == null)
			{
				User user = new User { FirstName = name,  Email = email, Password = password };
				_db.Users.Save(user);
				_db.Save();

				return 1;
			}

			return 0;
		}

	}
}
