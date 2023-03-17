using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace аряяяяяяяя.Models.vm
{
    public class UserNameViewModel
    {
        //[Required(ErrorMessage = "Имя быстро ввел пидр")]
        [MaxLength(20, ErrorMessage = "иди нахуй")]
        public string Name { get; set; }
    }
}
