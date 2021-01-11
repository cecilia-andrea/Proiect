using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Vaida_Cecilia.Data.Vaida_CeciliaContext _context;

        public DetailsModel(Vaida_Cecilia.Data.Vaida_CeciliaContext context)
        {
            _context = context;
        }

        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Car.FirstOrDefaultAsync(m => m.ID == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
