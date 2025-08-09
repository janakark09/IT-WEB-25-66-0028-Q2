using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManage.Models;

namespace StudentManage.Pages.cources
{
    public class DetailsModel : PageModel
    {
        private readonly StudentManage.Models.StudentManage1Context _context;

        public DetailsModel(StudentManage.Models.StudentManage1Context context)
        {
            _context = context;
        }

        public Cources Cources { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cources = await _context.Cources.FirstOrDefaultAsync(m => m.ID == id);

            if (Cources == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
