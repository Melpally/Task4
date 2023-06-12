﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly AspNetIden.RazorPage.Data.SchoolContext _context;

        public DetailsModel(AspNetIden.RazorPage.Data.SchoolContext context)
        {
            _context = context;
        }

      public User User { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }
    }
}
