using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class CProductViewModel
    {
        IHealthContext db = new IHealthContext();

        public IEnumerable<TProduct> ProductList
        {
            get
            {
                var pList = db.TProducts.OrderBy(c => c.FProductId);
                return pList;
            }
        }
    }
}
