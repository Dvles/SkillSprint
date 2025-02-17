using DAL.Entities;
using DAL.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Servicess
{
	public class UserService : IUserRepository
	{
		string connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SkillSprintDatabase;Integrated Security=True;";
		public IEnumerable<User> Get()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_User_GetAllActive";
					command.CommandType = CommandType.StoredProcedure;
					connection.Open();
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							yield return reader.ToUser();
						}
					}
				}
			}
		}

		
	}
}
