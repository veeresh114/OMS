using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMS.BusinessEntities;
using OMS.DataAccess;

namespace OMS.BusinessComponents
{
    public class BuyerComponent
    {
        private BuyerDB buyerDb;
        public ValidationResults RegisterNewBuyer( Buyer buyer)
        {
            ValidationResults result = buyerDb.RegisterNewBuyer(buyer);
            return result;
            
        }
    }
}
