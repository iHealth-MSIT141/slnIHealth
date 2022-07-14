using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.ViewModels
{
    public class CLoginViewModel
    {
        public string fUserName { get; set; }
        [DataType(DataType.Password)]
        public string fPassword { get; set; }
        public string fEmail { get; set; }
        public int fAuthorityId { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
