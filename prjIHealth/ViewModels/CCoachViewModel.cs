using Microsoft.AspNetCore.Http;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class CCoachViewModel
    {
        public readonly IHealthContext _context;
        public CCoachViewModel(IHealthContext context)
        {
            _context = context;
        }
        public TCoach _coach;   //為取得Coach關聯table的資料       
    }
}
