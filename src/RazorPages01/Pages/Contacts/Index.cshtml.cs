using System;
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
    public class IndexModel : PageModel
    {
        private readonly RazorPages01.Data.RazorPages01Context _context;

        public IndexModel(RazorPages01.Data.RazorPages01Context context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}
