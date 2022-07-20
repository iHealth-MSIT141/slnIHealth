using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class CProductViewModel
    {
        public CProductViewModel()
        {
            _prod = new TProduct();
            //TOrderDetails = new HashSet<TOrderDetail>();
            //TProductsImages = new HashSet<TProductsImage>();
            //TTrackLists = new HashSet<TTrackList>();
        }
        private TProduct _prod;

        IHealthContext db = new IHealthContext();

        public IEnumerable<TProduct> ProductList
        {
            get
            {
                var pList = db.TProducts.OrderBy(c => c.FProductId);
                return pList;
            }
        }

        public IEnumerable<TTrackList> TrackList
        {
            get
            {
                var tList = db.TTrackLists.OrderBy(c => c.FMemberId);
                return tList;
            }
        }

        //public TProduct product
        //{
        //    get { return _prod; }
        //    set { _prod = value; }
        //}

        //public int FProductId
        //{
        //    get { return _prod.FProductId; }
        //    set { _prod.FProductId = value; }
        //}

        //public string FProductName
        //{
        //    get { return _prod.FProductName; }
        //    set { _prod.FProductName = value; }
        //}

        //public int FCategoryId
        //{
        //    get { return _prod.FCategoryId; }
        //    set { _prod.FCategoryId = value; }
        //}

        //public decimal FUnitprice
        //{
        //    get { return _prod.FUnitprice; }
        //    set { _prod.FUnitprice = value; }
        //}

        //public string FDescription 
        //{
        //    get { return _prod.FDescription; }
        //    set { _prod.FDescription = value; }
        //}

        //public bool FVisible
        //{
        //    get { return _prod.FVisible; }
        //    set { _prod.FVisible = value; }
        //}

        //public string FCoverImage
        //{
        //    get { return _prod.FCoverImage; }
        //    set { _prod.FCoverImage = value; }
        //}
        //public virtual TProductCategory FCategory { get; set; }
        //public virtual ICollection<TOrderDetail> TOrderDetails { get; set; }
        //public virtual ICollection<TProductsImage> TProductsImages { get; set; }
        //public virtual ICollection<TTrackList> TTrackLists { get; set; }
    }
}
