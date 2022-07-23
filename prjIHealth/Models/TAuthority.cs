using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TAuthority
    {
        public TAuthority()
        {
            TMembers = new HashSet<TMember>();
        }
        [DisplayName("權限代碼")]
        public int FAutorityId { get; set; }
        [DisplayName("權限名稱")]
        public string FAuthorityName { get; set; }
        [DisplayName("備註")]
        public string FRemarks { get; set; }

        public virtual ICollection<TMember> TMembers { get; set; }
    }
}
