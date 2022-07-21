using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class COrderDetailViewModel
    {
        public COrderDetailViewModel()
        {
            _prod = new TOrderDetail();
        }
        private TOrderDetail _prod;
        public TOrderDetail orderdetail
        {
            get { return _prod; }
            set { _prod = value; }
        }
        public int FOrderDetailsId
        {
            get { return _prod.FOrderDetailsId; }
            set { _prod.FOrderDetailsId = value; }
        }
        public int FOrderId
        {
            get { return _prod.FOrderId; }
            set { _prod.FOrderId = value; }
        }
        public int FProductId
        {
            get { return _prod.FProductId; }
            set { _prod.FProductId = value; }
        }
        public int FQuantity
        {
            get { return _prod.FQuantity; }
            set { _prod.FQuantity = value; }
        }
        public decimal FUnitprice
        {
            get { return _prod.FUnitprice; }
            set { _prod.FUnitprice = value; }
        }
        public int FDiscountId
        {
            get { return _prod.FDiscountId; }
            set { _prod.FDiscountId = value; }
        }

        public TProduct fproduct { get; set; }
        public TDiscount fdiscount { get; set; }

    }
}
