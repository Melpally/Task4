using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetIden.RazorPage.Data;
using AspNetIden.RazorPage.Models;

namespace AspNetIden.RazorPage.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly AspNetIden.RazorPage.Data.SchoolContext _context;

        public IndexModel(AspNetIden.RazorPage.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
