using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BusinessEntities
{
     public class ListItem
    {
         public int ListId {get;set;}
         public string Code {get;set;}
         public string Name {get;set;}
         public string Descri { get; set; }
         public bool Ordinal { get; set; }
    }
}
