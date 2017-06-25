using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMS.BusinessEntities;
using OMS.DataAccess;

namespace OMS.BusinessComponents
{
    public class ListComponent
    {
        public List<SelectListItem> GetListItemsById(string listCode)
        {
            ListDB lst = new ListDB();
            IList<ListItem> listItemsDB = lst.GetListItemsById(listCode);
            List<SelectListItem> selectListItems=new List<SelectListItem>();
            foreach (var item in listItemsDB)
            {
                SelectListItem newItem = new SelectListItem { Text = item.Name, Value = item.Code };
                selectListItems.Add(newItem);
            }
            return selectListItems;
        }
    }
}
