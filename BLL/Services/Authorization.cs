using BLL.Interfaces;
using DAL.Repositories;
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

		public void Login(string email, string password)
		{
			throw new NotImplementedException();
		}

		public void Registrate(string Name, string email, string password)
		{
			throw new NotImplementedException();
		}

	}
}
