using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkFour.API.Models
{
    public class CompanyResponse
    {
        public object Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }
}
