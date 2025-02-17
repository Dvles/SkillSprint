using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    internal static class Mapper
    {
		public static User ToUser(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			//if (record is null) return null;
			return new User()
			{
				User_Id = (Guid)record[nameof(User.User_Id)],
				First_Name = (string)record[nameof(User.First_Name)],
				Last_Name = (string)record[nameof(User.Last_Name)],
				Email = (string)record[nameof(User.Email)],
				Password = "********",
			};
		}
	}
}
