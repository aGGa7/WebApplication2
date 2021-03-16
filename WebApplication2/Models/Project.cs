using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
       
        public string Cipher { get; set; }
        
        public string Name { get; set; }

        public DateTime DateCreate { get; set; }
        public DateTime DateEdit { get; set; }

        public List<ObjectOfProject> Objects { get; set; }

    }
}
