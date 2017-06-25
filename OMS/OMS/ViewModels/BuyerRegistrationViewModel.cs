using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using OMS.BusinessEntities;

namespace OMS.ViewModels
{
    public class BuyerRegistrationViewModel
    {
        [ScaffoldColumn(false)]
        public int UserId {get; private set;}

        [Required(ErrorMessage = "UserName is mandatory")]
        public string UserName { get; set; }

        [Required(ErrorMessage="Password is mandatory")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8,ErrorMessage="Minimum Password Length is 8 Chars")]
        public string Password { get; set; }

        
        [DataType(DataType.Password)]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [Required(ErrorMessage = "Confirm Password is mandatory")]
        public string ConfirmPassword { get; set; }

        [ScaffoldColumn(false)]
        public int? BuyerId { get; private set; }

        [Required(ErrorMessage = "CompanyName is mandatory")]
        [DataType(DataType.Text)]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "CompanyDescription is mandatory")]
        public string CompanyDescription { get; set; }

        [Required(ErrorMessage = "CompanyContactName is mandatory")]
        public string CompanyContactName { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [Required(ErrorMessage = "EmailAddress is mandatory")]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "ContactNo is mandatory")]
        public int? ContactNo { get; set; }

        [Required(ErrorMessage = "PermanentAddress is mandatory")]
        public string PermanentAddress { get; set; }

        [Required(ErrorMessage = "ShippingAddress is mandatory")]
        public string ShippingAddress { get; set; }

        [Required(ErrorMessage = "City is Mandatory")]
        public string City { get; set; }

        public List<SelectListItem> Cities { get; set; }

        [Required(ErrorMessage = "BankAccountNo is mandatory")]
        public int? BankAccountNo { get; set; }

        [Required(ErrorMessage = "Country is mandatory")]
        public string Country { get; set; }

        public List<SelectListItem> Countries { get; set; }

        [Required(ErrorMessage = "Role")]
        public string Role { get; set; }

        [ScaffoldColumn(false)]
        public ValidationResults ValidationResult { get; set; }

        public List<SelectListItem> AreBothAddressSameOptions { get; set; }

        [Required(ErrorMessage = "Please mention if both address are same")]
        public string AreBothAddressSame { get; set; }


    }
}