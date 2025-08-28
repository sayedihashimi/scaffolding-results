﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages01.Data;
using RazorPages01.Models;

namespace RazorPages01.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPages01.Data.RazorPages01Context _context;

        public DetailsModel(RazorPages01.Data.RazorPages01Context context)
        {
            _context = context;
        }

        public Contact Contact { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FirstOrDefaultAsync(m => m.Id == id);

            if (contact is not null)
            {
                Contact = contact;

                return Page();
            }

            return NotFound();
        }
    }
}
