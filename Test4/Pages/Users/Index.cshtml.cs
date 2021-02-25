using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test4.Data;
using Test4.Models;

namespace Test4.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Test4.Data.Test4Context _context;

        public IndexModel(Test4.Data.Test4Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
