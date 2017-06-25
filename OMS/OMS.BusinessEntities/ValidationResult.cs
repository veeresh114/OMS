using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BusinessEntities
{
    public class ValidationResults
    {
        public int Id { get; set; }
        public string ValidationMessage { get; set; }
        public bool Success { get; set; }
    }
}
