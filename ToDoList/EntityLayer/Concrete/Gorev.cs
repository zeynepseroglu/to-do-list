using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Gorev
    {
        [Key]
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TamamlanmaOranı { get; set; }
        public string  StartTime { get; set; } //date
        public string  EndTime { get; set; } //date
        public string  User { get; set; } 
       
      

    }
}
