using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace prjIHealth.Models
{
    public partial class TOrder
    {
        public TOrder()
        {
            TOrderDetails = new HashSet<TOrderDetail>();
        }

        public int FOrderId { get; set; }
        [DisplayName("付款")]
        public int FPaymentCategoryId { get; set; }
        [DisplayName("日期")]
        public string FDate { get; set; }
        public int FMemberId { get; set; }
        [DisplayName("地址")]
        public string FAddress { get; set; }
        [DisplayName("收件人")]
        public string FContact { get; set; }
        [DisplayName("電話")]
        public string FPhone { get; set; }
        [DisplayName("備註")]
        public string FRemarks { get; set; }
        [DisplayName("狀態")]
        public int FStatusNumber { get; set; }

        public virtual TMember FMember { get; set; }
        public virtual TPaymentCategory FPaymentCategory { get; set; }
        public virtual TStatus FStatusNumberNavigation { get; set; }
        public virtual ICollection<TOrderDetail> TOrderDetails { get; set; }
    }
}
