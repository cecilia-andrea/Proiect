﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vaida_Cecilia.Data;
using Vaida_Cecilia.Models;

namespace Vaida_Cecilia.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly Vaida_Cecilia.Data.Vaida_CeciliaContext _context;

        public IndexModel(Vaida_Cecilia.Data.Vaida_CeciliaContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.Include(b => b.Publisher).ToListAsync();
        }
    }
}
