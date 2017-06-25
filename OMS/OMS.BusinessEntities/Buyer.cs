using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BusinessEntities
{
    public class Buyer
    {
        public int? BuyerId { get; set; } 
        public string CompanyName{get; set; } 	
        public string CompanyDescription{get; set; } 	
        public string CompanyContactName{get; set; } 	
        public string EmailAddress 	{get; set; } 
        public int? ContactNo	{get; set; } 
        public string PermanentAddress	{get; set; } 
        public string ShippingAddress{get; set; } 	
        public string City{get; set; } 
        public int? BankAccountNo{get; set; }
        public string Country { get; set; } 

    }
}
