using prjiHealth.Models;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.ViewModels
{
    public class CBodyRecordViewModel
    {
        public int FBodyRecordId { get; set; }
        public int? FMemberId { get; set; }
        public string FRecordDate { get; set; }
        public double? FWorkload { get; set; }
        public double? FHeight { get; set; }
        public double? FWeight { get; set; }

        public virtual TMember FMember { get; set; }
        public double NumBMI
        {
            get
            {
                return (double)FWeight / Math.Pow((double)(FHeight / 100), 2);
            }
        }
    }
}
