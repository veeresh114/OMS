﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using System.Collections;
using System.Web.Routing;

namespace OMS.ViewModels
{
    public static  class HtmlHelper
    {
        //public static IHtmlString CustomDropDownList(this HtmlHelper helper, string name, IEnumerable<SelectListItem> list, object htmlAttributes)
        //{
        //    //Creating a select element using TagBuilder class which will create a dropdown.
        //    TagBuilder dropdown = new TagBuilder("select");
        //    //Setting the name and id attribute with name parameter passed to this method.
        //    dropdown.Attributes.Add("name", name);
        //    dropdown.Attributes.Add("id", name);

        //    //Created StringBuilder object to store option data fetched oen by one from list.
        //    StringBuilder options = new StringBuilder();
        //    //Iterated over the IEnumerable list.
        //    foreach (var item in list)
        //    {
        //        //Each option represents a value in dropdown. For each element in the list, option element is created and appended to the stringBuilder object.
        //        options = options.Append("<option value='" + item.Value + "'>" + item.Text + "</option>");
        //    }
        //    //assigned all the options to the dropdown using innerHTML property.
        //    dropdown.InnerHtml = options.ToString();
        //    //Assigning the attributes passed as a htmlAttributes object.
        //    dropdown.MergeAttributes(new RouteValueDictionary(htmlAttributes));
        //    //Returning the entire select or dropdown control in HTMLString format.
        //    return MvcHtmlString.Create(dropdown.ToString(TagRenderMode.Normal));
        //}
    }
}