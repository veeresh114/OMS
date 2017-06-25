using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMS.BusinessEntities;
using OMS.DataAccess;

namespace OMS.BusinessComponents
{
    public class UserComponent
    {
        private UserDB userDb = new UserDB();
        public ValidationResults CreateUser(User user)
        {
            ValidationResults result = userDb.CreateUser(user);
            return result;
        }
    }
}
