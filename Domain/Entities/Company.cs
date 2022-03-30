using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFour.Domain.Entitites
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
    }
}
