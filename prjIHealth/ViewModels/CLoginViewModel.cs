using Microsoft.AspNetCore.Http;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.ViewModels
{
    public class CLoginViewModel
    {
        private  TMember _tmember;
        public CLoginViewModel() { _tmember = new TMember(); }
        public TMember Member { get { return _tmember; } set {_tmember=value; } }
        public string fUserName { get { return _tmember.FUserName; } set { _tmember.FUserName = value; } }
        [DataType(DataType.Password)]
        public string fPassword { get { return _tmember.FPassword; } set { _tmember.FPassword = value; } }
        public string fEmail { get { return _tmember.FEmail; } set { _tmember.FEmail = value; } }
        public int fAuthorityId {  get; set; }
            [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
        public int MyProperty { get; set; }
        public IFormFile photo { get; set; }

    }
}
