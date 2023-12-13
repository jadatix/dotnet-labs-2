using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace lab5.Pages.ManagerView
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Manager> Manager { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Manager = await _context.Managers
                .Include(m => m.Company).ToListAsync();
        }
    }
}
