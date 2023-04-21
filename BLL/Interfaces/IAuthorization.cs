using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IAuthorization
	{
		public User GetUserByLoginAndPassword(string email, string password);
		public void Registrate(string Name, string email, string password);
	}
}
