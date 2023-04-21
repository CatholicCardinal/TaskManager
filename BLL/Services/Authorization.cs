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
	public class Authorization : IAuthorization
	{
		private readonly IUnitOfWork _db;

		public Authorization(IUnitOfWork db)
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

		public void Registrate(string Name, string email, string password)
		{
			throw new NotImplementedException();
		}

	}
}
