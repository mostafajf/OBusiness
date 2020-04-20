

using System;
using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{

    public class Category
    {

        public int ID { get; set; }

        public String Name { get; set; }

        public string PhotoUrl { get; set; }

        public List<SubMenuItem> SubMenuItems { get; set; }
        public string Description { get; set; }
    }
}
