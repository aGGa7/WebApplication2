using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ObjectOfProject
    {
        public int ObjectOfProjectID { get; set; }
        public string Code { get; set; }

        public  Project Project { get; set; }
        public string Name { get; set; }
    }
}
