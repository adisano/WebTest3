using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTest3.Models;

namespace WebTest3.Pages.Pets
{
    public class IndexModel : PageModel
    {
        private readonly WebTest3.Models.WebTest3Context _context;

        public IndexModel(WebTest3.Models.WebTest3Context context)
        {
            _context = context;
        }

        public IList<Pet> Pet { get;set; }

        public async Task OnGetAsync()
        {
            Pet = await _context.Pet.ToListAsync();
        }
    }
}
