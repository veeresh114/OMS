using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OMS.ViewModels;
using OMS.BusinessComponents;
using OMS.BusinessEntities;
using AutoMapper;
using System.Linq;

namespace OMS.Controllers
{
    public class BuyerRegistrationController : BaseController
    {
        
        public ActionResult RegisterNewBuyerGet()
        {
            var viewModel = new BuyerRegistrationViewModel();
            ListComponent lstComponent = new ListComponent();
            viewModel.Countries = lstComponent.GetListItemsById("Country");
            viewModel.Cities = lstComponent.GetListItemsById("City");
            viewModel.AreBothAddressSameOptions  = lstComponent.GetListItemsById("YesOrNo");
            return View("RegisterNewBuyer", viewModel);
        }

        [HttpPost]
        public ActionResult RegisterNewBuyer(BuyerRegistrationViewModel postModel)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<BuyerRegistrationViewModel, Buyer>();
                Mapper.CreateMap<BuyerRegistrationViewModel, User>();
                Buyer buyer = Mapper.Map<BuyerRegistrationViewModel, Buyer>(postModel);
                User user = Mapper.Map<BuyerRegistrationViewModel, User>(postModel);

                UserComponent userComponent = new UserComponent();
                ValidationResults vResult = userComponent.CreateUser(user);
                postModel.ValidationResult = vResult;
                if (vResult.Success == true)
                {
                    BuyerComponent buyerComponent = new BuyerComponent();
                    vResult = buyerComponent.RegisterNewBuyer(buyer);
                    postModel.ValidationResult = vResult;
                }

            }
            else
            {
                ListComponent lstComponent = new ListComponent();
                postModel.Countries = lstComponent.GetListItemsById("Country");
                postModel.Cities = lstComponent.GetListItemsById("City");
                postModel.AreBothAddressSameOptions = lstComponent.GetListItemsById("YesOrNo");
           }
            return View("RegisterNewBuyer", postModel);
        }
        private JsonResult GetCityList(string Country)
        {
            ListComponent lstComponent = new ListComponent();
            var cities = lstComponent.GetListItemsById(Country);
            return Json(cities, JsonRequestBehavior.AllowGet);  
        }
        
    }
}
