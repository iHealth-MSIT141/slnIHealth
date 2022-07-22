using System;
using System.Collections.Generic;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TCourse
    {
        public TCourse()
        {
            TReservations = new HashSet<TReservation>();
        }

        public int FCourseId { get; set; }
        public int? FCoachContactId { get; set; }
        public int? FRemainingCourse { get; set; }
        public int? FStatusNumber { get; set; }
        public bool? FVisible { get; set; }

        public virtual TCoachContact FCoachContact { get; set; }
        public virtual TStatus FStatusNumberNavigation { get; set; }
        public virtual ICollection<TReservation> TReservations { get; set; }
    }
}
